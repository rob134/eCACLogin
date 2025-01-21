using System.Net.Http;
using System.Text;
using System.Text.Json;
using eCACLogin.Models;

namespace eCACLogin.Services
{
    public class GovBrLoginService
    {
        private readonly HttpClient _httpClient;

        public GovBrLoginService()
        {
            _httpClient = new HttpClient();
        }

        public async Task<LoginResult> Login(string username, string password)
        {
            var url = "https://example-govbr-login-api-url.com/authenticate"; // URL fictícia.
            var requestContent = new
            {
                UserName = username,
                Password = password
            };

            var content = new StringContent(
                JsonSerializer.Serialize(requestContent),
                Encoding.UTF8,
                "application/json"
            );

            var response = await _httpClient.PostAsync(url, content);

            if (response.IsSuccessStatusCode)
            {
                return new LoginResult
                {
                    Success = true,
                    Message = "Login via Gov.br realizado com sucesso!"
                };
            }

            return new LoginResult
            {
                Success = false,
                Message = "Falha no login via Gov.br."
            };
        }
    }
}
