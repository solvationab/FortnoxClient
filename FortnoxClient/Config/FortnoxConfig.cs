namespace FortnoxClient.Config
{
    public class FortnoxConfig
    {
        public FortnoxConfig(string clientId, string clientSecret)
        {
            ClientId = clientId;
            ClientSecret = clientSecret;
        }

        public string ClientId { get; }
        public string ClientSecret { get; }
    }
}