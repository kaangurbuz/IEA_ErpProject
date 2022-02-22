﻿using System;
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

namespace IEA_ErpProject.BilgiGiris.Firmalar
{
    public partial class FirmaDetayGoster : Form
    {
        public string FAdi = "";
        private readonly ErpProject102SEntities _db = new ErpProject102SEntities();

        public FirmaDetayGoster()
        {
            InitializeComponent();
        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FirmaDetayGoster_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            Liste.Rows.Clear();
            int i = 0;
            var frmDetayList =
                (from s in _db.tblFirmaDetaylar  where s.tblFirmalar.Adi == FAdi select s).ToList();

            foreach (var item in frmDetayList)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = i + 1;
                Liste.Rows[i].Cells[1].Value = item.YetkiliAdi;
                Liste.Rows[i].Cells[2].Value = item.tblDepartmanlar.Adi;
                Liste.Rows[i].Cells[3].Value = item.Tel;
                Liste.Rows[i].Cells[4].Value = item.Gsm;
                Liste.Rows[i].Cells[5].Value = item.Email;
                i++;

            }
            Liste.AllowUserToAddRows = false; // kullanicinin satir eklemesini engeller
            Liste.AllowUserToDeleteRows = false; // kullanici kayit silemesin
            Liste.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Liste.ReadOnly = true;
        }

       
    }
}
