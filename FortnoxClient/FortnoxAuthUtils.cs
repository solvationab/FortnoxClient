using System;
using FortnoxClient.Config;

namespace FortnoxClient
{
    public static class FortnoxAuthUtils
    {
        public static Uri GetAuthenticateUrl(FortnoxConfig apiConfig, string state)
        {
            var responseType = "code";
            var scopes = "companyinformation bookkeeping article settings invoice currency customer payment offer order price print profile connectfile";
            var accountType = "service";
            var accessType = "offline";

            var builder = new UriBuilder("https://apps.fortnox.se/oauth-v1/auth")
            {
                Query = $"client_id={Uri.EscapeDataString(apiConfig.ClientId)}&response_type={Uri.EscapeDataString(responseType)}&state={Uri.EscapeDataString(state)}&scope={Uri.EscapeDataString(scopes)}&access_type={Uri.EscapeDataString(accessType)}&account_type={Uri.EscapeDataString(accountType)}&redirect_uri="
            };

            return builder.Uri;

            //return $"https://apps.fortnox.se/oauth-v1/auth?client_id={Uri.EscapeDataString(config.ClientId)}&response_type={Uri.EscapeDataString(responseType)}&state={Uri.EscapeDataString(state)}&scope={Uri.EscapeDataString(scopes)}&access_type={Uri.EscapeDataString(accessType)}&account_type={Uri.EscapeDataString(accountType)}&redirect_uri=";
        }
    }
}