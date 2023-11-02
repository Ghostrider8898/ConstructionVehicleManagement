namespace ConstructionManagement.Client.Services.VehicleServices
{
    public interface IVehicleService
    {
        List<Vehicle> Vehicles { get; set; }
        List<VehicleCategory> Categories { get; set; }
        Task GetVehicleCategories();
        Task GetVehicles();
        Task<Vehicle> GetVehicleById(int Id);
    }
}
