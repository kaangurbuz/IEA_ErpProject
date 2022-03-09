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
    public partial class HastaneDetayGoster : Form
    {
        private readonly ErpProject102SEntities _db = new ErpProject102SEntities();
        public string HAdi="";
        private int secimId = -1;
        private tblHastaneDetaylar kayitBul;
        public HastaneDetayGoster()
        {
            InitializeComponent();
        }

        private void HastaneDetayGoster_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            Liste.Rows.Clear();
            int i = 0;
            var hstDetayList =
                (from s in _db.tblHastaneDetaylar where s.tblHastaneler.Adi == HAdi select s).ToList();

            foreach (var item in hstDetayList)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = i + 1;
                Liste.Rows[i].Cells[1].Value = item.YetkiliAdi;
                Liste.Rows[i].Cells[2].Value = item.tblDepartmanlar.Adi;
                Liste.Rows[i].Cells[3].Value = item.Tel;
                Liste.Rows[i].Cells[4].Value = item.Gsm;
                Liste.Rows[i].Cells[5].Value = item.Email;
                Liste.Rows[i].Cells[6].Value = item.Id;
                i++;

            }
            Liste.AllowUserToAddRows = false; // kullanicinin satir eklemesini engeller
            Liste.AllowUserToDeleteRows = false; // kullanici kayit silemesin
            Liste.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Liste.ReadOnly = true;
        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            Sil();
        }

        private void Sil()
        {
            if (secimId > 0)
            {
                _db.tblHastaneDetaylar.Remove(kayitBul);
                _db.SaveChanges();
                MessageBox.Show("Kaydiniz silinmistir! Gecmis Olsun.");
                Listele();
            }
        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            if (Liste.CurrentRow != null)
            {
                secimId = (int)Liste.CurrentRow.Cells[6].Value;
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
            kayitBul = _db.tblHastaneDetaylar.FirstOrDefault(x => x.Id == secimId);

            lblSecilenKayit.Text = kayitBul.Id.ToString().PadLeft(6, '0');
        }
    }
}
