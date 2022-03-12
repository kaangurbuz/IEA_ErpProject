using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        private readonly Numaralar n = new Numaralar();
        private readonly Resimler r = new Resimler();
        private readonly Formlar f = new Formlar();
        private bool _resim = false;
        //private bool YeniKayitBool = false;
        readonly OpenFileDialog _dosya = new OpenFileDialog();
        private int secimId = -1;

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
            if (_dosya.ShowDialog() == DialogResult.OK)
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

            txtFirmaKodu.Text = frm.Id.ToString().PadLeft(7, '0');
            txtFirmaAdi.Text = frm.Adi;
        }


        public void UrunAc(int uid)
        {
            
            Temizle();
            BtnKaydet.Visible = false;
            secimId = uid;
            Liste.AllowUserToAddRows = false;
            tblUrunKayitUst lst = _db.tblUrunKayitUst.FirstOrDefault(s => s.UId == uid);

            txtAciklamaEng.Text = lst.AciklamaEng;
            txtAciklamaTr.Text = lst.AciklamaTr;
            txtGTarih.Text = lst.GirisTarih.ToString();
            if (lst.tblFirmalar != null) txtFirmaAdi.Text = lst.tblFirmalar.Adi;
            if (lst.FirmaId != null) txtFirmaKodu.Text = lst.FirmaId.ToString();
            txtUrunId.Text = lst.UId.ToString().PadLeft(7, '0');
            txtUrunKodu.Text = lst.UrunKodu;
            txtKullanimSuresi.Text = lst.KullanimSuresi.ToString();
            if (lst.Resim != null) pbUrunResmi.Image = r.ResimGetir(lst.Resim);
            etiketId.Text = lst.Id.ToString().PadLeft(7,'0');

            var alt = _db.tblUrunKayitAlt.Where(x => x.UrunId == uid).ToList();
            var urunAltTek = _db.tblUrunKayitAlt.FirstOrDefault(s => s.UrunId == uid);
            int i = 0;
            foreach (var item in alt)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = item.GMDMKodu;
                Liste.Rows[i].Cells[1].Value = item.UNSPCKodu;
                Liste.Rows[i].Cells[2].Value = item.SB;
                Liste.Rows[i].Cells[3].Value = item.KullanimDisi;
                Liste.Rows[i].Cells[4].Value = item.Ubb;
                Liste.Rows[i].Cells[5].Value = item.Sut;
                Liste.Rows[i].Cells[6].Value = item.SutFiyat;
                Liste.Rows[i].Cells[7].Value = item.SutAciklama;
                Liste.Rows[i].Cells[8].Value = item.UTS;
                Liste.Rows[i].Cells[9].Value = false;
                Liste.Rows[i].Cells[10].Value = item.Id;
                i++;
            }

            if (urunAltTek != null)
            {
                txtSinif.Text = urunAltTek.Sinif;
                txtParaBirimi.Text = urunAltTek.ParaBirimi;
                txtMinFiyat.Text = urunAltTek.MinFiyat.ToString();
                txtBirimFiyat.Text = urunAltTek.BirimFiyat.ToString();
            }



            //Liste.AllowUserToDeleteRows = false;
            //Liste.AllowUserToAddRows = false;
            //Liste.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //Liste.ReadOnly = true;
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            YeniKayit();
        }

        private void YeniKayit()
        {
            Liste.AllowUserToAddRows = false;
            if (txtUrunId.Text == "" || txtUrunKodu.Text == "" || txtFirmaKodu.Text == "")
            {
                MessageBox.Show("İlgili alanları doldurunuz!");
                Liste.AllowUserToAddRows = true;
                return;
            }

            tblUrunKayitUst ust = new tblUrunKayitUst();
            ust.AciklamaEng = txtAciklamaEng.Text;
            ust.AciklamaTr = txtAciklamaTr.Text;
            ust.GirisTarih = txtGTarih.Value;
            ust.FirmaId = int.Parse(txtFirmaKodu.Text);
            ust.UId = int.Parse(txtUrunId.Text);
            if (pbUrunResmi.Image != null)
                ust.Resim = new System.Data.Linq.Binary(r.ResimYukle(pbUrunResmi.Image)).ToArray();
            ust.UrunKodu = txtUrunKodu.Text;
            ust.KullanimSuresi = int.Parse(txtKullanimSuresi.Text);

            _db.tblUrunKayitUst.Add(ust);

            tblUrunKayitAlt[] alt = new tblUrunKayitAlt[Liste.Rows.Count];
            for (int i = 0; i < Liste.Rows.Count; i++)
            {
                alt[i] = new tblUrunKayitAlt();
                alt[i].Aciklama = txtAciklamaTr.Text;
                alt[i].BirimFiyat = Convert.ToDecimal(txtBirimFiyat.Text);
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
                    if (k.Name != txtUrunId.Name)
                    {
                        k.Text = "";
                    }

                }

                pbUrunResmi.Image = null;

            }

            Liste.Rows.Clear();
            //Liste.Rows.Add();
            BtnKaydet.Visible = true;
            txtUrunId.Text = n.UidNo();

            secimId = -1;
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void Guncelle()
        {
            Liste.AllowUserToAddRows = false;
            int a = Convert.ToInt32(txtUrunId.Text);
            tblUrunKayitUst ust = _db.tblUrunKayitUst.FirstOrDefault(x => x.UId == a);
            ust.AciklamaEng = txtAciklamaEng.Text;
            ust.AciklamaTr = txtAciklamaTr.Text;
            ust.GirisTarih = txtGTarih.Value;
            ust.FirmaId = int.Parse(txtFirmaKodu.Text);
            ust.UId = int.Parse(txtUrunId.Text);
            //if (pbUrunResmi.Image != null)
            //    ust.Resim = new System.Data.Linq.Binary(r.ResimYukle(pbUrunResmi.Image)).ToArray();
            ust.UrunKodu = txtUrunKodu.Text;
            ust.KullanimSuresi = int.Parse(txtKullanimSuresi.Text);
            _db.SaveChanges();

            // tblUrunKayitAlt alt = (tblUrunKayitAlt)_db.tblUrunKayitAlt.Where(x => x.UrunId == int.Parse(txtUrunId.Text));
            List <tblUrunKayitAlt> alt = _db.tblUrunKayitAlt.Where(x => x.UrunId == a).ToList();

            for (int i = 0; i < Liste.RowCount; i++)
            {
                var value = Liste.Rows[i].Cells[9].Value;
                if (value != null && (bool)value != true)
                {
                    int indexId = alt[i].Id;
                    alt[i] = _db.tblUrunKayitAlt.FirstOrDefault(s => s.Id == indexId);
                    //alt[i] = new tblUrunKayitAlt();
                    alt[i].Aciklama = txtAciklamaTr.Text;
                    alt[i].BirimFiyat = Convert.ToDecimal(txtBirimFiyat.Text);
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
                }
                else
                {
                    alt.Add(null);
                    alt[i] = new tblUrunKayitAlt();
                    alt[i].Aciklama = txtAciklamaTr.Text;
                    alt[i].BirimFiyat = Convert.ToDecimal(txtBirimFiyat.Text);
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
            }
            _db.SaveChanges();
            MessageBox.Show("Guncellenme islemi basarili!");
        }

        private void BtnListeEkle_Click(object sender, EventArgs e)
        {
            
            if (Liste.AllowUserToAddRows == true)
            {
                Liste.AllowUserToAddRows = false;
                //YeniKayitBool = false;
                
            }
            else
            { 
                Liste.AllowUserToAddRows = true;
                //YeniKayitBool = true;
                var srg = Liste.RowCount;
                if (Liste.CurrentRow != null) Liste.Rows[srg - 1].Cells[9].Value = true;

            }
           

            

        }

        private void BtnListeSatirSil_Click(object sender, EventArgs e)
        {
            tblUrunKayitAlt[] alt = new tblUrunKayitAlt[Liste.RowCount];
            bool SecimVarMi = true;
            if (secimId < 0)
            {
                MessageBox.Show(
                    "Once Kayit seciniz!");
                return;
            }
            for (int i = 0; i < Liste.RowCount; i++)
            {
                if ((bool)Liste.Rows[i].Cells[9].Value == true)
                {
                    var srg = _db.tblUrunKayitAlt.Find(Liste.Rows[i].Cells[10].Value);
                    _db.tblUrunKayitAlt.Remove(srg);
                    SecimVarMi = false;
                }
                
            }
            if (SecimVarMi)
            {

                MessageBox.Show(
                    "Silinecek satir bulunamadi!.Silmek istediğiniz satirlarin durum tikini işaretleyiniz");
                return;
            }

            try
            {
                if (_db.SaveChanges() > 0)
                {
                    MessageBox.Show("Satir silme islemi yapildi");
                    UrunAc(int.Parse(txtUrunId.Text));
                }
                
            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message + " Sql - Islem bilinmeyen bir sebepten oturu yapilamadi..");
                throw;
            }

            catch (Exception exx)
            {
                MessageBox.Show(exx.Message + " C# - Islem bilinmeyen bir sebepten oturu yapilamadi..");
                throw;
            }

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            var srg = _db.tblUrunKayitUst.Find(int.Parse( etiketId.Text));
            var uid = _db.tblUrunKayitAlt.Where(s=>s.UrunId==srg.UId);
            _db.tblUrunKayitUst.Remove(srg);
            _db.tblUrunKayitAlt.RemoveRange(uid);
            try
            {
                if (_db.SaveChanges() > 0)
                {
                    MessageBox.Show("Satir silme islemi yapildi");
                    Close();
                }
            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message + " Sql - Islem bilinmeyen bir sebepten oturu yapilamadi..");
                throw;
            }

            catch (Exception exx)
            {
                MessageBox.Show(exx.Message + " C# - Islem bilinmeyen bir sebepten oturu yapilamadi..");
                throw;
            }
        }
    }
}
