using Refit;

namespace FortnoxClient.Dto.Authenticate
{
    public class RefreshAccessTokenRequest
    {
        public RefreshAccessTokenRequest(string refreshToken)
        {
            RefreshToken = refreshToken;
        }

        [AliasAs("grant_type")] 
        public string GrantType => "refresh_token";

        [AliasAs("refresh_token")] 
        public string RefreshToken { get; }
    }
}