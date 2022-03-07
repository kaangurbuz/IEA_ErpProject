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

namespace IEA_ErpProject.BilgiGiris.Urunler
{
    public partial class UrunKayitListesi : Form
    {
        private ErpProject102SEntities _db = new ErpProject102SEntities();
        public bool Secim = false;
        private int secimUId = -1;
        public UrunKayitListesi()
        {
            InitializeComponent();
        }

        private void UrunKayitListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            Liste.Rows.Clear();
            int i = 0;
            var lst = (from s in _db.tblUrunKayitUst
                      where s.UrunKodu.Contains(txtUrunAra.Text) || s.tblFirmalar.Adi.Contains(txtUrunAra.Text)
                      select s).ToList();
            foreach (var s in lst)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = i + 1;
                Liste.Rows[i].Cells[1].Value = s.Id;
                if (s.tblFirmalar != null) Liste.Rows[i].Cells[2].Value = s.tblFirmalar.Adi;
                Liste.Rows[i].Cells[3].Value = s.UrunKodu;
                Liste.Rows[i].Cells[4].Value = s.AciklamaTr;
                Liste.Rows[i].Cells[5].Value = s.UId;
                i++;
            }

            Liste.AllowUserToAddRows = false;
            Liste.AllowUserToDeleteRows = false;
            Liste.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Liste.ReadOnly = true;
        }

        private void txtUrunAra_TextChanged(object sender, EventArgs e)
        {
            Listele();
        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            if (Secim&&secimUId>0)
            {
                AnaSayfa.Aktarma = secimUId;
                Close();
                
            }

            else if (!Secim && secimUId > 0)
            {
                UrunKayit urn = new UrunKayit();
                urn.MdiParent = Form.ActiveForm;
                urn.StartPosition = FormStartPosition.CenterScreen;
                urn.Show();
                urn.UrunAc(secimUId);
            }
        }

        private void Sec()
        {
            if (Liste.CurrentRow != null) secimUId = Convert.ToInt32(Liste.CurrentRow.Cells[5].Value);
            else secimUId = -1;
        }
    }
}
