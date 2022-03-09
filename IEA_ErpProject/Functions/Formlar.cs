using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IEA_ErpProject.BilgiGiris.Doktorlar;
using IEA_ErpProject.BilgiGiris.Firmalar;
using IEA_ErpProject.BilgiGiris.Hastaneler;
using IEA_ErpProject.BilgiGiris.Personeller;
using IEA_ErpProject.BilgiGiris.Urunler;
using IEA_ErpProject.UrunGiris.Stok;
using IEA_ErpProject.UrunGiris.Urunler;
using IEA_ErpProject.KonsinyeIslemleri.Giris;
using IEA_ErpProject.KonsinyeIslemleri.Cikis;
namespace IEA_ErpProject.Functions
{
    public class Formlar
    {
        public int HastanelerListesiAc(bool secim=false)
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
            frm.MdiParent=Form.ActiveForm;
            frm.Show();
            frm.Ac(id);
        }

        public void HastaneDetayAc(string adi,int id)
        {
            HastaneDetay frm = new HastaneDetay();
            frm.lblHastaneAdi.Text = adi;
            frm.lblHastaneId.Text = id.ToString();
            frm.ShowDialog();
        }

        public int DoktorlarListesiAc(bool secim = false)
        {
            DoktorlarListesi frm = new DoktorlarListesi();
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

        public void DoktorlarGirisAc(int id)
        {
            DoktorGiris frm = new DoktorGiris();
            frm.MdiParent = Form.ActiveForm;
            frm.Show();
            frm.Ac(id);
        }

        public int FirmalarListesiAc(bool secim = false)
        {
            FirmalarListesi frm = new FirmalarListesi();
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

        public void FirmaGirisAc(int id)
        {
            FirmaGiris frm = new FirmaGiris();
            frm.MdiParent = Form.ActiveForm;
            frm.Show();
            frm.Ac(id);
        }

        public void FirmaDetayAc(string adi, int id)
        {
            FirmaDetay frm = new FirmaDetay();
            frm.lblFirmaAdi.Text = adi;
            frm.lblFirmaId.Text = id.ToString();
            frm.ShowDialog();
        }

        public int UrunKayitListesiAc(bool secim = false)
        {
            UrunKayitListesi frm = new UrunKayitListesi();
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

        public int UrunGirisListesiAc(bool secim = false)
        {
            UrunlerGirisListesi frm = new UrunlerGirisListesi();
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

        public int StokDurumAc(bool secim = false)
        {
            StokDurum frm = new StokDurum();
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

        public int PersonellerListesiAc(bool secim = false)
        {
            PersonellerListesi frm = new PersonellerListesi();
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

        public void PersonelGirisAc(int id)
        {
            PersonelGiris frm = new PersonelGiris();
            frm.MdiParent = Form.ActiveForm;
            frm.Show();
            frm.Ac(id);
        }

        public int KonsinyeGonderimListesiAc(bool secim = false)
        {
            KonsinyeGonderimListesi frm = new KonsinyeGonderimListesi();
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

        public int KonsinyeCikisListesiAc(bool secim = false)    
        {
            KonsinyeCikisListesi frm = new KonsinyeCikisListesi();
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
    }
}
