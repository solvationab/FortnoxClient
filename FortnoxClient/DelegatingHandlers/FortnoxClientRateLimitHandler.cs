using System;
using System.Globalization;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.RateLimiting;
using System.Threading.Tasks;

namespace FortnoxClient.DelegatingHandlers
{
    public sealed class FortnoxClientRateLimitHandler : DelegatingHandler
    {
        private static readonly RateLimiter RateLimiter = new SlidingWindowRateLimiter(
            new SlidingWindowRateLimiterOptions
            {
                AutoReplenishment = true,
                PermitLimit = 25,
                QueueLimit = 5000,
                QueueProcessingOrder = QueueProcessingOrder.OldestFirst,
                SegmentsPerWindow = 1,
                Window = TimeSpan.FromSeconds(5)
            });

        protected override async Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request, CancellationToken cancellationToken)
        {
            using (var lease = await RateLimiter.AcquireAsync(1, cancellationToken))
            {
                if (lease.IsAcquired)
                    return await base.SendAsync(request, cancellationToken);

                var response = new HttpResponseMessage((HttpStatusCode)429);

                if (lease.TryGetMetadata(MetadataName.RetryAfter, out var retryAfter))
                {
                    response.Headers.Add(
                        "Retry-After",
                        ((int)retryAfter.TotalSeconds).ToString(NumberFormatInfo.InvariantInfo));
                }

                return response;
            }
        }
    }
}