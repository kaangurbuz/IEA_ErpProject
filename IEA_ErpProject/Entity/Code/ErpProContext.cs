using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEA_ErpProject.Entity.Code
{
    public class ErpProContext:DbContext 
    {
        public ErpProContext() : base("name=ErpProject102Code")
        {
            Database.SetInitializer(new MyInitializer());
        }
        public DbSet<tblUser> TblUsers { get; set; }
        public DbSet<tblKonsinyeGonderim> TblKonsinyeGonderimler { get; set; }

       
    }
}
