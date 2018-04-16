using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tranactionsDB.DataContext
{
    class Data : DbContext
    {
        public Data() :base("name=DefaultConnection")
        {

        }

        public DbSet<Transactions> Transactions { get; set; }
    }
}
