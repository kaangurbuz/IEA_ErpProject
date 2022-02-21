using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IEA_ErpProject.Entity;
using IEA_ErpProject.Functions;
using IEA_ErpProject.Properties;

namespace IEA_ErpProject.BilgiGiris.Doktorlar
{
    public partial class DoktorGiris : Form
    {
        private readonly ErpProject102SEntities _db = new ErpProject102SEntities();
        private List<tblDoktorlar> dktList;
        private Formlar f = new Formlar();
        private tblDoktorlar kayitBul;
        private int secimId = -1;
        public DoktorGiris()
        {
            InitializeComponent();
        }

        private void DoktorGiris_Load(object sender, EventArgs e)
        {
            Listele();
            ComboDoldur();
            SehirDoldur();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            YeniKayit();
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
                    kayitBul.Tel = txtTelefon.Text;
                    if (txtSehir.SelectedValue !=null) kayitBul.SehirId = Convert.ToInt32(txtSehir.SelectedValue);
                    kayitBul.Muayenehane = txtMuayenehane.Text;
                    kayitBul.Unvan = txtUnvan.Text;
                    kayitBul.Adi = txtDAdi.Text;
                    kayitBul.Tel2 = txtTelefon2.Text;
                    kayitBul.VergiDairesi = txtVergiDairesi.Text;
                    if (txtHastane1.SelectedValue != null)
                        kayitBul.Hastane1Id = Convert.ToInt32(txtHastane1.SelectedValue);
                    if (txtHastane2.SelectedValue != null)
                        kayitBul.Hastane2Id = Convert.ToInt32(txtHastane2.SelectedValue);
                    if (txtHastane3.SelectedValue != null)
                        kayitBul.Hastane3Id = Convert.ToInt32(txtHastane3.SelectedValue);
                    kayitBul.Email = txtEmail.Text;
                    kayitBul.DTarih = txtDTarih.Value;
                    kayitBul.Gsm = txtGsm.Text;

                }

