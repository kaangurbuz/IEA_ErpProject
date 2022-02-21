using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEA_ErpProject.BilgiGiris.Doktorlar
{
    
    public enum Unvan
    {
        [Description("Prof. Dr.")] ProfDr,
        [Description("Opt. Dr.")] OptDr,
        [Description("Doc. Dr.")] DocDr,
        [Description("Yrd. Doc. Dr.")] YrdDocDr,
        [Description("Dr.")] Dr,
        [Description("Uzman Dr.")] UzmanDr,
        [Description("Asistan")] Asistan
    }

 
}
