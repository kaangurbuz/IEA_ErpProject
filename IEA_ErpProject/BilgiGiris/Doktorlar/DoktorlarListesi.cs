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

namespace IEA_ErpProject.BilgiGiris.Doktorlar
{
    public partial class DoktorlarListesi : Form
    {
        private readonly ErpProject102SEntities _db = new ErpProject102SEntities();
        private List<tblDoktorlar> dktList;
        private int secimId = -1;
        public bool Secim = false;
        private readonly Formlar f = new Formlar();
        public DoktorlarListesi()
        {
            InitializeComponent();
        }

        private void DoktorlarListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            Liste.Rows.Clear();
            int i = 0;
            dktList = (from s in _db.tblDoktorlar where s.Adi.Contains(txtDoktorAra.Text) select s).ToList(); //LINQ sorgusu
            

            foreach (var item in dktList)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = i + 1;
                Liste.Rows[i].Cells[1].Value = item.Id;
                Liste.Rows[i].Cells[2].Value = item.Unvan;
                Liste.Rows[i].Cells[3].Value = item.Adi;
                Liste.Rows[i].Cells[4].Value = item.Tel;
                Liste.Rows[i].Cells[5].Value = item.Tel2;
                Liste.Rows[i].Cells[6].Value = item.Gsm;
                Liste.Rows[i].Cells[7].Value = item.Email;
                if (item.Sehirler != null) Liste.Rows[i].Cells[8].Value = item.Sehirler.name;
                i++;
            }

            Liste.AllowUserToAddRows = false; // kullanicinin satir eklemesini engeller
            Liste.AllowUserToDeleteRows = false; // kullanici kayit silemesin
            Liste.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Liste.ReadOnly = true;
        }

        private void BtnDoktorAra_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            if (Liste.CurrentRow != null) secimId = (int?)Liste.CurrentRow.Cells[1].Value ?? -1;

            if (secimId > 0 && Application.OpenForms["DoktorGiris"] == null && Secim)
            {

                AnaSayfa.Aktarma = secimId;
                Close();


            }

            else if (Application.OpenForms["DoktorGiris"] != null && Secim)
            {
                DoktorGiris frm = Application.OpenForms["DoktorGiris"] as DoktorGiris;
                frm.Ac(secimId);
                Close();
            }

            else if (!Secim)
            {
                f.DoktorlarGirisAc(secimId);
                Close();
            }
        }
    }
}

/* private void Liste_DoubleClick(object sender, EventArgs e)
        {
            if (Liste.CurrentRow != null) secimId = (int?)Liste.CurrentRow.Cells[1].Value ?? -1;

            if (secimId > 0 && Application.OpenForms["DoktorGiris"] == null)
            {

                //AnaSayfa.Aktarma=secimId;
                Close();
                f.DoktorlarGirisAc(secimId);

            }

            else if (Application.OpenForms["DoktorGiris"] != null)
            {
                DoktorGiris frm = Application.OpenForms["DoktorGiris"] as DoktorGiris;
                frm.Ac(secimId);
                Close();
            }
        }*/
