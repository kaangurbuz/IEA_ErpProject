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

namespace IEA_ErpProject.BilgiGiris.Urunler
{
    public partial class UrunKayit : Form
    {
        private readonly ErpProject102SEntities _db = new ErpProject102SEntities();
        private Numaralar n = new Numaralar();
        private Resimler r = new Resimler();

        private bool _resim = false;
        OpenFileDialog _dosya =new OpenFileDialog();

        public UrunKayit()
        {
            InitializeComponent();
        }

        private void UrunKayit_Load(object sender, EventArgs e)
        {

        }

        private void BtnUrunResmiEkle_Click(object sender, EventArgs e)
        {
            ResimSec();
        }

        private void ResimSec()
        {
            _dosya.Filter = "Jpg(*.jpg)|*.jpg|Jpeg(*.jpeg)|*.jpeg";
            if (_dosya.ShowDialog()==DialogResult.OK)
            {
                pbUrunResmi.ImageLocation = _dosya.FileName;
                _resim = true;
            }
        }
    }
}
