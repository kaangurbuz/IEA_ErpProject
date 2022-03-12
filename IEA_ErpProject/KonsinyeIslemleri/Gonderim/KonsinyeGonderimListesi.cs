using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IEA_ErpProject.Entity.Code;

namespace IEA_ErpProject.KonsinyeIslemleri.Giris
{
    public partial class KonsinyeGonderimListesi : Form
    {
        public bool Secim = false;
        private readonly ErpProContext code = new ErpProContext();
        private int gonderimId = -1;
        public KonsinyeGonderimListesi()
        {
            InitializeComponent();
        }

        private void KonsinyeGirisListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            Liste.Rows.Clear();
            int i = 0;
            //var srg1 = code.TblKonsinyeGonderimler.ToList();
            var srg = (from s in code.TblKonsinyeGonderimler
                       where s.isDeleted!=true
                where s.CariAdi.Contains(txtGirisAra.Text) 
                select s)
                .GroupBy(s => new {s.GonderimId})
                .Select(group=>group.FirstOrDefault()).ToList();
            

            foreach (var s in srg)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = i + 1;
                Liste.Rows[i].Cells[1].Value = s.Id;
                Liste.Rows[i].Cells[2].Value = s.CariTur;
                Liste.Rows[i].Cells[3].Value = s.CariAdi;
                Liste.Rows[i].Cells[4].Value = s.GonderimTarih;
                Liste.Rows[i].Cells[5].Value = s.Aciklama;
                Liste.Rows[i].Cells[6].Value = s.GonderimId;
                i++;
            }

            Liste.AllowUserToAddRows = false;
            Liste.AllowUserToDeleteRows = false;
            Liste.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Liste.ReadOnly = true;
        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            if (Secim && gonderimId > 0)
            {
                AnaSayfa.Aktarma = gonderimId;
                Close();

            }

            else if (!Secim && gonderimId > 0)
            {
                KonsinyeGonderim kon = new KonsinyeGonderim();
                kon.MdiParent = Form.ActiveForm;
                kon.StartPosition = FormStartPosition.CenterScreen;
                kon.Show();
                kon.KonsinyeGonderimAc(gonderimId);
            }
        }

        private void Sec()
        {
            if (Liste.CurrentRow != null) gonderimId = Convert.ToInt32(Liste.CurrentRow.Cells[6].Value);
            else gonderimId = -1;
        }

        private void txtGirisAra_TextChanged(object sender, EventArgs e)
        {
            Listele();
        }

        private void BtnGonderimBul_Click(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
