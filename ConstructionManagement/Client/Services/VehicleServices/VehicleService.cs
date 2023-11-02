using System.Net.Http.Json;

namespace ConstructionManagement.Client.Services.VehicleServices
{
    public class VehicleService : IVehicleService
    {
        private readonly HttpClient _httpClient;
        public VehicleService(HttpClient http)
        {
            this._httpClient = http;
        }
        public List<Vehicle> Vehicles { get; set ; } = new List<Vehicle>();
        public List<VehicleCategory> Categories { get; set; } = new List<VehicleCategory>();

        public Task<Vehicle> GetVehicleById(int Id)
        {
            throw new NotImplementedException();
        }

        public Task GetVehicleCategories()
        {
            throw new NotImplementedException();
        }

        public async Task GetVehicles()
        {
            var result = await _httpClient.GetFromJsonAsync<List<Vehicle>>("api/vehicle");
            if (result != null)
                Vehicles = result;
        }
    }
}
