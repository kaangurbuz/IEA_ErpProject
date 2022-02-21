using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IEA_ErpProject.Functions;
using IEA_Project_YanSanayi.BilgiGiris.Doktorlar;
using IEA_Project_YanSanayi.BilgiGiris.Firmalar;
using IEA_Project_YanSanayi.BilgiGiris.Hastaneler;
using IEA_Project_YanSanayi.BilgiGiris.Personeller;
using IEA_Project_YanSanayi.UrunGiris.Urunler;

namespace IEA_Project_YanSanayi
{
    public partial class AnaSayfa : Form
    {
        readonly Formlar f = new Formlar();
        public static int Aktarma = -1;
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {

        }

        private void BtnBilgiGiris_Click(object sender, EventArgs e)
        {
            lblSolUstMenu.Text = BtnBilgiGiris.Text;
            MenuOlustur(1);
        }

        private void BtnUrunGiris_Click(object sender, EventArgs e)
        {
            lblSolUstMenu.Text = BtnUrunGiris.Text;
            MenuOlustur(2);
        }
        private void MenuOlustur(int secim)
        {
            TvMenu.Nodes.Clear();
            switch (secim)
            {
                case 1: TvMenu.Nodes.Add("Hastaneler");
                    TvMenu.Nodes[0].Nodes.Add("Hastaneler Listesi");
                    TvMenu.Nodes[0].Nodes.Add("Hastane Bilgi Giris");

                    TvMenu.Nodes.Add("Doktorlar");
                    TvMenu.Nodes[1].Nodes.Add("Doktorlar Listesi");
                    TvMenu.Nodes[1].Nodes.Add("Doktor Bilgi Giris");

                    TvMenu.Nodes.Add("Firmalar");
                    TvMenu.Nodes[2].Nodes.Add("Firmalar Listesi");
                    TvMenu.Nodes[2].Nodes.Add("Firma Bilgi Giris");

                    TvMenu.Nodes.Add("Personeller");
                    TvMenu.Nodes[3].Nodes.Add("Personeller Listesi");
                    TvMenu.Nodes[3].Nodes.Add("Personel Bilgi Giris");


                    break;
                case 2:
                    TvMenu.Nodes.Add("Urunler");
                    TvMenu.Nodes[0].Nodes.Add("Urunler Listesi");
                    TvMenu.Nodes[0].Nodes.Add("Urun Giris");
                    
                    break;
                    
            }
        }

        private void TvMenu_DoubleClick(object sender, EventArgs e)
        {
            
            string isim = "";
            if (TvMenu.SelectedNode != null)
                isim=TvMenu.SelectedNode.Text;

            if (isim == "Hastaneler Listesi" && Application.OpenForms["HastanelerListesi"] == null)
            {
                HastanelerListesi frm = new HastanelerListesi();
                frm.MdiParent = Form.ActiveForm;
                frm.Show();
            }

            else if (isim == "Hastane Bilgi Giris" && Application.OpenForms["HastaneGiris"] == null)
            {
                HastaneGiris frm = new HastaneGiris();
                frm.MdiParent = Form.ActiveForm;
                frm.Show();
            }

            else if (isim == "Doktorlar Listesi" && Application.OpenForms["DoktorlarListesi"] == null)
            {
                DoktorlarListesi frm = new DoktorlarListesi();
                frm.MdiParent = Form.ActiveForm;
                frm.Show();
            }

            else if (isim == "Doktor Bilgi Giris" && Application.OpenForms["DoktorGiris"] == null)
            {
                DoktorGiris frm = new DoktorGiris();
                frm.MdiParent = Form.ActiveForm;
                frm.Show();
            }

            else if (isim == "Firmalar Listesi" && Application.OpenForms["FirmalarListesi"] == null)
            {
                FirmalarListesi frm = new FirmalarListesi();
                frm.MdiParent = Form.ActiveForm;
                frm.Show();
            }

            else if (isim == "Firma Bilgi Giris" && Application.OpenForms["FirmaGiris"] == null)
            {
                FirmaGiris frm = new FirmaGiris();
                frm.MdiParent = Form.ActiveForm;
                frm.Show();

            }

            else if (isim == "Personeller Listesi" && Application.OpenForms["PersonellerListesi"] == null)
            {
                PersonellerListesi frm = new PersonellerListesi();
                frm.MdiParent = Form.ActiveForm;
                frm.Show();
            }

            else if (isim == "Personel Bilgi Giris" && Application.OpenForms["PersonelGiris"] == null)
            {
                PersonelGiris frm = new PersonelGiris();
                frm.MdiParent = Form.ActiveForm;
                frm.Show();
            }

            else if (isim == "Urunler Listesi" && Application.OpenForms["UrunlerListesi"] == null)
            {
                UrunlerListesi frm = new UrunlerListesi();
                frm.MdiParent = Form.ActiveForm;
                frm.Show();
            }

            else if (isim == "Urun Giris" && Application.OpenForms["UrunGiris"] == null)
            {
                UrunGiris.Urunler.UrunGiris frm = new UrunGiris.Urunler.UrunGiris();
                frm.MdiParent = Form.ActiveForm;
                frm.Show();
            }


        }
    }
}