                _db.SaveChanges();
                MessageBox.Show("Guncelleme Yapildi!");
                Temizle();
                Listele();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message + " Hata Kodu : DGGuncelleme101");
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
                _db.tblDoktorlar.Remove(kayitBul);
                _db.SaveChanges();
                MessageBox.Show("Kaydiniz silinmistir! Gecmis Olsun.");
                Temizle();
                Listele();
            }
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void Temizle()
        {
            foreach (Control k in ScDoktor.Panel1.Controls)
            {
                if (k is TextBox || k is ComboBox || k is MaskedTextBox || k is RichTextBox)
                    k.Text = "";
            }

            txtHastane1.SelectedIndex = -1;
            txtHastane2.SelectedIndex = -1;
            txtHastane3.SelectedIndex = -1;
            txtSehir.SelectedIndex = -1;
            txtUnvan.SelectedIndex = -1;
            txtDTarih.Value = DateTime.Now;
        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            Close();
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
            //hastane1txt
            txtHastane1.DataSource= _db.tblHastaneler.ToList();
            txtHastane1.ValueMember = "Id";
            txtHastane1.DisplayMember = "Adi";
            txtHastane1.SelectedIndex = -1;
            //hastane2txt
            txtHastane2.DataSource= _db.tblHastaneler.ToList();
            txtHastane2.ValueMember = "Id";
            txtHastane2.DisplayMember = "Adi";
            txtHastane2.SelectedIndex = -1;
            //hastane3txt
            txtHastane3.DataSource = _db.tblHastaneler.ToList();
            txtHastane3.ValueMember = "Id";
            txtHastane3.DisplayMember = "Adi";
            txtHastane3.SelectedIndex = -1;
            //unvan
            txtUnvan.DataSource = Enum.GetValues(typeof(Unvan)).Cast<Enum>()
                .Select(value => new
                {
                    (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()), typeof(DescriptionAttribute)) as DescriptionAttribute).Description,
                    value
                })
                .OrderBy(item => item.value)
                .ToList();

            txtUnvan.DisplayMember = "Description";
            txtUnvan.ValueMember = "Value";
            
            txtUnvan.SelectedIndex = -1;
        }

        private void YeniKayit()
        {
            tblDoktorlar dkt = new tblDoktorlar
            {
                Adi = txtDAdi.Text,
                DTarih = txtDTarih.Value,
                Email = txtEmail.Text,
                Gsm = txtGsm.Text,
                Muayenehane = txtMuayenehane.Text,
                Tel = txtTelefon.Text,
                Tel2 = txtTelefon2.Text,
                Unvan = txtUnvan.Text,
                VergiDairesi = txtVergiDairesi.Text,
                VergiNo = txtVergiNo.Text

            };

            if (txtHastane1.SelectedValue != null) dkt.Hastane1Id = Convert.ToInt32(txtHastane1.SelectedValue); //null kontrolü
            if (txtHastane2.SelectedValue != null) dkt.Hastane2Id = Convert.ToInt32(txtHastane2.SelectedValue); //null kontrolü
            if (txtHastane3.SelectedValue != null) dkt.Hastane3Id = Convert.ToInt32(txtHastane3.SelectedValue); //null kontrolü
            if (txtSehir.SelectedValue != null) dkt.SehirId = Convert.ToInt32(txtSehir.SelectedValue); //null kontrolü//BAKILACAK

            _db.tblDoktorlar.Add(dkt);
            _db.SaveChanges();
            MessageBox.Show("Kayit Basariyla Yapildi!");
            Temizle();
            Listele();
        }

        private void Listele()
        {
            Liste.Rows.Clear();
            int i = 0;

            dktList = (from s in _db.tblDoktorlar select s).ToList();

            foreach (var item in dktList)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = i + 1;
                Liste.Rows[i].Cells[1].Value = item.Id;
                Liste.Rows[i].Cells[2].Value = item.Unvan;
                Liste.Rows[i].Cells[3].Value = item.Adi;
                Liste.Rows[i].Cells[4].Value = item.Tel;
                Liste.Rows[i].Cells[5].Value = item.Tel2;
                Liste.Rows[i].Cells[6].Value = item.Gsm;
                Liste.Rows[i].Cells[7].Value = item.Email;
                if(item.Sehirler!=null) Liste.Rows[i].Cells[8].Value = item.Sehirler.name;
                i++;
            }

            Liste.AllowUserToAddRows = false; // kullanicinin satir eklemesini engeller
            Liste.AllowUserToDeleteRows = false; // kullanici kayit silemesin
            Liste.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Liste.ReadOnly = true;
        }

        protected override void OnLoad(EventArgs e)
        {
            var btn = new Button();
            btn.Size = new Size(20, txtDoktorBul.ClientSize.Height);
            btn.Location = new Point(txtDoktorBul.ClientSize.Width - btn.Width - 1);
            btn.Cursor = Cursors.Default;
            btn.BackgroundImage = Resources.dots;
            btn.BackgroundImageLayout = ImageLayout.Stretch;
            btn.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            txtDoktorBul.Controls.Add(btn);
            base.OnLoad(e);
            btn.Click += Btn_Click;
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            int id = f.DoktorlarListesiAc(true);

            if (id > 0)
            {
                Ac(id);
            }

            AnaSayfa.Aktarma = -1;
        }

        public void Ac(int secimId)
        {
            Temizle();
            if (secimId < 0)
            {
                MessageBox.Show("Kayit id bulunamamistir!");
                return;
            }

            kayitBul = dktList.FirstOrDefault(x => x.Id == secimId);

            try
            {
                if (kayitBul != null)
                {
                    txtVergiNo.Text = kayitBul.VergiNo;
                    txtTelefon.Text = kayitBul.Tel;
                    if (kayitBul.Sehirler != null) txtSehir.Text = kayitBul.Sehirler.name;
                    txtMuayenehane.Text = kayitBul.Muayenehane;
                    txtUnvan.Text = kayitBul.Unvan;
                    txtDAdi.Text = kayitBul.Adi;
                    txtTelefon2.Text = kayitBul.Tel2;
                    txtVergiDairesi.Text = kayitBul.VergiDairesi;
                    txtDoktorBul.Text = kayitBul.Id.ToString().PadLeft(5, '0');
                    if (kayitBul.tblHastaneler!= null) txtHastane1.Text = kayitBul.tblHastaneler.Adi;
                    if (kayitBul.tblHastaneler1 != null) txtHastane2.Text = kayitBul.tblHastaneler1.Adi;
                    if (kayitBul.tblHastaneler2 != null) txtHastane3.Text = kayitBul.tblHastaneler2.Adi;
                    txtEmail.Text = kayitBul.Email;
                    txtDTarih.Text = kayitBul.DTarih.ToString();
                    txtGsm.Text = kayitBul.Gsm;

                }
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message + " Hata Kodu : DGListeleme101");
            }

        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            if (Liste.CurrentRow != null)
            {
                secimId = (int)Liste.CurrentRow.Cells[1].Value;
            }

            Ac(secimId);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtUnvan.SelectedIndex = -1;
        }

        private void BtnHastane1Temizle_Click(object sender, EventArgs e)
        {
            txtHastane1.SelectedIndex = -1;
        }

        private void BtnHastane2Temizle_Click(object sender, EventArgs e)
        {
            txtHastane2.SelectedIndex = -1;
        }

        private void BtnHastane3Temizle_Click(object sender, EventArgs e)
        {
            txtHastane3.SelectedIndex = -1;
        }

        private void BtnSehirTemizle_Click(object sender, EventArgs e)
        {
            txtSehir.SelectedIndex = -1;
        }
    }
}
