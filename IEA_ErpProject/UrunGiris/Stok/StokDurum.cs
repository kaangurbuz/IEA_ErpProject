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

namespace IEA_ErpProject.UrunGiris.Stok
{
    public partial class StokDurum : Form
    {
        private ErpProject102SEntities _db = new ErpProject102SEntities();
        public bool Secim = false;
        public StokDurum()
        {
            InitializeComponent();
        }

        private void StokDurum_Load(object sender, EventArgs e)
        {
            Listele1();
            Listele2();
        }

        private void Listele1()
        {
            ListeStok1.Rows.Clear();
            int i = 0;
            var srg = from s in _db.tblStokDurum select s;
            foreach (var s in srg.ToList())
            {
                ListeStok1.Rows.Add();
                ListeStok1.Rows[i].Cells[0].Value = s.Id;
                ListeStok1.Rows[i].Cells[1].Value = s.Barkod;
                ListeStok1.Rows[i].Cells[2].Value = s.UrunKodu;
                ListeStok1.Rows[i].Cells[3].Value = s.LotSeriNo;
                ListeStok1.Rows[i].Cells[4].Value = s.StokAdet;
                ListeStok1.Rows[i].Cells[5].Value = s.RafAdet;
                ListeStok1.Rows[i].Cells[6].Value = s.KonsinyeAdet;
                ListeStok1.Rows[i].Cells[7].Value = s.SubeAdet;
                ListeStok1.Rows[i].Cells[8].Value = s.UrunHareketAdet;
                ListeStok1.Rows[i].Cells[9].Value = s.UTS;
                ListeStok1.Rows[i].Cells[10].Value = s.UretimTarih;
                ListeStok1.Rows[i].Cells[11].Value = s.SonKullanmaTarih;
                i++;
            }

            ListeStok1.AllowUserToAddRows = false;
            ListeStok1.AllowUserToDeleteRows = false;
            ListeStok1.ReadOnly = true;
            ListeStok1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void Listele2()
        {

            ListeStok2.Rows.Clear();
            int i = 0;
            //var srg1 = from s in _db.tblStokDurum select s;
            var srg = (from s in _db.tblUrunGirisAlt 
                where s.GirisAdet != 0 group s by new {s.Barkod,s.UrunKodu,s.LotSeriNo} into g 
                select new
                {
                    barkod=g.Key.Barkod,
                    urunKodu=g.Key.UrunKodu,
                    lot = g.Key.LotSeriNo,
                    adet = g.Sum(x=>x.GirisAdet)

                }).ToList();
            foreach (var s in srg.ToList())
            {
                ListeStok2.Rows.Add();
                ListeStok2.Rows[i].Cells[0].Value = s.barkod;
                ListeStok2.Rows[i].Cells[1].Value = s.urunKodu;
                ListeStok2.Rows[i].Cells[2].Value = s.lot;
                ListeStok2.Rows[i].Cells[3].Value = s.adet;
                ListeStok2.Rows[i].Cells[4].Value = s.adet;
           
                i++;
            }

            ListeStok2.AllowUserToAddRows = false;
            ListeStok2.AllowUserToDeleteRows = false;
            ListeStok2.ReadOnly = true;
            ListeStok2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
    }
}
