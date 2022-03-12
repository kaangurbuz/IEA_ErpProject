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
using IEA_ErpProject.Entity.Code;
using IEA_ErpProject.Functions;
using IEA_ErpProject.Properties;

namespace IEA_ErpProject.KonsinyeIslemleri.Giris
{
    public partial class KonsinyeGonderim : Form
    {
        private string[] urunList;
        private readonly ErpProContext _code = new ErpProContext();
        private readonly ErpProject102SEntities _db=new ErpProject102SEntities();
        private Numaralar n = new Numaralar();
        private Formlar f = new Formlar();
        private int gonId = -1;
        public KonsinyeGonderim()
        {
            InitializeComponent();
        }
        private void KonsinyeGonderim_Load(object sender, EventArgs e)
        {
            txtKonGonderimId.Text = n.KonGonderimNo();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            YeniKayit();
        }

        private void YeniKayit()
        {
            Liste.AllowUserToAddRows = false;
            tblKonsinyeGonderim[] kons = new tblKonsinyeGonderim[Liste.RowCount];
            for (int i = 0; i < kons.Length; i++)
            {
                kons[i] = new tblKonsinyeGonderim();
                kons[i].CariAdi = txtCariAdi.Text;
                kons[i].Aciklama = txtKonGonderimAciklama.Text;
                kons[i].CariTur = txtCariTur.Text;
                kons[i].Adet= Convert.ToInt32( Liste.Rows[i].Cells[6].Value);
                kons[i].GonderimTarih = txtKonGonderimTarihi.Value;
                var brk = Liste.Rows[i].Cells[2].Value;
                kons[i].UrunId = _db.tblStokDurum.FirstOrDefault(s => s.Barkod != null && s.Barkod == brk).Id;
                //kons[i].CreatedDate = DateTime.Now;
                //kons[i].UpdatedDate = DateTime.Now;
                //kons[i].CreatedUser = 1;
                //kons[i].UpdatedUser = 1;
                //kons[i].isDeleted = false;
                kons[i].CariId = 1;
                kons[i].GonderimId = int.Parse( n.KonGonderimNo());

                var srgStok = _db.tblStokDurum.Find(kons[i].UrunId);
                srgStok.RafAdet-= Convert.ToInt32(Liste.Rows[i].Cells[6].Value);
                srgStok.KonsinyeAdet += Convert.ToInt32(Liste.Rows[i].Cells[6].Value);
                _db.SaveChanges();
            }

            _code.TblKonsinyeGonderimler.AddRange(kons);
            _code.SaveChanges();
            MessageBox.Show("Kayit Basarili!");
        }

