using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;

namespace FortnoxClient.DelegatingHandlers
{
    public class FortnoxClientAuthenticationHandler : DelegatingHandler
    {
        private readonly IFortnoxTokenProvider tokenProvider;

        public FortnoxClientAuthenticationHandler(IFortnoxTokenProvider tokenProvider)
        {
            this.tokenProvider = tokenProvider;
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var fortnoxAccessToken = tokenProvider.Get();

            if (fortnoxAccessToken != null)
            {
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", fortnoxAccessToken);
            }

            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var response = await base.SendAsync(request, cancellationToken);

            return response;
        }
    }
}