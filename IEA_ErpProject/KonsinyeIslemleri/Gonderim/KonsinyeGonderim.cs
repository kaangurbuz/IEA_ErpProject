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

namespace IEA_ErpProject.KonsinyeIslemleri.Giris
{
    public partial class KonsinyeGonderim : Form
    {
        private string[] urunList;
        private readonly ErpProContext _code = new ErpProContext();
        private readonly ErpProject102SEntities _db=new ErpProject102SEntities();
        public KonsinyeGonderim()
        {
            InitializeComponent();
        }
        private void KonsinyeGonderim_Load(object sender, EventArgs e)
        {

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
                kons[i].CreatedDate = DateTime.Now;
                kons[i].UpdatedDate = DateTime.Now;
                kons[i].CreatedUser = 1;
                kons[i].UpdatedUser = 1;
                kons[i].isDeleted = false;
                kons[i].CariId = 1;
            }

            _code.TblKonsinyeGonderimler.AddRange(kons);
            _code.SaveChanges();
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
    }
}
