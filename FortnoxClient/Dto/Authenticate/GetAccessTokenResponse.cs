using System.Text.Json.Serialization;

namespace FortnoxClient.Dto.Authenticate
{
    public class GetAccessTokenResponse
    {
        public GetAccessTokenResponse(string accessToken, string refreshToken, string scope, int expiresIn,
            string tokenType)
        {
            AccessToken = accessToken;
            RefreshToken = refreshToken;
            Scope = scope;
            ExpiresIn = expiresIn;
            TokenType = tokenType;
        }

        [JsonPropertyName("access_token")] public string AccessToken { get; }

        [JsonPropertyName("refresh_token")] public string RefreshToken { get; }

        [JsonPropertyName("scope")] public string Scope { get; }

        [JsonPropertyName("expires_in")] public int ExpiresIn { get; }

        [JsonPropertyName("token_type")] public string TokenType { get; }
    }
}