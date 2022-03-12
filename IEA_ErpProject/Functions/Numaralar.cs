using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IEA_ErpProject.Entity;
using IEA_ErpProject.Entity.Code;

namespace IEA_ErpProject.Functions
{
    public class Numaralar
    {
        private readonly ErpProject102SEntities _db = new ErpProject102SEntities();
        private readonly ErpProContext code = new ErpProContext();
        public string UidNo()
        {
            try
            {
                var numara = (from s in _db.tblUrunKayitUst orderby s.Id descending select s).First().UId;
                numara++;
                string num = numara.ToString().PadLeft(7,'0');
                return num;
            }
            catch (Exception)
            {
                return "0000001";
            }
            
        }

        public string UGirisNo()
        {
            try
            {
                var numara = (from s in _db.tblUrunGirisUst orderby s.Id descending select s).First().GirisId;
                numara++;
                string num = numara.ToString().PadLeft(7, '0');
                return num;
            }
            catch (Exception)
            {
                return "0000001";
            }
        }

        public string KonGonderimNo()
        {
            try
            {
                var numara = (from s in code.TblKonsinyeGonderimler orderby s.Id descending select s).First().GonderimId;
                numara++;
                string num = numara.ToString().PadLeft(7, '0');
                return num;
            }
            catch (Exception)
            {
                return "0000001";
            }

        }
    }
}
