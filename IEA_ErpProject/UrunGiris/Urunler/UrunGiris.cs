using IEA_ErpProject.Properties;
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

namespace IEA_ErpProject.UrunGiris.Urunler
{
    public partial class UrunGiris : Form
    {
        private readonly Formlar f = new Formlar();
        private readonly ErpProject102SEntities _db = new ErpProject102SEntities();
        private string[] urunList;
        private readonly Numaralar n = new Numaralar();

        public string[] MyArray { get; set; }

        public UrunGiris()
        {
            InitializeComponent();
        }

        private void UrunGiris_Load(object sender, EventArgs e)
        {
            txtGirisId.Text = n.UGirisNo();
        }

        protected override void OnLoad(EventArgs e)
        {
            var btnGiris = new Button();
            btnGiris.Size = new Size(22, txtGirisId.ClientSize.Height);
            btnGiris.Location = new Point(txtGirisId.ClientSize.Width - btnGiris.Width - 1);
            btnGiris.Cursor = Cursors.Default;
            btnGiris.BackgroundImage = Resources.dots;
            btnGiris.BackgroundImageLayout = ImageLayout.Stretch;
            btnGiris.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            txtGirisId.Controls.Add(btnGiris);

            var btn = new Button();
            btn.Size = new Size(22, txtCariAdi.ClientSize.Height);
            btn.Location = new Point(txtCariAdi.ClientSize.Width - btn.Width - 1);
            btn.Cursor = Cursors.Default;
            btn.BackgroundImage = Resources.dots;
            btn.BackgroundImageLayout = ImageLayout.Stretch;
            btn.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            txtCariAdi.Controls.Add(btn);
            base.OnLoad(e);
            btn.Click += Btn_Click;
            btnGiris.Click += BtnGiris_Click;

        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            int id = f.UrunGirisListesiAc(true);

            if (id > 0)
            {
                UrunAc(id);
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

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            Close();
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

        private void Liste_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (Liste.CurrentRow.Cells[3].Value != null && Liste.CurrentRow.Cells[4].Value != null)
            {
                foreach (DataGridViewCell item in Liste.SelectedCells)
                {
                    if (item.Value != null)
                    {
                        if (Liste.CurrentRow != null)
                        {

                            string uKod = Liste.CurrentRow.Cells[3].Value.ToString();
                            string lot = Liste.CurrentRow.Cells[4].Value.ToString();
                            Liste.CurrentRow.Cells[2].Value = uKod + "/" + lot;
                            // FirstOrDefault ile yapilan@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
                            int? sonuc1 =
                                (from x in _db.tblStokDurum
                                    where (x.LotSeriNo == lot && x.UrunKodu == uKod)
                                    select x.Id).FirstOrDefault();

                            if (sonuc1 > 0)
                            {
                                Liste.CurrentRow.Cells[7].Value = sonuc1;
                            }
                            else
                            {
                                Liste.CurrentRow.Cells[7].Value = 0;
                            }
                            // ToList ile yapılan@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
                            //var sonuc = _db.tblStokDurum.Where(x => x.UrunKodu == uKod && x.LotSeriNo == lot).Select(s=>s.Id).ToList();
                            //if (sonuc.Count>0)
                            //{
                            //    Liste.CurrentRow.Cells[7].Value = sonuc[0];
                            //}
                            //else
                            //{
                            //    Liste.CurrentRow.Cells[7].Value = 0;
                            //}
                            //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
                        }
                    }
                }
            }

            if (e.ColumnIndex == 9)
            {
                if (Liste.CurrentRow.Cells[9].Value != null || Liste.CurrentRow.Cells[9].Value.ToString() != "")
                {
                    var uKod = Liste.CurrentRow.Cells[3].Value.ToString();
                    var lst = (from s in _db.tblUrunKayitUst
                        where s.UrunKodu == uKod
                        select s.KullanimSuresi).FirstOrDefault();

                    try
                    {
                        if (lst == null)
                        {
                            Liste.CurrentRow.Cells[10].Value = "01.01.0001";
                        }
                        else
                        {
                            DateTime ay = Convert.ToDateTime(Liste.CurrentRow.Cells[9].Value.ToString());
                            Liste.CurrentRow.Cells[10].Value = ay.AddMonths(Convert.ToInt32(lst)).ToShortDateString();
                        }

                    }
                    catch (Exception exx)
                    {
                        MessageBox.Show("Lutfen girilen tarihi kontrol edin \n Ornek: 30.12.2022");
                        Liste.CurrentRow.Cells[9].Value = "";
                        return;
                    }
                }
            }
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            YeniKayit();
        }

        private void YeniKayit()
        {
            tblUrunGirisUst ust = new tblUrunGirisUst();
            ust.CariAdi = txtCariAdi.Text;
            if (txtCariTur.Text == "Doktor")
            {
                ust.CariId = _db.tblDoktorlar.FirstOrDefault(x => x.Adi == txtCariAdi.Text)?.Id;
            }
            else if (txtCariTur.Text == "Hastane")
            {
                ust.CariId = _db.tblHastaneler.FirstOrDefault(x => x.Adi == txtCariAdi.Text)?.Id;
            }
            else if (txtCariTur.Text == "Personel")
            {
                ust.CariId = _db.tblPersoneller.FirstOrDefault(x => x.Adi == txtCariAdi.Text)?.Id;
            }
            else if (txtCariTur.Text == "Firma")
            {
                ust.CariId = _db.tblFirmalar.FirstOrDefault(x => x.Adi == txtCariAdi.Text)?.Id;
            }
            else
            {
                ust.CariId = -1;
            }

            ust.CariTip = txtCariTur.Text;
            ust.CreatedDate = DateTime.Now;
            ust.CreatedUser = -1;
            ust.FaturaNo = txtFaturaNo.Text;
            ust.Aciklama = txtAciklama.Text;
            ust.GirisId = Convert.ToInt32(txtGirisId.Text);
            ust.GirisTarih = txtGirisTarihi.Value;
            ust.GirisTuru = txtGirisTuru.Text;
            ust.UpdateDate = DateTime.Now;
            ust.UpdateUser = -1;
            ust.IsDeleted = false;

            Liste.AllowUserToAddRows = false;
            tblUrunGirisAlt[] alt = new tblUrunGirisAlt[Liste.Rows.Count];
            //tblStokDurum[] durums = new tblStokDurum[Liste.RowCount];


            for (int i = 0; i < Liste.Rows.Count; i++)
            {
                #region trigger'a yaptirilan stok durum
                //if (Convert.ToInt32(Liste.Rows[i].Cells[7].Value) == 0)
                //{
                //    durums[i] = new tblStokDurum();
                //    durums[i].UrunKodu = Liste.Rows[i].Cells[3].Value.ToString();
                //    durums[i].Barkod = Liste.Rows[i].Cells[2].Value.ToString();
                //    durums[i].BransNo = "";
                //    durums[i].KonsinyeAdet = 0;
                //    durums[i].LotSeriNo = Liste.Rows[i].Cells[4].Value.ToString();
                //    durums[i].RafAdet = Convert.ToInt32( Liste.Rows[i].Cells[5].Value.ToString());
                //    durums[i].StokAdet = Convert.ToInt32( Liste.Rows[i].Cells[5].Value.ToString());
                //    durums[i].SonKullanmaTarih = Convert.ToDateTime(Liste.Rows[i].Cells[10].Value);
                //    durums[i].SubeAdet = 0;
                //    durums[i].SutKodu = "";
                //    durums[i].UretimTarih = Convert.ToDateTime(Liste.Rows[i].Cells[9].Value);
                //    durums[i].UTS = Convert.ToBoolean(Liste.Rows[i].Cells[8].Value);
                //    durums[i].UrunHareketAdet = 0;
                //    _db.tblStokDurum.Add(durums[i]);
                //}
                //else
                //{
                //    var urunId = Convert.ToInt32(Liste.Rows[i].Cells[7].Value);
                //    var srg = _db.tblStokDurum.FirstOrDefault(s => s.Id == urunId);
                //    srg.StokAdet += Convert.ToInt32(Liste.Rows[i].Cells[5].Value);
                //    srg.RafAdet += Convert.ToInt32(Liste.Rows[i].Cells[5].Value);
                //}
                /////////////////////////////// 
                #endregion
                alt[i] = new tblUrunGirisAlt();
                alt[i].GirisAdet = Convert.ToInt32(Liste.Rows[i].Cells[5].Value);
                alt[i].Barkod = Liste.Rows[i].Cells[2].Value.ToString();
                alt[i].UrunKodu = Liste.Rows[i].Cells[3].Value.ToString();
                alt[i].LotSeriNo = Liste.Rows[i].Cells[4].Value.ToString();

                alt[i].Aciklama = Convert.ToString(Liste.Rows[i].Cells[6].Value);
                alt[i].UTS = Convert.ToBoolean(Liste.Rows[i].Cells[8].Value);
                alt[i].UretimTarihi = Convert.ToDateTime(Liste.Rows[i].Cells[9].Value);
                alt[i].SonKullanmaTarihi = Convert.ToDateTime(Liste.Rows[i].Cells[10].Value);
                alt[i].GirisId = Convert.ToInt32(txtGirisId.Text);
                alt[i].GirisTarih = txtGirisTarihi.Value;
                alt[i].BransNo = "-1";

                _db.tblUrunGirisAlt.Add(alt[i]);
            }

            _db.tblUrunGirisUst.Add(ust);
            _db.SaveChanges();
            MessageBox.Show("Kayit Basariyla Olusturuldu!");
            Temizle();
        }

        private void Temizle()
        {
            foreach (Control item in scUrunGiris.Panel2.Controls)
            {
                if (item is TextBox || item is ComboBox||item is DateTimePicker)
                {
                    if (item.Name != txtGirisId.Name)
                    {
                        item.Text = "";
                    }
                }

                txtCariTur.SelectedIndex = -1;
                Liste.Rows.Clear();
            }
        }

        private void Liste_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < Liste.Rows.Count; i++)
            {
                if (Liste.Rows[i].Cells[3].Value != null && Liste.Rows[i].Cells[4].Value != null)
                {
                    foreach (DataGridViewCell item in Liste.SelectedCells)
                    {
                        if (item.Value != null)
                        {
                            if (Liste.Rows[i] != null)
                            {

                                string uKod = Liste.Rows[i].Cells[3].Value.ToString();
                                string lot = Liste.Rows[i].Cells[4].Value.ToString();
                                Liste.Rows[i].Cells[2].Value = uKod + "/" + lot;
                                // FirstOrDefault ile yapilan@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
                                int? sonuc1 =
                                    (from x in _db.tblStokDurum
                                     where (x.LotSeriNo == lot && x.UrunKodu == uKod)
                                     select x.Id).FirstOrDefault();

                                if (sonuc1 > 0)
                                {
                                    Liste.Rows[i].Cells[7].Value = sonuc1;
                                }
                                else
                                {
                                    Liste.Rows[i].Cells[7].Value = 0;
                                }
                                // ToList ile yapılan@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
                                //var sonuc = _db.tblStokDurum.Where(x => x.UrunKodu == uKod && x.LotSeriNo == lot).Select(s=>s.Id).ToList();
                                //if (sonuc.Count>0)
                                //{
                                //    Liste.CurrentRow.Cells[7].Value = sonuc[0];
                                //}
                                //else
                                //{
                                //    Liste.CurrentRow.Cells[7].Value = 0;
                                //}
                                //@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
                            }
                        }
                    }
                }
            }
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        public void UrunAc(int GirisId)
        {
            Temizle();
            var ust = _db.tblUrunGirisUst.FirstOrDefault(x => x.GirisId == GirisId);
            if (ust != null)
            {
                txtGirisId.Text = ust.GirisId.ToString().PadLeft(7,'0');
                txtCariTur.Text = ust.CariTip;
                txtCariAdi.Text = ust.CariAdi;
                txtFaturaNo.Text = ust.FaturaNo;
                txtGirisTarihi.Text = ust.GirisTarih.ToString();
                txtAciklama.Text = ust.Aciklama;
                txtGirisTuru.Text = ust.GirisTuru;

            }
            else
            {
                MessageBox.Show("Istek sirasinda bir hata meydana geldi! \n Tekrar deneyin!");
                return;
            }

            Liste.AllowUserToAddRows = false;
            var alt = _db.tblUrunGirisAlt.Where(s => s.GirisId == GirisId).ToList();
            int i = 0;
            foreach (var item in alt)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = item.Id;
                Liste.Rows[i].Cells[1].Value = i+1;
                Liste.Rows[i].Cells[2].Value = item.Barkod;
                Liste.Rows[i].Cells[3].Value = item.UrunKodu;
                Liste.Rows[i].Cells[4].Value = item.LotSeriNo;
                Liste.Rows[i].Cells[5].Value = item.GirisAdet;
                Liste.Rows[i].Cells[6].Value = item.Aciklama;
                Liste.Rows[i].Cells[7].Value = item.GirisId;
                Liste.Rows[i].Cells[8].Value = item.UTS;
                Liste.Rows[i].Cells[9].Value = item.UretimTarihi;
                Liste.Rows[i].Cells[10].Value = item.SonKullanmaTarihi;
                i++;
            }
        }
    }
}
