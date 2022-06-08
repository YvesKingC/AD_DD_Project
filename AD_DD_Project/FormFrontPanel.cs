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

        int index = 0;

        static string connectionString = "server=139.255.11.84;uid=student;pwd=isbmantap;database=DBD_04_TOKOSEPATU;";
        public MySqlConnection sqlConnect = new MySqlConnection(connectionString);
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        public string sqlQuery;
        DataTable Login = new DataTable();


        private void FormFrontPanel_Load(object sender, EventArgs e)
        {
            string ID = FormLogin.UID;
            string PAS = FormLogin.PASS;

            sqlConnect.Open();
            sqlQuery = "select NAMA_PEGAWAI AS 'NAMA', ID_PEGAWAI AS 'UID', PASSWORD_LOGIN AS 'PASS' FROM PEGAWAI WHERE LVL_PEGAWAI = 'Direktur Utama' or LVL_PEGAWAI = 'Manajer' or LVL_PEGAWAI = 'Admin' and ID_PEGAWAI = '" + ID + "'";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            MySqlDataReader reader = sqlCommand.ExecuteReader();
            if (reader.Read())
            {
                btnPembelian.Enabled = true;
            }
            sqlConnect.Close();
            sqlConnect.Open();

            sqlQuery = "select NAMA_PEGAWAI AS 'NAMA', ID_PEGAWAI AS 'UID', PASSWORD_LOGIN AS 'PASS' FROM PEGAWAI WHERE LVL_PEGAWAI = 'Pegawai' and ID_PEGAWAI = '" + ID + "'";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            MySqlDataReader reader2 = sqlCommand.ExecuteReader();

            if (reader2.Read())
            {
                btnPembelian.Enabled = false;
            }
            lblWellcome.Text = "Wellcome " + FormLogin.NAMALOGIN;
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
            Form formjual = new FormLoadPenjualan();
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
