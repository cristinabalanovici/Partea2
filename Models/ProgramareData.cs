using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Partea2.Models
{
    public class ProgramareData
    {
        public IEnumerable<Programare> Programari { get; set; }
        public IEnumerable<Serviciu> Servicii { get; set; }
        public IEnumerable<ProgramareServiciu> ProgramareServicii { get; set; }
    }
}
