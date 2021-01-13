using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Galgau_Diana_Proiect.Data;
using Galgau_Diana_Proiect.Models;

namespace Galgau_Diana_Proiect.Pages.Fuels
{
    public class DetailsModel : PageModel
    {
        private readonly Galgau_Diana_Proiect.Data.Galgau_Diana_ProiectContext _context;

        public DetailsModel(Galgau_Diana_Proiect.Data.Galgau_Diana_ProiectContext context)
        {
            _context = context;
        }

        public Fuel Fuel { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Fuel = await _context.Fuel.FirstOrDefaultAsync(m => m.ID == id);

            if (Fuel == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
