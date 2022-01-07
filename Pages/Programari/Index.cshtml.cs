using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Partea2.Data;
using Partea2.Models;

namespace Partea2.Pages.Programari
{
    public class IndexModel : PageModel
    {
        private readonly Partea2.Data.Partea2Context _context;

        public IndexModel(Partea2.Data.Partea2Context context)
        {
            _context = context;
        }

        public IList<Programare> Programare { get;set; }

        public async Task OnGetAsync()
        {
            Programare = await _context.Programare.ToListAsync();
        }
    }
}
