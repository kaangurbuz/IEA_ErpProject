using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IEA_ErpProject.Entity;
using IEA_ErpProject.Functions;
using IEA_ErpProject.Properties;

namespace IEA_ErpProject.BilgiGiris.Hastaneler
{
    public partial class HastaneGiris : Form
    {
        //global area
        private readonly ErpProject102SEntities _db=new ErpProject102SEntities();
        private int secimId = -1;
        private tblHastaneler kayitBul;

        private readonly Formlar f = new Formlar();

        public HastaneGiris()
        {
            InitializeComponent();
        }

        private void HastaneGiris_Load(object sender, EventArgs e)
        {
            ComboDoldur();
            SehirDoldur();
            Listele();
        }

        private void SehirDoldur()
        {
            txtSehir.DataSource = _db.Sehirler.ToList();
            txtSehir.ValueMember = "Id";
            txtSehir.DisplayMember = "name";
            txtSehir.SelectedIndex = -1;
        }

        private void ComboDoldur()
        {
            txtTipAdi.DataSource = _db.tblHastaneTipleri.ToList();
            //select * from tblHastaneTipleri
            txtTipAdi.ValueMember = "Id";
            txtTipAdi.DisplayMember = "TipAdi";
            txtTipAdi.SelectedIndex = -1;
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            YeniKayit();
        }

        private void YeniKayit()
        {
            if (txtHAdi.Text == "")
            {
                MessageBox.Show("Ilgili Alanlar doldurulmadan kayit yapilamaz.");
                return;
            }

            try
            {

                tblHastaneler hst = new tblHastaneler();
                hst.Adi = txtHAdi.Text;
                hst.Adres = txtAdres.Text;
                hst.CariAdi = txtCariHAdi.Text;
                if (txtSehir.SelectedValue != null) hst.SehirId = (int) txtSehir.SelectedValue;
                hst.Telefon = txtTelefon.Text;
                hst.VergiDairesi = txtVergiDairesi.Text;
                hst.VergiNo = txtVergiNo.Text;
                if (txtTipAdi.SelectedValue != null) hst.TipId = (int) txtTipAdi.SelectedValue;

                _db.tblHastaneler.Add(hst);
                _db.SaveChanges();
                MessageBox.Show("Kayit islemi gerceklestirildi");
                Listele();
                Temizle();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + "HataKodu : HGK100");
            }

           
        }

        private void Temizle()
        {
            // txtVergiNo.Text = "";
            // txtVergiNo.Clear();

            foreach (Control k in ScHastane.Panel1.Controls)
            {
                if (k is TextBox || k is ComboBox||k is MaskedTextBox||k is RichTextBox)
                    k.Text = "";

                
            }
            txtTipAdi.SelectedIndex = -1;
            txtSehir.SelectedIndex = -1;
            secimId = -1;
            kayitBul = null;
            BtnDetayEkle.Visible = false;
            BtnDetayGoster.Visible = false;
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private List<tblHastaneler> hstList;

        private void Listele()
        {
            Liste.Rows.Clear();
            int i = 0;

            hstList = (from s in _db.tblHastaneler select s).ToList(); //LINQ sorgusu

            foreach (var item in hstList)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = i+1;
                Liste.Rows[i].Cells[1].Value = item.Id;
                Liste.Rows[i].Cells[2].Value = item.Adi;
                if (item.tblHastaneTipleri != null) Liste.Rows[i].Cells[3].Value = item.tblHastaneTipleri.TipAdi;
                Liste.Rows[i].Cells[4].Value = item.Telefon;
                Liste.Rows[i].Cells[5].Value = item.Sehirler.name;
                i++;
            }

            Liste.AllowUserToAddRows = false; // kullanicinin satir eklemesini engeller
            Liste.AllowUserToDeleteRows = false; // kullanici kayit silemesin
            Liste.SelectionMode=DataGridViewSelectionMode.FullRowSelect;
            Liste.ReadOnly = true;

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            //Listele();
            Guncelle();
        }

