using System;
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
    public partial class FormFrontPanel : Form
    {
        public FormFrontPanel()
        {
            InitializeComponent();
        }

        private void btnPembelian_Click(object sender, EventArgs e)
        {
            if (cBoxNamaPegawai.SelectedIndex = )
            {

            }
            Form formbeli = new FormLoadPembelian();
            formbeli.Show();
            this.Visible = false;
        }

        private void btnPenjualan_Click(object sender, EventArgs e)
        {
            Form formjual = new FormLoadPenjualan();
            formjual.Show();
            this.Visible = false;

        }

        private void btnDataBaru_Click(object sender, EventArgs e)
        {
            Form formjual = new FormLoadPenjualan();
            formjual.Show();
            this.Visible = false;
        }
    }

}
