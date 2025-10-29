using ProjetoClinicaMedica.Domain;
using ProjetoClinicaMedicaa.Shared;
using System.Net.Http.Json;

namespace ProjetoClinicaMedica.Web.Service
{
    public class MedicoService
    {
        private readonly HttpClient _httpClient;

        public MedicoService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<Medico>> GetMedicosAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<Medico>>("api/medicos");
        }
        public async Task<Medico> GetMedicoByIdAsync(int id)
        {
            return await _httpClient.GetFromJsonAsync<Medico>($"api/medicos/{id}");
        }
        public async Task<Medico> CreateMedicosAsync(Medico medico)
        {
            var response = await _httpClient.PostAsJsonAsync("api/medicos", medico);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<Medico>();
        }
        public async Task UpdateMedicosAsync(Medico medico)
        {
            var response = await _httpClient.PutAsJsonAsync($"api/medicos/{medico.Id}", medico);
            response.EnsureSuccessStatusCode();
        }
        public async Task DeleteMedicoAsync(int id)
        {

            var response = await _httpClient.DeleteAsync($"api/medicos/{id}");
            response.EnsureSuccessStatusCode();
        }
    }
}