        private void Guncelle()
        {

            if (secimId < 0)
            {
                MessageBox.Show("Degistirilecek kayit bulunamadi, once bir kayit secin!");
                return;
            }
             try
            {
                if (kayitBul != null)
                {
                    kayitBul.VergiNo = txtVergiNo.Text;
                    kayitBul.TipId = (int?)txtTipAdi.SelectedValue;
                    kayitBul.SehirId = (int?)txtSehir.SelectedValue;
                    kayitBul.Adres = txtAdres.Text;
                    kayitBul.CariAdi = txtCariHAdi.Text;
                    kayitBul.Adi = txtHAdi.Text;
                    kayitBul.Telefon = txtTelefon.Text;
                    kayitBul.VergiDairesi = txtVergiDairesi.Text;
                }

                _db.SaveChanges();
                MessageBox.Show("Guncelleme Yapildi!");
                Temizle();
                Listele();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message + " Hata Kodu : HGGuncelleme101");
            }


        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
           
            if (Liste.CurrentRow != null)
            {
                secimId = (int) Liste.CurrentRow.Cells[1].Value;
            }

            Ac(secimId);
        }

        public void Ac(int secimId)
        {
            if (secimId<0)
            {
                MessageBox.Show("Kayit id bulunamamistir!");
                return;
            }

            BtnDetayEkle.Visible = true;
            BtnDetayGoster.Visible = true;

            //tblHastaneler kayitBul1 = _db.tblHastaneler.Find(secimId);
            kayitBul = hstList.FirstOrDefault(x=>x.Id==secimId);

            try
            {
                if (kayitBul != null)
                {
                    txtVergiNo.Text = kayitBul.VergiNo;
                    txtTipAdi.Text = kayitBul.tblHastaneTipleri.TipAdi;
                    txtSehir.Text = kayitBul.Sehirler.name;
                    txtAdres.Text = kayitBul.Adres;
                    txtCariHAdi.Text = kayitBul.CariAdi;
                    txtHAdi.Text = kayitBul.Adi;
                    txtTelefon.Text = kayitBul.Telefon;
                    txtVergiDairesi.Text = kayitBul.VergiDairesi;
                    txtHastaneBul.Text = kayitBul.Id.ToString().PadLeft(5,'0');
                }
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message + " Hata Kodu : HGListeleme101");
            }

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {

            if (secimId < 0)
            {
                MessageBox.Show("Lutfen silinecek kaydi sectiginizden emin olunuz!.", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Kayidi silmek istediginize emin misiniz ?", "Kayit Silme Islemi", 
                MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            
            if (dialogResult == DialogResult.Yes)
            {
                Sil();
            }
           
            
        }

        private void Sil()
        {
            if (secimId > 0)
            {
                _db.tblHastaneler.Remove(kayitBul);
                _db.SaveChanges();
                MessageBox.Show("Kaydiniz silinmistir! Gecmis Olsun.");
                Temizle();
                Listele();
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            var btn = new Button();
            btn.Size = new Size(20, txtHastaneBul.ClientSize.Height);
            btn.Location = new Point(txtHastaneBul.ClientSize.Width - btn.Width - 1);
            btn.Cursor= Cursors.Default;
            btn.BackgroundImage = Resources.dots;
            btn.BackgroundImageLayout = ImageLayout.Stretch;
            btn.Anchor = (AnchorStyles.Top |AnchorStyles.Right);
            txtHastaneBul.Controls.Add(btn);
            base.OnLoad(e);
            btn.Click += Btn_Click;
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            int id = f.HastanelerListesiAc(true);

            if (id > 0)
            {
                Ac(id);
            }

            AnaSayfa.Aktarma = -1;
        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnDetayEkle_Click(object sender, EventArgs e)
        {
            string adi; //= ""
            int id; //=-1
            if (secimId > 0)
            {
                adi = txtHAdi.Text;
                id = int.Parse(txtHastaneBul.Text);
                f.HastaneDetayAc(adi,id);
            }
            else
            {
                MessageBox.Show("Once bir kayit secin!");
                return;
            }
        }

        private void BtnDetayGoster_Click(object sender, EventArgs e)
        {
            HastaneDetayGoster goster = new HastaneDetayGoster();
            goster.HAdi = txtHAdi.Text;
            goster.ShowDialog();
        }

        private void BtnSehirTmz_Click(object sender, EventArgs e)
        {
            txtSehir.SelectedIndex = -1;
        }

        private void BtnHastaneTipiTemizle_Click(object sender, EventArgs e)
        {
            txtTipAdi.SelectedIndex = -1;
        }

    }
}
