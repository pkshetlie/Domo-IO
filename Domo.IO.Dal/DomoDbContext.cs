using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domo.IO.Dal
{
    public class DomoDbContext : DbContext
    {
        //public IDbSet<SadTv> Tvs { get; set; }
    
        public DomoDbContext() : base("DomoDbConnection")
        {

        }
    }
}
