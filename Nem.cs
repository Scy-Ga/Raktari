﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raktári
{
    [Table("Nem")]
    class Nem
    {
        public int ID { get; set; }
        [Required]
        public string Megnevezes { get; set; }
    }
}
