using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Partea2.Models
{
    public class Doctor
    {
        public int ID { get; set; }

        public string Nume { get; set; }
        public string Prenume { get; set; }
        public int ProgramareID { get; set; }

        [DataType(DataType.Date)]
        public DateTime DataProgramarii { get; set; }
        public Programare Programare { get; set; }

        public ICollection<Client> Client { get; set; }
    }
}
