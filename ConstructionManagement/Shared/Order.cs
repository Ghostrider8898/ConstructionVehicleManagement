using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructionManagement.Shared
{
    public class Order
    {
        public int Id { get; set; }
        public string User { get; set; }
        public List<Item> Items { get; set; }
    }
}
