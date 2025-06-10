using System.Net.Http.Json;

namespace CocQuery.Services
{
    public class CocLayoutService
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiUrl;

        public CocLayoutService()
        {
            _httpClient = new HttpClient() ;
            _apiUrl = "http://60.205.5.227:8081/";
        }

        // 获取所有阵型信息
        public async Task<List<CocQuery.Models.CocLayoutInfo>> GetAllAsync()
        {
            try
            {
                var response = await _httpClient.GetAsync($"{_apiUrl}/api/CocLayout");
                response.EnsureSuccessStatusCode();
                var layouts = await response.Content.ReadFromJsonAsync<List<CocQuery.Models.CocLayoutInfo>>();
                return layouts;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving data: {ex.Message}");
                return null;
            }
        }

        // 根据 ID 获取单个阵型信息
        public async Task<CocQuery.Models.CocLayoutInfo> GetByIdAsync(Guid id)
        {
            try
            {
                var response = await _httpClient.GetAsync($"{_apiUrl}/api/CocLayout/{id}");
                response.EnsureSuccessStatusCode();
                var layout = await response.Content.ReadFromJsonAsync<CocQuery.Models.CocLayoutInfo>();
                return layout;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error retrieving data: {ex.Message}");
                return null;
            }
        }

        // 添加新的阵型信息
        public async Task<CocQuery.Models.CocLayoutInfo> AddAsync(CocQuery.Models.CocLayoutInfo layout)
        {
            try
            {
                var response = await _httpClient.PostAsJsonAsync($"{_apiUrl}/api/CocLayout", layout);
                response.EnsureSuccessStatusCode();
                var createdLayout = await response.Content.ReadFromJsonAsync<CocQuery.Models.CocLayoutInfo>();
                return createdLayout;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding data: {ex.Message}");
                return null;
            }
        }

        // 更新阵型信息
        public async Task<bool> UpdateAsync(Guid id, CocQuery.Models.CocLayoutInfo layout)
        {
            try
            {
                var response = await _httpClient.PutAsJsonAsync($"{_apiUrl}/api/CocLayout/{id}", layout);
                response.EnsureSuccessStatusCode();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating data: {ex.Message}");
                return false;
            }
        }

        // 删除阵型信息
        public async Task<bool> DeleteAsync(Guid id)
        {
            try
            {
                var response = await _httpClient.DeleteAsync($"{_apiUrl}/api/CocLayout/{id}");
                response.EnsureSuccessStatusCode();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting data: {ex.Message}");
                return false;
            }
        }
    }
}
