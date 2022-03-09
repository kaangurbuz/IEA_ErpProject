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
using IEA_ErpProject.KonsinyeIslemleri.Cikis;
using IEA_ErpProject.KonsinyeIslemleri.Giris;
using IEA_ErpProject.UrunGiris.Stok;
using IEA_ErpProject.UrunGiris.Urunler;

namespace IEA_ErpProject
{
    public partial class AnaSayfa : Form
    {
        readonly Formlar f = new Formlar();
        public static int Aktarma = -1;
        private bool collapseTab = true;
        private bool listTab = false;
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
                    break;
                case 4:
                    TvMenu.Nodes.Add("Gonderim"); //root
                    TvMenu.Nodes[0].Nodes.Add("Konsinye Gonderim");
                    TvMenu.Nodes[0].Nodes.Add("Konsinye Gonderim Listesi");
                    TvMenu.Nodes.Add("Cikis"); //root
                    TvMenu.Nodes[1].Nodes.Add("Konsinye Cikis");
                    TvMenu.Nodes[1].Nodes.Add("Konsinye Cikis Listesi");
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

        private void BtnKonsinye_Click(object sender, EventArgs e)
        {
            lblSolUstMenu.Text = BtnKonsinye.Text;
            MenuOlustur(4);
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
            #region Konsinye Gonderim
            else if (isim == "Konsinye Gonderim" && Application.OpenForms["KonsinyeGonderim"] == null)
            {
                KonsinyeGonderim frm = new KonsinyeGonderim();
                frm.MdiParent = Form.ActiveForm;
                frm.Show();
            }

            else if (isim == "Konsinye Gonderim Listesi" && Application.OpenForms["KonsinyeGonderimListesi"] == null)
            {
                f.KonsinyeGonderimListesiAc();
            }
            #endregion
            #region Konsinye Cikis
            else if (isim == "Konsinye Cikis" && Application.OpenForms["KonsinyeCikis"] == null)
            {
                KonsinyeCikis frm = new KonsinyeCikis();
                frm.MdiParent = Form.ActiveForm;
                frm.Show();
            }

            else if (isim == "Konsinye Cikis Listesi" && Application.OpenForms["KonsinyeCikisListesi"] == null)
            {
                f.KonsinyeCikisListesiAc();
            }
            #endregion

        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            
            //Close();
            //Application.Exit();
            Cikis();
        }

        private bool Cikis()
        {
            DialogResult dialogResult = MessageBox.Show("Programdan cikis yapmak istediginize emin misiniz ?", "Cikis Islemi",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                Application.ExitThread();
                return true;
            }
            else
            {
                return false;
            }
         
           
        }

        private void btnSolUstCollapse_Click(object sender, EventArgs e)
        {

            if (collapseTab)
            {
                pnlSol.Width = 85;
                collapseTab = false;
                TvMenu.Visible = false;
                lblSolUstMenu.Visible = false;
                txtSolUstAra.Visible = false;
                btnSolUstAra.Visible = false;
            }
            else
            {
                pnlSol.Width = 337;
                collapseTab = true;
                TvMenu.Visible = true;
                lblSolUstMenu.Visible = true;
                txtSolUstAra.Visible = true;
                btnSolUstAra.Visible = true;
            }
        }

        private void AnaSayfa_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Cikis())
            {
                Cikis();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void BtnButonListele_Click(object sender, EventArgs e)
        {
            if (!listTab)
            {
                flpButtons.Visible = true;
                listTab=true;
            }

            else
            {
                flpButtons.Visible = false;
                listTab = false;
            }

        }

        private void flowLayoutPanel1_SizeChanged(object sender, EventArgs e)
        {
           
            foreach (Control k in flowLayoutPanel1.Controls)
            {
                if (k is Button)
                {
                    if (k.Location.X > 200)
                    {
                        flpButtons.Controls.Add(k);
                    }
                }

            }

            foreach (Control k in flpButtons.Controls)
            {
                if (k is Button)
                {
                    flowLayoutPanel1.Controls.Add(k);

                    if (k.Location.X > 200)
                    {
                        flpButtons.Controls.Add(k);
                    }

                }

            }

            if (flpButtons.Controls.Count == 0)
            {
                BtnButonListele.Visible = false;
                flpButtons.Visible = false;
                listTab=false;
            }
            else
            {
                BtnButonListele.Visible = true;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("BUTON 1 E BASILDI!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("BUTON 2 E BASILDI!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("BUTON 3 E BASILDI!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("BUTON 4 E BASILDI!");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("BUTON 5 E BASILDI!");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("BUTON 6 A BASILDI!");
        }

        
    }
}

//image list