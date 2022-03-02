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

namespace IEA_ErpProject.BilgiGiris.Firmalar
{
    public partial class FirmalarListesi : Form
    {
        private readonly ErpProject102SEntities _db = new ErpProject102SEntities();
        public bool Secim = false;
        //private FirmaGiris frm = new FirmaGiris();
        private List<tblFirmalar> frmList;
        private int secimId = -1;
        private Formlar f = new Formlar();
        public FirmalarListesi()
        {
            InitializeComponent();
        }

        private void FirmalarListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            Liste.Rows.Clear();
            int i = 0;
            frmList = (from s in _db.tblFirmalar where s.Adi.Contains(txtFirmaAra.Text) select s).ToList();
            //var lst1 = (from s in _db.tblFirmalar
            //    select new
            //    {
            //        id = s.Id,
            //        fadi = s.Adi,
            //        ftip = s.FirmaTip,
            //        tel = s.Tel,
            //        sehir = s.Sehirler.name//sehir null kontrolunu denetle
            //    }).ToList();

            foreach (var k in frmList)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = i + 1;
                Liste.Rows[i].Cells[1].Value = k.Id;
                Liste.Rows[i].Cells[2].Value = k.Adi;
                Liste.Rows[i].Cells[3].Value = k.FirmaTip;
                Liste.Rows[i].Cells[4].Value = k.Tel;
                if (k.Sehirler != null) Liste.Rows[i].Cells[5].Value = k.Sehirler.name;
                i++;
            }

            Liste.AllowUserToAddRows = false;
            Liste.AllowUserToDeleteRows = false;
            Liste.ReadOnly = true;
            Liste.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            if (Liste.CurrentRow != null) secimId = (int?)Liste.CurrentRow.Cells[1].Value ?? -1;

            if (secimId > 0 && Application.OpenForms["FirmaGiris"] == null&&Secim)
            {

                AnaSayfa.Aktarma=secimId;
                Close();
               
                //f.FirmaGirisAc(secimId);

            }

            else if (Application.OpenForms["FirmaGiris"] != null&&Secim)
            {
                FirmaGiris frm = Application.OpenForms["FirmaGiris"] as FirmaGiris;
                frm.Ac(secimId);
                Close();
            }

            else if (!Secim)
            {
                f.FirmaGirisAc(secimId);
                Close();
            }

        }

        private void BtnHastaneAra_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void txtFirmaAra_TextChanged(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
