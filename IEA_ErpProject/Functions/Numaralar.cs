using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IEA_ErpProject.Entity;

namespace IEA_ErpProject.Functions
{
    public class Numaralar
    {
        private readonly ErpProject102SEntities _db = new ErpProject102SEntities();
        public string UidNo()
        {
            try
            {
                var numara = (from s in _db.tblUrunKayitUst orderby s.Id descending select s).First().UId;
                numara++;
                string num = numara.ToString().PadLeft(7,'0');
                return num;
            }
            catch (Exception e)
            {
                return "0000001";
            }
            
        }
    }
}
