using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Partea2.Data;
using Partea2.Models;

namespace Partea2.Pages.Doctors
{
    public class IndexModel : PageModel
    {
        private readonly Partea2.Data.Partea2Context _context;

        public IndexModel(Partea2.Data.Partea2Context context)
        {
            _context = context;
        }

        public IList<Doctor> Doctor { get;set; }

        public async Task OnGetAsync()
        {
            Doctor = await _context.Doctor.Include(b => b.Programare).ToListAsync();
        }
    }
}
