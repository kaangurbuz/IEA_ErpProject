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

namespace IEA_ErpProject.BilgiGiris.Firmalar
{
    public partial class FirmaDetay : Form
    {
        private readonly ErpProject102SEntities _db = new ErpProject102SEntities();
        private List<tblFirmaDetaylar> detayList = new List<tblFirmaDetaylar>();
        tblFirmaDetaylar dty = new tblFirmaDetaylar();
        public FirmaDetay()
        {
            InitializeComponent();
        }

        private void BtnKayit_Click(object sender, EventArgs e)
        {
            YeniKayit();
        }

        private void YeniKayit()
        {
            if (Liste.Rows[0].Cells[0].Value == null)
            {
                MessageBox.Show("Once ekle butonuyla kayit ekleyin");
                ActiveControl = txtYetkili;
                return;
            }

            for (int i = 0; i < Liste.Rows.Count; i++)
            {
                //dty.GirisId = int.Parse(Liste.Rows[i].Cells[1].Value.ToString());
                //dty.GirisAdi = Liste.Rows[i].Cells[2].Value.ToString();
                //dty.YetkiliAdi = Liste.Rows[i].Cells[3].Value.ToString();
                //dty.DepartmanId = int.Parse(Liste.Rows[i].Cells[4].Value.ToString());
                //dty.Tel = Liste.Rows[i].Cells[5].Value.ToString();
                //dty.Gsm = Liste.Rows[i].Cells[6].Value.ToString();
                //dty.Email = Liste.Rows[i].Cells[7].Value.ToString();
                //detayList.Add(dty);
                detayList.Add(
                    new tblFirmaDetaylar()
                    {
                        GirisId = int.Parse(Liste.Rows[i].Cells[1].Value.ToString()),
                        YetkiliAdi = Liste.Rows[i].Cells[2].Value.ToString(),
                        DepartmanId = int.Parse(Liste.Rows[i].Cells[3].Value.ToString()),
                        Tel = Liste.Rows[i].Cells[4].Value.ToString(),
                        Gsm = Liste.Rows[i].Cells[5].Value.ToString(),
                        Email = Liste.Rows[i].Cells[6].Value.ToString()
                    });
            }

            _db.tblFirmaDetaylar.AddRange(detayList);
            _db.SaveChanges();
            MessageBox.Show("Kayit Gerceklesti !!");
            Close();
        }

        private void FirmaDetay_Load(object sender, EventArgs e)
        {
            ComboDoldur();
            this.ActiveControl = txtYetkili;
        }

        private void ComboDoldur()
        {
            txtDepartman.DataSource = _db.tblDepartmanlar.Where(x => x.DepartmanKodu == "F").ToList();
            txtDepartman.ValueMember = "Id";
            txtDepartman.DisplayMember = "Adi";
            txtDepartman.SelectedIndex = -1;
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            Listele();
            Temizle();
            ActiveControl = txtYetkili;
        }

        private void Temizle()
        {
            foreach (Control k in pnlDetayEkle.Controls)
            {
                if (k is TextBox || k is ComboBox || k is MaskedTextBox || k is RichTextBox)
                    k.Text = "";

                txtDepartman.SelectedIndex = -1;
            }

            txtYetkili.Focus();
        }

        private void Listele()
        {
            try
            {
                if (txtYetkili.Text != "" && txtDepartman.SelectedIndex != -1)
                {
                    Liste.AllowUserToAddRows = false;
                    int i = -1;
                    if (Liste.Rows.Count >= 0)
                    {
                        i = Liste.Rows.Count;
                        Liste.Rows.Add();
                        Liste.Rows[i].Cells[0].Value = i + 1;
                        Liste.Rows[i].Cells[1].Value = lblFirmaId.Text;
                        Liste.Rows[i].Cells[2].Value = txtYetkili.Text;
                        Liste.Rows[i].Cells[3].Value = txtDepartman.SelectedValue;
                        Liste.Rows[i].Cells[4].Value = txtTel.Text;
                        Liste.Rows[i].Cells[5].Value = txtGsm.Text;
                        Liste.Rows[i].Cells[6].Value = txtEmail.Text;
                    }

                }
                else
                {
                    MessageBox.Show("Lutfen kayit yapilacak kutulari doldurun!!");
                    ActiveControl = txtYetkili;
                }

            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message + " Hata Kodu FDetay101");
            }
        }
    }
}
