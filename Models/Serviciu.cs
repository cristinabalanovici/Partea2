using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Partea2.Models
{
    public class Serviciu
    {
        public int ID { get; set; }
        public string Nume { get; set; }
        public ICollection<ProgramareServiciu> ProgramareServicii { get; set; }
    }
}
