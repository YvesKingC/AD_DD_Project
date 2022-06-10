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
    public partial class FormInputDataBaru : Form
    {
        public FormInputDataBaru()
        {
            InitializeComponent();
        }

        private void btnToko_Click(object sender, EventArgs e)
        {
            Form formtoko = new FormInputTokoBaru();
            formtoko.Show();
            this.Visible = false;
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            Form formsupplier = new FormInputSupplierBaru();
            formsupplier.Show();
            this.Visible = false;
        }

        private void btnPegawai_Click(object sender, EventArgs e)
        {
            Form formpegawai = new FormInputPegawaiBaru();
            formpegawai.Show();
            this.Visible = false;
        }

        private void btnSepatu_Click(object sender, EventArgs e)
        {
            Form formsepatu = new FormInputSepatuBaru();
            formsepatu.Show();
            this.Visible = false;
        }

        private void btnMember_Click(object sender, EventArgs e)
        {
            Form formmember = new FormInputMemberBaru();
            formmember.Show();
            this.Visible = false;
        }

        private void btnPromo_Click(object sender, EventArgs e)
        {
            Form formpromo = new FormInputMemberBaru();
            formpromo.Show();
            this.Visible = false;
        }
    }
}
