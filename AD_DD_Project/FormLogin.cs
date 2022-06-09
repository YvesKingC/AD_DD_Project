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

        static string connectionString = "server=139.255.11.84;uid=student;pwd=isbmantap;database=DBD_04_TOKOSEPATU;";
        public MySqlConnection sqlConnect = new MySqlConnection(connectionString);
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        public string sqlQuery;

        DataTable Login = new DataTable();
        DataTable dtUID = new DataTable();

        public static string statusPegawai;
        public static string namaPegawai;
        public static string UID = "";
        public static string PASS = "";

        private void FormLogin_Load(object sender, EventArgs e)
        {
            tBoxPass.UseSystemPasswordChar = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            sqlConnect.Open();
            sqlQuery = "SELECT * FROM PEGAWAI WHERE ID_PEGAWAI = '" + tBoxUID.Text + "' and PASSWORD_LOGIN = '" + tBoxPass.Text + "';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(Login);

            if (Login.Rows.Count > 0)
            {
                namaPegawai = Login.Rows[0][2].ToString();
                statusPegawai = Login.Rows[0][7].ToString();
                Form formfrontpanel1 = new FormFrontPanel();
                formfrontpanel1.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("User / Password Salah");
            }
        }

        private void cBoxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxShowPass.Checked == true)
            {
                tBoxPass.UseSystemPasswordChar = false;
            }
            else
            {
                tBoxPass.UseSystemPasswordChar = true;
            }
        }
    }
}
