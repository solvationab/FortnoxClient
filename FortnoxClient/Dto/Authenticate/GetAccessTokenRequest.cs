using Refit;

namespace FortnoxClient.Dto.Authenticate
{
    public class GetAccessTokenRequest
    {
        public GetAccessTokenRequest(string authorizationCode, string redirectUrl)
        {
            AuthorizationCode = authorizationCode;
            RedirectUrl = redirectUrl;
        }

        [AliasAs("grant_type")]
        public string GrantType => "authorization_code";

        [AliasAs("code")]
        public string AuthorizationCode { get; }

        [AliasAs("redirect_uri")]
        public string RedirectUrl { get; }
    }
}