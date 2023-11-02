using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructionManagement.Shared
{
    public class VehicleCategory
    {
        public int Id { get; set; }
        public string Category { get; set; } = String.Empty;
        public int RatePerHour { get; set; }
    }
}
