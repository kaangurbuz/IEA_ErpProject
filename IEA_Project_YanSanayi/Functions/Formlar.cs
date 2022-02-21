using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IEA_Project_YanSanayi.BilgiGiris.Hastaneler;
using HastaneGiris = IEA_Project_YanSanayi.BilgiGiris.Hastaneler.HastaneGiris;
using HastanelerListesi = IEA_Project_YanSanayi.BilgiGiris.Hastaneler.HastanelerListesi;

namespace IEA_Project_YanSanayi.Functions
{
    internal class Formlar
    {
        public int HastanelerListesiAc(bool secim = false)
        {
            HastanelerListesi frm = new HastanelerListesi();
            if (secim)
            {
                frm.Secim = true;
                frm.ShowDialog();
            }
            else
            {
                frm.MdiParent = Form.ActiveForm;
                frm.Show();
            }
            return AnaSayfa.Aktarma;
        }

        public void HastaneGirisAc(int id)
        {
            HastaneGiris frm = new HastaneGiris();
            frm.MdiParent = Form.ActiveForm;
            frm.Show();
            frm.Ac(id);
        }

        public void HastaneDetayAc(string adi, int id)
        {
            HastaneDetay frm = new HastaneDetay();
            frm.lblHastaneAdi.Text = adi;
            frm.lblHastaneId.Text = id.ToString();
            frm.ShowDialog();
        }
    }
}
