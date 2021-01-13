using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Galgau_Diana_Proiect.Data;
using Galgau_Diana_Proiect.Models;

namespace Galgau_Diana_Proiect.Pages.TypesOfCars
{
    public class IndexModel : PageModel
    {
        private readonly Galgau_Diana_Proiect.Data.Galgau_Diana_ProiectContext _context;

        public IndexModel(Galgau_Diana_Proiect.Data.Galgau_Diana_ProiectContext context)
        {
            _context = context;
        }

        public IList<TypeOfCar> TypeOfCar { get;set; }

        public async Task OnGetAsync()
        {
            TypeOfCar = await _context.Type.ToListAsync();
        }
    }
}
