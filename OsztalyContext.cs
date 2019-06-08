using MySql.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raktári
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    class OsztalyContext: DbContext
    {
        public DbSet<Osztaly> Osztalyok { get; set; }
        public DbSet<Nem> Nemek { get; set; }
         
    }
}
