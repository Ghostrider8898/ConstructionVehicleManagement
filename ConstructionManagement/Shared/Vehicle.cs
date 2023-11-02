using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructionManagement.Shared
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string NumberPlate { get; set; } = String.Empty;
        public string AvaibilityStatus { get; set; } = String.Empty;
        public VehicleCategory? vehicleCategory { get; set; }
        public int CategoryId { get; set; }

    }
}
