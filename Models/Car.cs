using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Galgau_Diana_Proiect.Models
{
    public class Car
    {
        public int ID { get; set; }
        [Display(Name = "Car Brand")]
        public string Brand { get; set; }
        public string Model { get; set; }

        [Column(TypeName = "decimal(6, 2)")]
        public decimal Price { get; set; }
        [DataType(DataType.Date)]
        public DateTime YearOfManufacture { get; set; }
        public int TypeOfCarID { get; set; }
        public TypeOfCar TypeOfCar { get; set; }
        public int FuelID { get; set; }
        public Fuel Fuel { get; set; }
    }
}
