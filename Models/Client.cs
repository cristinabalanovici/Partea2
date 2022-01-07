using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Partea2.Models
{
    public class Client
    {
        public int ID { get; set; }
        public string Nume{ get; set; }
        public string Prenume { get; set; }
        public Doctor Doctor { get; set; }
        public ICollection<Programare> Programare { get; set; }
        public string Review { get; set; }
    }
}
