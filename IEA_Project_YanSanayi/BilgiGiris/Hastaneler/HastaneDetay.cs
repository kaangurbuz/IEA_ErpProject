using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IEA_Project_YanSanayi.Entity;

namespace IEA_Project_YanSanayi.BilgiGiris.Hastaneler
{
    public partial class HastaneDetay : Form
    {
        private readonly ErpProject102SEntities _db = new ErpProject102SEntities();
        public HastaneDetay()
        {
            InitializeComponent();
        }

        private void HastaneDetay_Load(object sender, EventArgs e)
        {
            Listele();
            ComboDoldur();
        }

        private void Listele()
        {
            Liste.AllowUserToAddRows = false;
            int i = -1;
            if (Liste.Rows.Count >= 0)
            {
                i = Liste.Rows.Count;
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = i + 1;
                Liste.Rows[i].Cells[1].Value = lblHastaneId.Text;
                Liste.Rows[i].Cells[2].Value = 'H';
                Liste.Rows[i].Cells[3].Value = txtYetkili.Text;
                Liste.Rows[i].Cells[4].Value = txtDepartman.SelectedValue;
                Liste.Rows[i].Cells[5].Value = txtTel.Text;
                Liste.Rows[i].Cells[6].Value = txtGsm.Text;
                Liste.Rows[i].Cells[7].Value = txtEmail.Text;
            }
        }

        private void ComboDoldur()
        {
            txtDepartman.DataSource = _db.tblDepartmanlar.Where(x => x.DepartmanKodu == "H").ToList();
            txtDepartman.ValueMember = "Id";
            txtDepartman.DisplayMember = "Adi";
            txtDepartman.SelectedIndex = -1;
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            Listele();
            Temizle();
        }

        private void Temizle()
        {
            foreach (Control k in pnlDetayEkle.Controls)
            {
                if (k is TextBox || k is ComboBox || k is MaskedTextBox || k is RichTextBox)
                    k.Text = "";

                txtDepartman.SelectedIndex = -1;
            }
        }
    }
}
