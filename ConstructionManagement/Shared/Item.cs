using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructionManagement.Shared
{
    public class Item
    {
        public int Id { get; set; }
        public Vehicle? vehicle { get; set; }
        public VehicleCategory? vehicleCategory { get; set; }
        public int Quantity { get; set; }

    }
}
