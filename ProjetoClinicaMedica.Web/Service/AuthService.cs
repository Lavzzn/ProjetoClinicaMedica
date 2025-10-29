using System.Net.Http.Json;

namespace ProjetoClinicaMedica.Web.Service
{
    public class AuthService
    {
        private readonly HttpClient _httpClient;

        public AuthService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> LoginAsync(string username, string password)
        {
            var loginData = new
            {
                Username = username,
                Password = password
            };
            var response = await _httpClient.PostAsJsonAsync("api/auth/login", loginData);
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadFromJsonAsync<dynamic>();
                return result.Nome;
            }
            else
            {
                throw new Exception("Login Falho :" + await response.Content.ReadAsStringAsync());
            }
        }
        public async Task RegisterAsync(string nome, string email, string senha)
        {
            var registerRequest = new
            {
                Nome = nome,
                Email = email,
                Senha = senha
            };
            var response = await _httpClient.PostAsJsonAsync("api/auth/register", registerRequest);
            if (response.IsSuccessStatusCode)
            {
                throw new Exception("Registro Falhou : " + await response.Content.ReadAsStringAsync());
            }
        }
    }
}