using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Partea2.Data;
using Partea2.Models;

namespace Partea2.Pages.Servicii
{
    public class DetailsModel : PageModel
    {
        private readonly Partea2.Data.Partea2Context _context;

        public DetailsModel(Partea2.Data.Partea2Context context)
        {
            _context = context;
        }

        public Serviciu Serviciu { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Serviciu = await _context.Serviciu.FirstOrDefaultAsync(m => m.ID == id);

            if (Serviciu == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
