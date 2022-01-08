using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Partea2.Models;

namespace Partea2.Data
{
    public class Partea2Context : DbContext
    {
        public Partea2Context (DbContextOptions<Partea2Context> options)
            : base(options)
        {
        }

        public DbSet<Partea2.Models.Doctor> Doctor { get; set; }

        public DbSet<Partea2.Models.Programare> Programare { get; set; }

        public DbSet<Partea2.Models.Client> Client { get; set; }

        public DbSet<Partea2.Models.Serviciu> Serviciu { get; set; }
    }
}
