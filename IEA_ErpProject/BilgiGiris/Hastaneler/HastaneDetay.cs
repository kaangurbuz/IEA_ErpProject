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

namespace IEA_ErpProject.BilgiGiris.Hastaneler
{
    public partial class HastaneDetay : Form
    {
        private readonly ErpProject102SEntities _db = new ErpProject102SEntities();
        private List<tblHastaneDetaylar> detayList = new List<tblHastaneDetaylar>();
        tblHastaneDetaylar dty = new tblHastaneDetaylar();

        public HastaneDetay()
        {
            InitializeComponent();
        }

        private void HastaneDetay_Load(object sender, EventArgs e)
        {
            ComboDoldur();
            this.ActiveControl = txtYetkili;
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
                        Liste.Rows[i].Cells[1].Value = lblHastaneId.Text;
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

                MessageBox.Show(e.Message + " Hata Kodu HDetay101");
            }
        }

        private void ComboDoldur()
        {
            txtDepartman.DataSource = _db.tblDepartmanlar.Where(x=>x.DepartmanKodu=="H").ToList(); //BURAYA BAKILACAK
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
                    new tblHastaneDetaylar()
                    {
                        GirisId = int.Parse(Liste.Rows[i].Cells[1].Value.ToString()),
                        YetkiliAdi = Liste.Rows[i].Cells[2].Value.ToString(),
                        DepartmanId = int.Parse(Liste.Rows[i].Cells[3].Value.ToString()),
                        Tel = Liste.Rows[i].Cells[4].Value.ToString(),
                        Gsm = Liste.Rows[i].Cells[5].Value.ToString(),
                        Email = Liste.Rows[i].Cells[6].Value.ToString()
                    });
            }

            _db.tblHastaneDetaylar.AddRange(detayList);
            _db.SaveChanges();
            MessageBox.Show("Kayit Gerceklesti !!");
            Close();


            //_db.tblDetaylar.Add(dty);
            //_db.SaveChanges();
        }

        private void BtnKayit_Click(object sender, EventArgs e)
        {
            YeniKayit();
        }
    }
}
