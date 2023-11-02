using System.Net.Http.Json;

namespace ConstructionManagement.Client.Services.OrderServices
{
    public class OrderService : IOrderService
    {
        private readonly HttpClient _httpClient;
        public OrderService(HttpClient http)
        {
            this._httpClient = http;
        }
        public List<Order> orders { get; set ; }

        public async Task GetOrders()
        {
            var result = await _httpClient.GetFromJsonAsync<List<Order>>("api/order");
            if (result != null)
                orders = result;
        }
    }
}
