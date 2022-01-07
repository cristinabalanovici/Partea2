using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Partea2.Data;
using Partea2.Models;

namespace Partea2.Pages.Doctors
{
    public class CreateModel : PageModel
    {
        private readonly Partea2.Data.Partea2Context _context;

        public CreateModel(Partea2.Data.Partea2Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["ProgramareID"] = new SelectList(_context.Set<Programare>(), "ID", "NumarulProgramarii");
            return Page();
        }

        [BindProperty]
        public Doctor Doctor { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Doctor.Add(Doctor);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
