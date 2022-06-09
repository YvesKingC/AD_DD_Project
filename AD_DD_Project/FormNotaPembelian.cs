﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AD_DD_Project
{
    public partial class FormNotaPembelian : Form
    {
        public FormNotaPembelian()
        {
            InitializeComponent();
        }

        private void FormNotaPembelian_Load(object sender, EventArgs e)
        {
            lblTanggalPembelian.Text = "Tanggal : " + DateTime.Now.ToString();
            lblSupplier.Text = FormLoadPembelian.supplier;
            lblPemesan.Text = FormLogin.namaPegawai;
            lblHargaSatuan.Text = FormLoadPembelian.hargasatuan;
            lblTotalHarga.Text = FormLoadPembelian.hargatotal;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Form formback = new FormFrontPanel();
            formback.Show();
            this.Visible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
