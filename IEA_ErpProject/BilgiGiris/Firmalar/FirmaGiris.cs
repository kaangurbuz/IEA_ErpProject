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

namespace IEA_ErpProject.BilgiGiris.Firmalar
{
    public partial class FirmaGiris : Form
    {
        private readonly ErpProject102SEntities _db = new ErpProject102SEntities();
        private int secimId = -1;
        private tblFirmalar kayitBul;
        private readonly Formlar f = new Formlar();
        private List<tblFirmalar> frmList;
        public FirmaGiris()
        {
            InitializeComponent();
        }

        private void FirmaGiris_Load(object sender, EventArgs e)
        {
            ComboDoldur();
            Listele();
        }

        private void Listele()
        {
            Liste.Rows.Clear();
            int i = 0;
            frmList = (from s in _db.tblFirmalar select s).ToList();
            var lst1 = (from s in _db.tblFirmalar select new
            {
                id=s.Id,
                fadi=s.Adi,
                ftip=s.FirmaTip,
                tel=s.Tel,
                sehir=s.Sehirler.name//sehir null kontrolunu denetle
            }).ToList();

            foreach (var k in lst1)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = i + 1;
                Liste.Rows[i].Cells[1].Value = k.id;
                Liste.Rows[i].Cells[2].Value = k.fadi;
                Liste.Rows[i].Cells[3].Value = k.ftip;
                Liste.Rows[i].Cells[4].Value = k.tel;
                Liste.Rows[i].Cells[5].Value = k.sehir;
                i++;
            }

            Liste.AllowUserToAddRows = false;
            Liste.AllowUserToDeleteRows = false;
            Liste.ReadOnly = true;
            Liste.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void ComboDoldur()
        {
            txtTipAdi.DataSource = Enum.GetValues(typeof(FirmaTip));
            txtTipAdi.SelectedIndex = -1;

            txtSehir.DataSource = _db.Sehirler.ToList();
            txtSehir.ValueMember = "Id";
            txtSehir.DisplayMember = "name";
            txtSehir.SelectedIndex = -1;
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            YeniKayit();
        }

        private void YeniKayit()
        {
            if (txtFAdi.Text=="")
            {
                MessageBox.Show("Firma adi bos gecilemez!!");
                return;
            }

            try
            {
                tblFirmalar frm = new tblFirmalar
                {
                    Adi = txtFAdi.Text,
                    Tel = txtTelefon.Text,
                    Adress = txtAdres.Text,
                    Email = txtEmail.Text,
                    FirmaTip = txtTipAdi.Text,
                    VergiDairesi = txtVergiDairesi.Text,
                    VergiNo = txtVergiNo.Text,
                    Web = txtWeb.Text
                };
                if (txtSehir.SelectedValue != null) frm.SehirId = Convert.ToInt32(txtSehir.SelectedValue);
                _db.tblFirmalar.Add(frm);
                _db.SaveChanges();
                MessageBox.Show("Kayit islemi basarili");
                Listele();
                Temizle();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void Temizle()
        {
            // txtVergiNo.Text = "";
            // txtVergiNo.Clear();

            foreach (Control k in ScFirma.Panel1.Controls)
            {
                if (k is TextBox || k is ComboBox || k is MaskedTextBox || k is RichTextBox)
                    k.Text = "";


            }
            txtTipAdi.SelectedIndex = -1;
            txtSehir.SelectedIndex = -1;
            secimId = -1;
            kayitBul = null;
            BtnDetayEkle.Visible = false;
            BtnDetayGoster.Visible = false;
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
            kayitBul = _db.tblFirmalar.FirstOrDefault(x => x.Id == secimId);


            try
            {
                txtFirmaBul.Text = kayitBul.Id.ToString().PadLeft(5, '0');
                txtVergiNo.Text = kayitBul.VergiNo;
                if (kayitBul.Sehirler != null) txtSehir.Text = kayitBul.Sehirler.name;
                txtTipAdi.Text = kayitBul.FirmaTip;
                txtVergiDairesi.Text = kayitBul.VergiDairesi;
                txtEmail.Text = kayitBul.Email;
                txtTelefon.Text = kayitBul.Tel;
                txtAdres.Text = kayitBul.Adress;
                txtFAdi.Text = kayitBul.Adi;
                txtWeb.Text = kayitBul.Web;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + " Hata Kodu : FGListeleme101");
                
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            var btn = new Button();
            btn.Size = new Size(20, txtFirmaBul.ClientSize.Height);
            btn.Location = new Point(txtFirmaBul.ClientSize.Width - btn.Width - 1);
            btn.Cursor = Cursors.Default;
            btn.BackgroundImage = Resources.dots;
            btn.BackgroundImageLayout = ImageLayout.Stretch;
            btn.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            txtFirmaBul.Controls.Add(btn);
            base.OnLoad(e);
            btn.Click += Btn_Click;
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            int id = f.FirmalarListesiAc(true);

            if (id > 0)
            {
                Ac(id);
            }

            AnaSayfa.Aktarma = -1;
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
                    kayitBul.VergiNo = txtVergiNo.Text;
                    kayitBul.SehirId = Convert.ToInt32(txtSehir.SelectedValue);
                    kayitBul.FirmaTip = txtTipAdi.Text;
                    kayitBul.VergiDairesi = txtVergiDairesi.Text;
                    kayitBul.Email = txtEmail.Text;
                    kayitBul.Tel = txtTelefon.Text;
                    kayitBul.Adress = txtAdres.Text;
                    kayitBul.Adi = txtFAdi.Text;
                    kayitBul.Web = txtWeb.Text;

                }

                _db.SaveChanges();
                MessageBox.Show("Guncelleme Yapildi!");
                Temizle();
                Listele();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message + " Hata Kodu : FGGuncelleme101");
            }

        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            Sil();
        }

        private void Sil()
        {
            if (secimId > 0)
            {
                _db.tblFirmalar.Remove(kayitBul);
                _db.SaveChanges();
                MessageBox.Show("Kaydiniz silinmistir! Gecmis Olsun.");
                Temizle();
                Listele();
            }
        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSehirTemizle_Click(object sender, EventArgs e)
        {
            txtSehir.SelectedIndex = -1;
        }

        private void BtnFirmaTipTemizle_Click(object sender, EventArgs e)
        {
            txtTipAdi.SelectedIndex = -1;
        }

        private void BtnDetayEkle_Click(object sender, EventArgs e)
        {
            string adi; //= ""
            int id; //=-1
            if (secimId > 0)
            {
                adi = txtFAdi.Text;
                id = int.Parse(txtFirmaBul.Text);
                f.FirmaDetayAc(adi, id);
            }
            else
            {
                MessageBox.Show("Once bir kayit secin!");
                return;
            }
        }

        private void BtnDetayGoster_Click(object sender, EventArgs e)
        {
            FirmaDetayGoster goster = new FirmaDetayGoster();
            goster.FAdi = txtFAdi.Text;
            goster.ShowDialog();
        }
    }
}
