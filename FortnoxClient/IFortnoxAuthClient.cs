using System.Threading.Tasks;
using FortnoxClient.Dto.Authenticate;
using Refit;

namespace FortnoxClient
{
    public interface IFortnoxAuthClient
    {
        [Post("/oauth-v1/token")]
        Task<GetAccessTokenResponse> GetAccessToken(
            [Body(BodySerializationMethod.UrlEncoded)] GetAccessTokenRequest request);

        [Post("/oauth-v1/token")]
        Task<RefreshAccessTokenResponse> RefreshAccessToken(
            [Body(BodySerializationMethod.UrlEncoded)] RefreshAccessTokenRequest request);
    }
}