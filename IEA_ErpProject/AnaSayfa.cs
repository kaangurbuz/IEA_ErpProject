using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IEA_ErpProject.BilgiGiris.Doktorlar;
using IEA_ErpProject.BilgiGiris.Firmalar;
using IEA_ErpProject.BilgiGiris.Hastaneler;
using IEA_ErpProject.BilgiGiris.Personeller;
using IEA_ErpProject.BilgiGiris.Urunler;
using IEA_ErpProject.Functions;
using IEA_ErpProject.UrunGiris.Stok;
using IEA_ErpProject.UrunGiris.Urunler;

namespace IEA_ErpProject
{
    public partial class AnaSayfa : Form
    {
        readonly Formlar f = new Formlar();
        public static int Aktarma = -1;
        //private bool closeTab = false;
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {

        }

        private void MenuOlustur(int secim)
        {
            TvMenu.Nodes.Clear();
            switch (secim)
            {
                case 1:

                    TvMenu.Nodes.Add("Hastaneler"); //root
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
                    
                    TvMenu.Nodes.Add("Urunler");
                    TvMenu.Nodes[4].Nodes.Add("Urun Kayit Listesi");
                    TvMenu.Nodes[4].Nodes.Add("Urun Kayit");

                    break;

                case 2:

                    TvMenu.Nodes.Add("Urunler Giris"); //root
                    TvMenu.Nodes[0].Nodes.Add("Urunler Listesi");
                    TvMenu.Nodes[0].Nodes.Add("Urun Giris");
                    break;
                case 3:
                    TvMenu.Nodes.Add("Stok"); //root
                    TvMenu.Nodes[0].Nodes.Add("Stok Durum");
                    //TvMenu.Nodes[0].Nodes.Add("Urun Giris");
                    break;
            }

        }
        #region MenuButton
        private void BtnBilgiGiris_Click(object sender, EventArgs e)
        {
            lblSolUstMenu.Text = BtnBilgiGiris.Text;
            MenuOlustur(1); // bilgi menu
        }

        private void BtnUrunGiris_Click(object sender, EventArgs e)
        {
            lblSolUstMenu.Text = BtnUrunGiris.Text;
            MenuOlustur(2); // urun menu
        }
        private void BtnStok_Click(object sender, EventArgs e)
        {
            lblSolUstMenu.Text = BtnStok.Text;
            MenuOlustur(3); // stok menu
        }

        #endregion
        private void TvMenu_DoubleClick(object sender, EventArgs e)
        {
            string isim = "";
            if (TvMenu.SelectedNode!=null)
            {
                isim = TvMenu.SelectedNode.Text;
            }

            #region Hastaneler
            if (isim == "Hastaneler Listesi" && Application.OpenForms["HastanelerListesi"] == null)
            {
                f.HastanelerListesiAc();
            }
            else if (isim == "Hastane Bilgi Giris" && Application.OpenForms["HastaneGiris"] == null)
            {
                HastaneGiris frm = new HastaneGiris();
                frm.MdiParent = Form.ActiveForm;
                frm.Show();
            }
            #endregion
            #region Doktorlar
            else if (isim == "Doktorlar Listesi" && Application.OpenForms["DoktorlarListesi"] == null)
            {
               
                f.DoktorlarListesiAc();
            }
            else if (isim == "Doktor Bilgi Giris" && Application.OpenForms["DoktorGiris"] == null)
            {
                DoktorGiris frm = new DoktorGiris();
                frm.MdiParent = Form.ActiveForm;
                frm.Show();
            }
            #endregion
            #region Firmalar
            else if (isim == "Firmalar Listesi" && Application.OpenForms["FirmalarListesi"] == null)
            {
                f.FirmalarListesiAc();
            }

            else if (isim == "Firma Bilgi Giris" && Application.OpenForms["FirmaGiris"] == null)
            {
                FirmaGiris frm = new FirmaGiris();
                frm.MdiParent = Form.ActiveForm;
                frm.Show();
            }
            #endregion
            #region Personeller
            else if (isim == "Personel Bilgi Giris" && Application.OpenForms["PersonelGiris"] == null)
            {
                PersonelGiris frm = new PersonelGiris();
                frm.MdiParent = Form.ActiveForm;
                frm.Show();
            }

            else if (isim == "Personeller Listesi" && Application.OpenForms["PersonellerListesi"] == null)
            {
                PersonellerListesi frm = new PersonellerListesi();
                frm.MdiParent = Form.ActiveForm;
                frm.Show();
            }
            #endregion
            #region Urun Kayit
            else if (isim == "Urun Kayit" && Application.OpenForms["UrunKayit"] == null)
            {
                UrunKayit frm = new UrunKayit();
                frm.MdiParent = Form.ActiveForm;
                frm.Show();
            }

            else if (isim == "Urun Kayit Listesi" && Application.OpenForms["UrunKayitListesi"] == null)
            {
                f.UrunKayitListesiAc();
            }

            #endregion
            #region Urunler Giris
            else if (isim == "Urun Giris" && Application.OpenForms["UrunGiris"] == null)
            {
                UrunGiris.Urunler.UrunGiris frm = new UrunGiris.Urunler.UrunGiris();
                frm.MdiParent = Form.ActiveForm;
                frm.Show();
            }

            else if (isim == "Urunler Listesi" && Application.OpenForms["UrunlerListesi"] == null)
            {
                f.UrunGirisListesiAc();
            }
            #endregion
            #region Stok
            else if (isim == "Stok Durum" && Application.OpenForms["StokDurum"] == null)
            {
                f.StokDurumAc();
            } 
            #endregion

        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            
            //Close();
            //Application.Exit();
            Cikis();
        }

        private void Cikis()
        {
            DialogResult dialogResult = MessageBox.Show("Programdan cikis yapmak istediginize emin misiniz ?", "Cikis Islemi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                Application.ExitThread();
            }
         
           
        }

        private void btnSolUstCollapse_Click(object sender, EventArgs e)
        {
            
            //if (closeTab)
            //{
            //    scMenu.Width = 30;
            //    closeTab = true;
            //}
            //else
            //{
            //    scMenu.Width = 337;
            //    closeTab = false;
            //}
        }

        private void AnaSayfa_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Programdan cikis yapmak istediginize emin misiniz ?", "Cikis Islemi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
