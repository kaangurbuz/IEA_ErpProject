﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IEA_ErpProject.Entity;

namespace IEA_ErpProject.UrunGiris.Urunler
{
    public partial class UrunlerGirisListesi : Form
    {
        private readonly ErpProject102SEntities _db = new ErpProject102SEntities();
        public bool Secim = false;
        private int secimId = -1;

        public UrunlerGirisListesi()
        {
            InitializeComponent();
        }

        private void UrunlerGirisListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            Liste.Rows.Clear();
            int i = 0;
            var lst = (from s in _db.tblUrunGirisUst where s.CariTip.Contains( txtGirisAra.Text) ||s.CariAdi.Contains(txtGirisAra.Text)||s.FaturaNo.Contains(txtGirisAra.Text) select s);
            foreach (var s in lst)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = i+1;
                Liste.Rows[i].Cells[1].Value = s.Id;
                Liste.Rows[i].Cells[2].Value = s.CariTip;
                Liste.Rows[i].Cells[3].Value = s.CariAdi;
                Liste.Rows[i].Cells[4].Value = s.FaturaNo;
                Liste.Rows[i].Cells[5].Value = s.GirisTarih;
                Liste.Rows[i].Cells[6].Value = s.Aciklama;
                Liste.Rows[i].Cells[7].Value = s.GirisId;
                i++;
            }

            Liste.AllowUserToAddRows = false;
            Liste.AllowUserToDeleteRows = false;
            Liste.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Liste.ReadOnly = true;

        }

        private void txtGirisAra_TextChanged(object sender, EventArgs e)
        {
            Listele();
        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            if (Secim && secimId > 0)
            {
                AnaSayfa.Aktarma = secimId;
                Close();

            }

            else if (!Secim && secimId > 0)
            {
                UrunGiris urn = new UrunGiris();
                urn.MdiParent = Form.ActiveForm;
                urn.StartPosition = FormStartPosition.CenterScreen;
                urn.Show();
                urn.UrunAc(secimId);
            }
        }

        private void Sec()
        {
            if (Liste.CurrentRow != null) secimId = Convert.ToInt32(Liste.CurrentRow.Cells[7].Value);
            else secimId = -1;
        }
    }
}
