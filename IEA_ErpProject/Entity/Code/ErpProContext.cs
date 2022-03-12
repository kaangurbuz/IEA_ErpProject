using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IEA_ErpProject.Entity.Code
{
    public class ErpProContext:DbContext 
    {
        AnaSayfa ana = Application.OpenForms["Anasayfa"]as AnaSayfa;
        public ErpProContext() : base("name=ErpProject102Code")
        {
            Database.SetInitializer(new MyInitializer());
        }
        public DbSet<tblUser> TblUsers { get; set; }
        public DbSet<tblKonsinyeGonderim> TblKonsinyeGonderimler { get; set; }

        public override int SaveChanges()
        {
            var datas = ChangeTracker.Entries<BaseEntitiy>();
            foreach (var data in datas)
            {
                if (data.State == EntityState.Added)
                {
                    data.Entity.CreatedDate = DateTime.Now;
                    data.Entity.CreatedUser = ana.lblUserNickName.Text;
                    data.Entity.isDeleted = false;
                }
                else if(data.State == EntityState.Modified)
                {
                    data.Entity.UpdatedDate = DateTime.Now;
                    data.Entity.UpdatedUser = ana.lblUserNickName.Text;

                }
            }
            return base.SaveChanges();
        }
    }
}
