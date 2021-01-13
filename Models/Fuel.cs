using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Galgau_Diana_Proiect.Models
{
    public class Fuel
    {
        public int ID { get; set; }
        public string FuelName { get; set; }
        public ICollection<Car> Cars { get; set; }
    }
}
