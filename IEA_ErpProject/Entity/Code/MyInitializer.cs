using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEA_ErpProject.Entity.Code
{
    public class MyInitializer:CreateDatabaseIfNotExists<ErpProContext>
    {
        protected override void Seed(ErpProContext context)
        {
            //Adding admin user
            tblUser admin = new tblUser();
            admin.Name = "Kaan";
            admin.Password = "1234";
            admin.UserName = "KaanG";
            context.TblUsers.Add(admin);
            base.Seed(context);
        }
    }
}
