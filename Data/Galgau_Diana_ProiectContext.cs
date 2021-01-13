using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Galgau_Diana_Proiect.Models;

namespace Galgau_Diana_Proiect.Data
{
    public class Galgau_Diana_ProiectContext : DbContext
    {
        public Galgau_Diana_ProiectContext (DbContextOptions<Galgau_Diana_ProiectContext> options)
            : base(options)
        {
        }

        public DbSet<Galgau_Diana_Proiect.Models.Car> Car { get; set; }

        public DbSet<Galgau_Diana_Proiect.Models.TypeOfCar> Type { get; set; }

        public DbSet<Galgau_Diana_Proiect.Models.Fuel> Fuel { get; set; }
    }
}