        private void Liste_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            try
            {
                urunList = _db.tblUrunKayitUst.Select(x => x.UrunKodu).Distinct().ToArray();
                if (Liste.CurrentCell.ColumnIndex == 3 && e.Control is TextBox txt)
                {
                    txt.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    txt.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    txt.AutoCompleteCustomSource.AddRange(urunList);
                }
                else if (Liste.CurrentCell.ColumnIndex != 3 && e.Control is TextBox txt1)
                {
                    txt1.AutoCompleteMode = AutoCompleteMode.None;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

        private void Liste_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (Liste.CurrentCell.ColumnIndex == 4)
            {
                LotBul lotbul = new LotBul();
                if (Liste.CurrentRow.Cells[3] != null) lotbul.uKod = Liste.CurrentRow.Cells[3].Value.ToString();
                lotbul.ShowDialog();
                
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            var btnGonderim = new Button();
            btnGonderim.Size = new Size(20, txtKonGonderimId.ClientSize.Height);
            btnGonderim.Location = new Point(txtKonGonderimId.ClientSize.Width - btnGonderim.Width - 1);
            btnGonderim.Cursor = Cursors.Default;
            btnGonderim.BackgroundImage = Resources.dots;
            btnGonderim.BackgroundImageLayout = ImageLayout.Stretch;
            btnGonderim.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            txtKonGonderimId.Controls.Add(btnGonderim);

            var btn = new Button();
            btn.Size = new Size(20, txtCariAdi.ClientSize.Height);
            btn.Location = new Point(txtCariAdi.ClientSize.Width - btn.Width - 1);
            btn.Cursor = Cursors.Default;
            btn.BackgroundImage = Resources.dots;
            btn.BackgroundImageLayout = ImageLayout.Stretch;
            btn.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            txtCariAdi.Controls.Add(btn);
           

            btn.Click += Btn_Click;
            base.OnLoad(e);
            btnGonderim.Click += BtnGonderim_Click;
        }

        private void BtnGonderim_Click(object sender, EventArgs e)
        {
            int id = f.KonsinyeGonderimListesiAc(true);

            if (id > 0)
            {
                KonsinyeGonderimAc(id);
            }

            AnaSayfa.Aktarma = -1;
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            int cariId = -1;
            switch (txtCariTur.Text)
            {
                case "Hastane":
                    cariId = f.HastanelerListesiAc(true);
                    if (cariId > 0)
                    {
                        HastaneAc(cariId);
                    }

                    break;
                case "Doktor":
                    cariId = f.DoktorlarListesiAc(true);
                    if (cariId > 0)
                    {
                        DoktorAc(cariId);
                    }

                    break;
                case "Personel":
                    cariId = f.PersonellerListesiAc(true);
                    if (cariId > 0)
                    {
                        PersonelAc(cariId);
                    }
                    break;
                case "Firma":
                    cariId = f.FirmalarListesiAc(true);
                    if (cariId > 0)
                    {
                        FirmaAc(cariId);
                    }

                    break;
                case "Diger":
                    txtCariAdi.Text = "Bilinmiyor";
                    break;
            }

            AnaSayfa.Aktarma = -1;
        }

        public void KonsinyeGonderimAc(int id)
        {
            gonId = id;
            var srg = _code.TblKonsinyeGonderimler.Where(s => s.GonderimId == id).ToList();
            var srgStok = _db.tblStokDurum.ToList();
            int i = 0;
            if (srg.Count > 0)
            {
                foreach (var s in srg)
                {
                    Liste.Rows.Add();
                    Liste.Rows[i].Cells[0].Value = s.Id;
                    Liste.Rows[i].Cells[1].Value = i + 1;
                    Liste.Rows[i].Cells[2].Value = srgStok.FirstOrDefault(x=>x.Id==s.UrunId)?.Barkod;
                    Liste.Rows[i].Cells[3].Value = srgStok.FirstOrDefault(x => x.Id == s.UrunId)?.UrunKodu;
                    Liste.Rows[i].Cells[3].ReadOnly = true;
                    Liste.Rows[i].Cells[4].Value = srgStok.FirstOrDefault(x => x.Id == s.UrunId)?.LotSeriNo;
                    Liste.Rows[i].Cells[4].ReadOnly = true;
                    Liste.Rows[i].Cells[5].Value = srgStok.FirstOrDefault(x => x.Id == s.UrunId)?.RafAdet;
                    Liste.Rows[i].Cells[6].Value = s.Adet;
                    Liste.Rows[i].Cells[7].Value = s.Aciklama;
                    Liste.Rows[i].Cells[8].Value = s.UrunId;
                    Liste.Rows[i].Cells[9].Value = srgStok.FirstOrDefault(x => x.Id == s.UrunId)?.UTS;
                    Liste.Rows[i].Cells[10].Value = srgStok.FirstOrDefault(x=>x.Id==s.UrunId)?.UretimTarih;
                    Liste.Rows[i].Cells[11].Value = srgStok.FirstOrDefault(x => x.Id == s.UrunId)?.SonKullanmaTarih;
                    Liste.Rows[i].Cells[12].Value = false;
                    i++;
                }

                i--;
                txtKonGonderimId.Text = srg[i].GonderimId.ToString().PadLeft(7,'0');
                txtCariTur.Text = srg[i].CariTur;
                txtCariAdi.Text = srg[i].CariAdi;
                txtKonGonderimTarihi.Text = srg[i].GonderimTarih.ToShortDateString();
                txtKonGonderimAciklama.Text = "GonderimAciklama"; //srg[i];
                etiketId.Text = srg[i].GonderimId.ToString().PadLeft(7, '0');
                //txtKonGonderimTuru.Text = srg[i]. // gonderim turu eklenecek
            }
        }

        private void PersonelAc(int cariId)
        {
            txtCariAdi.Text = _db.tblPersoneller.FirstOrDefault(s => s.Id == cariId)?.Adi;
        }

        private void FirmaAc(int cariId)
        {
            txtCariAdi.Text = _db.tblFirmalar.FirstOrDefault(s => s.Id == cariId)?.Adi;
        }

        private void DoktorAc(int cariId)
        {
            txtCariAdi.Text = _db.tblDoktorlar.FirstOrDefault(s => s.Id == cariId)?.Adi;
        }

        private void HastaneAc(int cariId)
        {
            txtCariAdi.Text = _db.tblHastaneler.FirstOrDefault(s => s.Id == cariId)?.Adi;
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            Sil();
        }

        private void Sil()
        {
            if (gonId>0)
            {
                int gId = Convert.ToInt32(txtKonGonderimId.Text);
                var srg = _code.TblKonsinyeGonderimler.Where(x => x.GonderimId ==gId).ToList();
                int i = 0;
                foreach (var s in srg)
                {
                    s.isDeleted = true;

                    var srgStok = _db.tblStokDurum.FirstOrDefault(x => x.Id == s.UrunId);
                    _code.SaveChanges();
                    srgStok.KonsinyeAdet -= Convert.ToInt32(Liste.Rows[i].Cells[6].Value);
                    srgStok.RafAdet += Convert.ToInt32(Liste.Rows[i].Cells[6].Value);
                    _db.SaveChanges();
                   
                }

            }

        }
    }
}
