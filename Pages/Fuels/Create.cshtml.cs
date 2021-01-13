using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Galgau_Diana_Proiect.Data;
using Galgau_Diana_Proiect.Models;

namespace Galgau_Diana_Proiect.Pages.Fuels
{
    public class CreateModel : PageModel
    {
        private readonly Galgau_Diana_Proiect.Data.Galgau_Diana_ProiectContext _context;

        public CreateModel(Galgau_Diana_Proiect.Data.Galgau_Diana_ProiectContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Fuel Fuel { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Fuel.Add(Fuel);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
