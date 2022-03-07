using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IEA_ErpProject.Entity.Code;

namespace IEA_ErpProject.Giris
{
    public partial class GirisEkrani : Form
    {
        private ErpProContext code = new ErpProContext();
        public GirisEkrani()
        {
            InitializeComponent();
        }

        private void GirisEkrani_Load(object sender, EventArgs e)
        {

        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text != "" && txtSifre.Text != "")
            {
                //var srg = code.TblUsers.Where(s => s.UserName == txtKullaniciAdi.Text && s.Password == txtSifre.Text)
                //    .Select(x => x.Id).ToList();
                int? srg =
                    (from s in code.TblUsers
                        where (s.UserName == txtKullaniciAdi.Text && s.Password == txtSifre.Text)
                        select s.Id).FirstOrDefault();
                if (srg > 0)
                {
                    AnaSayfa ana = new AnaSayfa();
                    ana.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Kullanici adi veya parola yanlış girildi! Lutfen kontrol ediniz!");
                }
            }
        }
    }
}
