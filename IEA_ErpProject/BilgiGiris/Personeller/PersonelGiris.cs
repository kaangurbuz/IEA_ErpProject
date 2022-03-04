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
using IEA_ErpProject.Entity;
using IEA_ErpProject.Functions;
using IEA_ErpProject.Properties;

namespace IEA_ErpProject.BilgiGiris.Personeller
{
    public partial class PersonelGiris : Form
    {
        private readonly ErpProject102SEntities _db = new ErpProject102SEntities();
        private int secimId = -1;
        private tblPersoneller kayitBul;
        private readonly Formlar f = new Formlar();
        private List<tblPersoneller> prsList;
        public PersonelGiris()
        {
            InitializeComponent();
        }

        private void PersonelGiris_Load(object sender, EventArgs e)
        {
            ComboDoldur();
            Listele();
        }

        private void ComboDoldur()
        {
            txtSehir.DataSource = _db.Sehirler.ToList();
            txtSehir.ValueMember = "Id";
            txtSehir.DisplayMember = "name";
            txtSehir.SelectedIndex = -1;

            txtDepartman.DataSource = _db.tblDepartmanlar.ToList();
            txtDepartman.ValueMember = "Id";
            txtDepartman.DisplayMember = "Adi";
            txtDepartman.SelectedIndex = -1;
        }

        private void Listele()
        {
            Liste.Rows.Clear();
            int i = 0;

            prsList = (from s in _db.tblPersoneller select s).ToList(); //LINQ sorgusu

            foreach (var item in prsList)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = i + 1;
                Liste.Rows[i].Cells[1].Value = item.Id;
                Liste.Rows[i].Cells[2].Value = item.Unvan;
                Liste.Rows[i].Cells[3].Value = item.Adi;
                Liste.Rows[i].Cells[4].Value = item.tblDepartmanlar.Adi;
                Liste.Rows[i].Cells[5].Value = item.Tel;
                Liste.Rows[i].Cells[6].Value = item.Sehirler.name;
                i++;
            }

            Liste.AllowUserToAddRows = false; // kullanicinin satir eklemesini engeller
            Liste.AllowUserToDeleteRows = false; // kullanici kayit silemesin
            Liste.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Liste.ReadOnly = true;
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            YeniKayit();
        }

        private void YeniKayit()
        {
            if (txtPAdi.Text == "")
            {
                MessageBox.Show("Ilgili Alanlar doldurulmadan kayit yapilamaz.");
                return;
            }

            try
            {

                tblPersoneller prs = new tblPersoneller();
                prs.Adi = txtPAdi.Text;
                prs.Adress = txtAdres.Text;
                prs.Unvan = txtUnvan.Text;
                if (txtSehir.SelectedValue != null) prs.SehirId = (int)txtSehir.SelectedValue;
                prs.Tel = txtTelefon.Text;
                prs.Email = txtEmail.Text;
                prs.Gsm = txtGsm.Text;
                if (txtDepartman.SelectedValue != null) prs.DepartmanId = (int)txtDepartman.SelectedValue;
                prs.IsBaslangicTarih = txtIsBaslangic.Value;
                prs.IsBitisTarih = txtIsBitis.Value;

                _db.tblPersoneller.Add(prs);
                _db.SaveChanges();
                MessageBox.Show("Kayit islemi gerceklestirildi");
                Listele();
                Temizle();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + "HataKodu : PGK100");
            }
        }

        private void Temizle()
        {
            foreach (Control k in ScPersonel.Panel1.Controls)
            {
                if (k is TextBox || k is ComboBox || k is MaskedTextBox || k is RichTextBox)
                    k.Text = "";


            }
            txtDepartman.SelectedIndex = -1;
            txtSehir.SelectedIndex = -1;
            txtUnvan.SelectedIndex = -1;
            secimId = -1;
            //kayitBul = null;
            BtnDetayEkle.Visible = false;
            BtnDetayGoster.Visible = false;
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            if (Liste.CurrentRow != null)
            {
                secimId = (int)Liste.CurrentRow.Cells[1].Value;
            }

            Ac(secimId);
        }

        public void Ac(int secimId)
        {
            if (secimId < 0)
            {
                MessageBox.Show("Kayit id bulunamamistir!");
                return;
            }

            BtnDetayEkle.Visible = true;
            BtnDetayGoster.Visible = true;

            //tblHastaneler kayitBul1 = _db.tblHastaneler.Find(secimId);
            kayitBul = prsList.FirstOrDefault(x => x.Id == secimId);

            try
            {
                if (kayitBul != null)
                {
                    txtGsm.Text = kayitBul.Gsm;
                    txtTelefon.Text = kayitBul.Tel;
                    txtSehir.Text = kayitBul.Sehirler.name;
                    txtAdres.Text = kayitBul.Adress;
                    txtUnvan.Text = kayitBul.Unvan;
                    txtEmail.Text = kayitBul.Email;
                    txtPAdi.Text = kayitBul.Adi;
                    txtTelefon.Text = kayitBul.Tel;
                    txtDepartman.Text = kayitBul.tblDepartmanlar.Adi;
                    txtIsBaslangic.Text = kayitBul.IsBaslangicTarih.ToString();
                    txtIsBitis.Text = kayitBul.IsBitisTarih.ToString();
                    txtPersonelBul.Text = kayitBul.Id.ToString().PadLeft(5, '0');
                }
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message + " Hata Kodu : HGListeleme101");
            }

        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
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
                    kayitBul.Gsm = txtGsm.Text;
                    kayitBul.Tel = txtTelefon.Text;
                    kayitBul.SehirId = (int?)txtSehir.SelectedValue;
                    kayitBul.Adress = txtAdres.Text;
                    kayitBul.Unvan = txtUnvan.Text;
                    kayitBul.Email = txtEmail.Text;
                    kayitBul.Adi = txtPAdi.Text;
                    kayitBul.Tel = txtTelefon.Text;
                    kayitBul.tblDepartmanlar.Adi = txtDepartman.Text;
                    kayitBul.IsBaslangicTarih = DateTime.Parse(txtIsBaslangic.Text);
                    kayitBul.IsBitisTarih = DateTime.Parse(txtIsBitis.Text);

                }

                _db.SaveChanges();
                MessageBox.Show("Guncelleme Yapildi!");
                Temizle();
                Listele();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message + " Hata Kodu : PGGuncelleme101");
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
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                Sil();
            }
        }

        private void Sil()
        {
            if (secimId > 0)
            {
                _db.tblPersoneller.Remove(kayitBul);
                _db.SaveChanges();
                MessageBox.Show("Kaydiniz silinmistir! Gecmis Olsun.");
                Temizle();
                Listele();
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            var btn = new Button();
            btn.Size = new Size(20, txtPersonelBul.ClientSize.Height);
            btn.Location = new Point(txtPersonelBul.ClientSize.Width - btn.Width - 1);
            btn.Cursor = Cursors.Default;
            btn.BackgroundImage = Resources.dots;
            btn.BackgroundImageLayout = ImageLayout.Stretch;
            btn.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            txtPersonelBul.Controls.Add(btn);
            base.OnLoad(e);
            btn.Click += Btn_Click;
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            int id = f.PersonellerListesiAc(true);

            if (id > 0)
            {
                Ac(id);
            }

            AnaSayfa.Aktarma = -1;
        }
    }
}
