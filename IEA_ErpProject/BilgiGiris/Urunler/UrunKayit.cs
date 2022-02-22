using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IEA_ErpProject.BilgiGiris.Firmalar;
using IEA_ErpProject.Entity;
using IEA_ErpProject.Functions;
using IEA_ErpProject.Properties;

namespace IEA_ErpProject.BilgiGiris.Urunler
{
    public partial class UrunKayit : Form
    {
        private readonly ErpProject102SEntities _db = new ErpProject102SEntities();
        private Numaralar n = new Numaralar();
        private Resimler r = new Resimler();
        private Formlar f = new Formlar();
        private bool _resim = false;
        OpenFileDialog _dosya =new OpenFileDialog();

        public UrunKayit()
        {
            InitializeComponent();
        }

        private void UrunKayit_Load(object sender, EventArgs e)
        {
            txtUrunId.Text = n.UidNo();
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

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        protected override void OnLoad(EventArgs e)
        {
            var btn = new Button();
            btn.Size = new Size(20, txtUrunId.ClientSize.Height);
            btn.Location = new Point(txtUrunId.ClientSize.Width - btn.Width - 1);
            btn.Cursor = Cursors.Default;
            btn.BackgroundImage = Resources.dots;
            btn.BackgroundImageLayout = ImageLayout.Stretch;
            btn.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            txtUrunId.Controls.Add(btn);
            

            var BtnFirma = new Button();
            BtnFirma.Size = new Size(20, txtFirmaKodu.ClientSize.Height);
            BtnFirma.Location = new Point(txtFirmaKodu.ClientSize.Width - BtnFirma.Width - 1);
            BtnFirma.Cursor = Cursors.Default;
            BtnFirma.BackgroundImage = Resources.dots;
            BtnFirma.BackgroundImageLayout = ImageLayout.Stretch;
            BtnFirma.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            txtFirmaKodu.Controls.Add(BtnFirma);

            base.OnLoad(e);
            btn.Click += BtnUrun_Click;
            BtnFirma.Click += BtnFirma_Click;
        }

        private void BtnUrun_Click(object sender, EventArgs e)
        {
            int id = f.UrunKayitListesiAc(true);

            if (id > 0)
            {
                UrunAc(id);
            }

            AnaSayfa.Aktarma = -1;
        }


        private void BtnFirma_Click(object sender, EventArgs e)
        {
            int id = f.FirmalarListesiAc(true);

            if (id > 0)
            {
                FirmaAc(id);
            }

            AnaSayfa.Aktarma = -1;
        }

        private void FirmaAc(int id)
        {
            int cariId = id;
            tblFirmalar frm = _db.tblFirmalar.First(s => s.Id == cariId);
            
            txtFirmaKodu.Text = frm.Id.ToString().PadLeft(7,'0');
            txtFirmaAdi.Text = frm.Adi;
        }


        private void UrunAc(int id)
        {
            
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            YeniKayit();
        }

        private void YeniKayit()
        {
            Liste.AllowUserToAddRows = false;
            if (txtUrunId.Text == "" && txtUrunKodu.Text == "")
            {
                MessageBox.Show("İlgili alanları doldurunuz!");
                return;
            }

            tblUrunKayitUst ust = new tblUrunKayitUst();
            ust.AciklamaEng = txtAciklamaEng.Text;
            ust.AciklamaTr = txtAciklamaTr.Text;
            ust.GirisTarih = txtGTarih.Value;
            ust.FirmaId = int.Parse( txtFirmaKodu.Text);
            ust.UId = int.Parse(txtUrunId.Text);
            if (pbUrunResmi.Image != null)
                ust.Resim = new System.Data.Linq.Binary(r.ResimYukle(pbUrunResmi.Image)).ToArray();
            ust.UrunKodu = txtUrunKodu.Text;

            _db.tblUrunKayitUst.Add(ust);

            tblUrunKayitAlt[] alt = new tblUrunKayitAlt[Liste.Rows.Count];
            for (int i = 0; i < Liste.Rows.Count; i++)
            {
                alt[i] = new tblUrunKayitAlt();
                alt[i].Aciklama = txtAciklamaTr.Text;
                alt[i].BirimFiyat = Convert.ToDecimal(txtBirimFiyat.Text) ;
                alt[i].BransAdi = "";
                alt[i].MinFiyat = Convert.ToDecimal(txtMinFiyat.Text);
                alt[i].ParaBirimi = txtParaBirimi.Text;
                alt[i].Sinif = txtSinif.Text;
                alt[i].GMDMKodu = Liste.Rows[i].Cells[0].Value.ToString();
                alt[i].UNSPCKodu = Liste.Rows[i].Cells[1].Value.ToString();
                alt[i].SB = Convert.ToBoolean(Liste.Rows[i].Cells[2].Value);
                alt[i].KullanimDisi = Convert.ToBoolean(Liste.Rows[i].Cells[3].Value);
                alt[i].Ubb = Liste.Rows[i].Cells[4].Value.ToString();
                alt[i].Sut = Liste.Rows[i].Cells[5].Value.ToString();
                alt[i].SutFiyat = Convert.ToDecimal(Liste.Rows[i].Cells[6].Value);
                alt[i].SutAciklama = Liste.Rows[i].Cells[7].Value.ToString();
                alt[i].UTS = Convert.ToBoolean(Liste.Rows[i].Cells[8].Value);
                alt[i].UrunId = Convert.ToInt32(txtUrunId.Text);
                alt[i].UICode = txtUrunKodu.Text;

                _db.tblUrunKayitAlt.Add(alt[i]);
            }            
            
            _db.SaveChanges();

            MessageBox.Show("Kaydetme Islemi Basarili!");
        }

        private void Temizle()
        {
            foreach (Control k in scUrunKayit.Panel1.Controls)
            {
                if (k is TextBox || k is ComboBox || k is PictureBox)
                {
                    if (k.Name!=txtUrunId.Name)
                    {
                        k.Text = "";
                    }
                    
                }

                pbUrunResmi.Image = null;
                
            }

            Liste.Rows.Clear();
            Liste.Rows.Add();
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}
