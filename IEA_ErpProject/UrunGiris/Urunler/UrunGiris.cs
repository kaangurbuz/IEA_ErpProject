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
        public string[] MyArray { get; set; }
        public UrunGiris()
        {
            InitializeComponent();
        }

        private void UrunGiris_Load(object sender, EventArgs e)
        {

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
            MessageBox.Show("islem calisiyor");
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
                    //CariId = f.PersonellerListesiAc(true);
                    //if (CariId > 0)
                    //{
                    //    DoktorAc(CariId);
                    //}
                    txtCariAdi.Text = "Yapim Asamasinda";
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
                    txt.AutoCompleteMode=AutoCompleteMode.SuggestAppend;
                    txt.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    txt.AutoCompleteCustomSource.AddRange(urunList);
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
            if (e.ColumnIndex==4)
            {
                foreach (DataGridViewCell item in Liste.SelectedCells)
                {
                    if (item.Value!=null)
                    {
                        if (Liste.CurrentRow!=null)
                        {
                            string uKod = Liste.CurrentRow.Cells[3].Value.ToString();
                            string lot = Liste.CurrentRow.Cells[4].Value.ToString();
                            var sonuc = _db.tblStokDurum.Where(x => x.UrunKodu == uKod && x.LotSeriNo == lot).Select(s=>s.Id).ToList();

                            if (sonuc.Count>0)
                            {
                                Liste.CurrentRow.Cells[7].Value = sonuc[0];
                            }
                            else
                            {
                                Liste.CurrentRow.Cells[7].Value = 0;
                            }

                        }
                    }
                }
            }
        }
    }
}
