using FortnoxClient.DelegatingHandlers;
using FortnoxClient.Dto;
using FortnoxClient.JsonConverters;
using FortnoxClient.UrlParameterFormatters;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Refit;
using System;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace FortnoxClient.Extensions
{
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// This extension method adds Fortnox api to the service collection.
        ///
        /// To work it need a implementation of IFortnoxTokenPriver
        /// and a FortnoxConfig added to the service collection.
        /// </summary>
        /// <param name="services"></param>
        /// <returns>The IServiceCollection to allow chaining</returns>
        public static IServiceCollection AddFortnoxClient(this IServiceCollection services)
        {
            // Add delegating handlers used by the Fortnox Client
            services
                .AddScoped<FortnoxClientRateLimitHandler>()
                .AddScoped<FortnoxAuthClientAuthenticationHandler>()
                .AddScoped<FortnoxClientAuthenticationHandler>()
                .AddScoped<HttpLoggingHandler>();

            // Add the Fortnox API Auth api
            services
                .AddRefitClient<IFortnoxAuthClient>()
                .ConfigureHttpClient(httpClient => httpClient.BaseAddress = new Uri("https://apps.fortnox.se"))
                .AddHttpMessageHandler<HttpLoggingHandler>()
                .AddHttpMessageHandler<FortnoxAuthClientAuthenticationHandler>();

            // Add the Fortnox API
            services
                .AddRefitClient<IFortnoxClient>(sp =>
                {
                    var settings = new RefitSettings
                    {
                        ContentSerializer = new SystemTextJsonContentSerializer(GetJsonSerializerOptions()),
                        UrlParameterFormatter = new FortnoxUrlParameterFormatter()
                    };

                    settings.ExceptionFactory = async responseMessage =>
                    {
                        if (responseMessage.IsSuccessStatusCode)
                            return null;

                        var fortnoxError = await responseMessage.Content.ReadFromJsonAsync<FortnoxErrorResponse>();

                        if (fortnoxError?.ErrorInformation != null)
                        {
                            return new FortnoxException(fortnoxError);
                        }

                        var requestMessage = responseMessage.RequestMessage;

                        var method = requestMessage.Method;

                        return await ApiException
                            .Create(requestMessage, method, responseMessage, settings);
                    };

                    return settings;
                })
                .ConfigureHttpClient(httpClient => httpClient.BaseAddress = new Uri("https://api.fortnox.se"))
                .AddHttpMessageHandler<HttpLoggingHandler>()
                .AddHttpMessageHandler<FortnoxClientAuthenticationHandler>()
                .AddHttpMessageHandler<FortnoxClientRateLimitHandler>();

            return services;
        }

        public static IServiceCollection AddConfig<T>(this IServiceCollection services, IConfiguration configuration, string key)
            where T : class
        {
            var config = configuration
                    .GetRequiredSection(key)
                    .Get<T>()
                ?? throw new InvalidOperationException("Unable to get " + typeof(T).Name +" from section " + key +" in config");

            services.AddSingleton(config);

            return services;
        }

        public static JsonSerializerOptions GetJsonSerializerOptions()
        {
            return new JsonSerializerOptions
            {
                NumberHandling = JsonNumberHandling.AllowReadingFromString,
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
                Converters = { new FortnoxDateTimeConverter(), new FortnoxNullableDateTimeConverter(), new JsonStringEnumConverterEx() }
            };
        }
    }
}