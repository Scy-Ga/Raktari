using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raktári
{
    [Table("Osztaly")]
    class Osztaly
    {
        public int ID { get; set; }
        [Required]
        public string Nev { get; set; }
        public Nem Neme { get; set; } // Idegen kulcs
    }
}
