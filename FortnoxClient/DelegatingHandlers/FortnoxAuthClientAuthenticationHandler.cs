using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using FortnoxClient.Config;

namespace FortnoxClient.DelegatingHandlers
{
    class FortnoxAuthClientAuthenticationHandler : DelegatingHandler
    {
        private readonly FortnoxConfig config;

        public FortnoxAuthClientAuthenticationHandler(FortnoxConfig config)
        {
            this.config = config;
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var credentials = GetCredentials();

            request.Headers.Authorization = new AuthenticationHeaderValue("Basic", credentials);

            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var response = await base.SendAsync(request, cancellationToken);

            return response;
        }

        private string GetCredentials() =>
            Convert.ToBase64String(
                Encoding.UTF8.GetBytes($"{config.ClientId}:{config.ClientSecret}"),
                Base64FormattingOptions.None);
    }
}