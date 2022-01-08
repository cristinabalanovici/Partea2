using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Partea2.Models
{
    public class ProgramareServiciu
    {
        public int Id { get; set; }
        public int ProgramareId { get; set; }
        public Programare Programare { get; set; }

        public int ServiciuId { get; set; }

        public Serviciu Serviciu { get; set; }

    }
}
