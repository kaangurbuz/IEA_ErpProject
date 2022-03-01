using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IEA_ErpProject.Entity;
using IEA_ErpProject.Functions;

namespace IEA_ErpProject.BilgiGiris.Hastaneler
{
    public partial class HastanelerListesi : Form
    {
        private readonly ErpProject102SEntities _db = new ErpProject102SEntities();
        private List<tblHastaneler> hstList;
        private int secimId = -1;
        public bool Secim = false;
        private readonly Formlar f = new Formlar();
        public HastanelerListesi()
        {
            InitializeComponent();
        }

        private void HastanelerListesi_Load(object sender, EventArgs e)
        {
             Listele();
        }

        private void Listele()
        {

            Liste.Rows.Clear();
            int i = 0;

            hstList = (from s in _db.tblHastaneler where s.Adi.Contains(txtHastaneAra.Text) select s).ToList(); //LINQ sorgusu

            foreach (var item in hstList)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = i + 1;
                Liste.Rows[i].Cells[1].Value = item.Id;
                Liste.Rows[i].Cells[2].Value = item.Adi;
                if (item.tblHastaneTipleri != null) Liste.Rows[i].Cells[3].Value = item.tblHastaneTipleri.TipAdi;
                Liste.Rows[i].Cells[4].Value = item.Telefon;
                Liste.Rows[i].Cells[5].Value = item.Sehirler.name;
                i++;
            }

            Liste.AllowUserToAddRows = false; // kullanicinin satir eklemesini engeller
            Liste.AllowUserToDeleteRows = false; // kullanici kayit silemesin
            Liste.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Liste.ReadOnly = true;
        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            if (Liste.CurrentRow != null) secimId = (int?)Liste.CurrentRow.Cells[1].Value ?? -1;

            if (secimId > 0 && Application.OpenForms["HastaneGiris"] == null && Secim)
            {

                AnaSayfa.Aktarma = secimId;
                Close();


            }

            else if (Application.OpenForms["HastaneGiris"] != null && Secim)
            {
                HastaneGiris frm = Application.OpenForms["HastaneGiris"] as HastaneGiris;
                frm.Ac(secimId);
                Close();
            }

            else if (!Secim)
            {
                f.HastaneGirisAc(secimId);
                Close();
            }
        }

        private void BtnHastaneAra_Click(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
