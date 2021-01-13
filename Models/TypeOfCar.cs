using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Galgau_Diana_Proiect.Models
{
    public class TypeOfCar
    {
        public int ID { get; set; }
        public string TypeOfCarName { get; set; }
        public ICollection<Car> Cars { get; set; }
    }
}
