namespace ConstructionManagement.Client.Services.OrderServices
{
    public interface IOrderService
    {
        List<Order> orders { get; set; }
        Task GetOrders();
    }
}
