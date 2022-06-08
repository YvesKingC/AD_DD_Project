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
    public partial class FormLogin : Form
    {
        public FormLogin()
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
        DataTable dtUID = new DataTable();

        public static string NAMALOGIN = "";
        public static string UID = "";
        public static string PASS = "";

        private void FormLogin_Load(object sender, EventArgs e)
        {
            sqlConnect.Open();
            sqlQuery = "select NAMA_PEGAWAI AS 'NAMA', ID_PEGAWAI AS 'UID', PASSWORD_LOGIN AS 'PASS' FROM PEGAWAI";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(Login);
            cBoxUID.DataSource = Login;
            cBoxUID.DisplayMember = "UID";
            cBoxUID.ValueMember = "UID";
            sqlConnect.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            sqlConnect.Open();
            index = cBoxUID.SelectedIndex;
            sqlQuery = "select NAMA_PEGAWAI AS 'NAMA', ID_PEGAWAI AS 'UID', PASSWORD_LOGIN AS 'PASS' FROM PEGAWAI WHERE LVL_PEGAWAI = 'Direktur Utama' or LVL_PEGAWAI = 'Manajer' or LVL_PEGAWAI = 'Admin' and ID_PEGAWAI = '" + cBoxUID.SelectedText + "' and PASSWORD_LOGIN = '" + tBoxPass.Text + "'";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(Login);
            MySqlDataReader reader = sqlCommand.ExecuteReader();
            lblNama.Text = Login.Rows[index][0].ToString();

            lblNama.Visible = false;
            NAMALOGIN = lblNama.Text;
            UID =  cBoxUID.Text;
            PASS = tBoxPass.Text;

            if (reader.Read())
            {
                Form formfrontpanel1 = new FormFrontPanel();
                formfrontpanel1.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Mohon periksa kembali UID dan Pass anda");
            }
        }
    }
}
