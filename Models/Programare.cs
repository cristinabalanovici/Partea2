using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Partea2.Models
{
    public class Programare
    {
        public int ID { get; set; }
        public int NumarulProgramarii { get; set; }
        public DateTime Data { get; set; }

        public int ClientId { get; set; }
    }
}
