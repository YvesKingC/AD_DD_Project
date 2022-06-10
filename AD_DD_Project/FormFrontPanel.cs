using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AD_DD_Project
{
    public partial class FormFrontPanel : Form
    {
        public FormFrontPanel()
        {
            InitializeComponent();
        }

        static string connectionString = "server=139.255.11.84;uid=student;pwd=isbmantap;database=DBD_04_TOKOSEPATU;";
        public MySqlConnection sqlConnect = new MySqlConnection(connectionString);
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        public string sqlQuery;
        DataTable Login = new DataTable();


        private void FormFrontPanel_Load(object sender, EventArgs e)
        {
           lblWellcome.Text = "Wellcome " + FormLogin.namaPegawai;
            if (FormLogin.statusPegawai == "Direktur Utama" || FormLogin.statusPegawai == "Manajer" || FormLogin.statusPegawai == "Admin")
            {
                btnPembelian.Enabled = true;
                btnDataBaru.Enabled = true;
            }
            else if (FormLogin.statusPegawai == "Sales")
            {
                btnPembelian.Enabled = false;
                btnDataBaru.Enabled = false;
            }
            else
            {
                btnPembelian.Enabled = false;
                btnPenjualan.Enabled = false;
                btnDataBaru.Enabled = false;
            }

        }

        private void btnPembelian_Click(object sender, EventArgs e)
        {
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
            Form formjual = new FormInputDataBaru();
            formjual.Show();
            this.Visible = false;
        }

        private void btnHapusData_Click(object sender, EventArgs e)
        {
            Form formhapus = new FormCekStock();
            formhapus.Show();
            this.Visible = false;
        }
    }
}
