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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            sqlConnect.Open();

            sqlQuery = "select ID_PEGAWAI AS 'UID', PASSWORD_LOGIN AS 'PASS' FROM PEGAWAI WHERE ID_PEGAWAI = '" + tBoxUID.Text + "' and PASSWORD_LOGIN = '" + tBoxPass.Text + "'";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            MySqlDataReader reader = sqlCommand.ExecuteReader();

            if (reader.Read())
            {
                sqlConnect.Close();
                sqlConnect.Open();
                sqlQuery = "select NAMA_PEGAWAI as 'NAMA PEGAWAI', ID_PEGAWAI AS 'UID',LVL_PEGAWAI AS 'JABATAN', PASSWORD_LOGIN AS 'PASS' FROM PEGAWAI WHERE LVL_PEGAWAI = 'Admin' OR LVL_PEGAWAI = 'Manajer' OR LVL_PEGAWAI = 'Direktur Utama';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                MySqlDataReader reader2 = sqlCommand.ExecuteReader();
                if (reader2.Read())
                {
                    Form formfrontpanel1 = new FormFrontPanelAtasan();
                    formfrontpanel1.Show();
                    this.Visible = false;
                }
                else
                {
                    Form formfrontpanel2 = new FormFrontPanelBiasa();
                    formfrontpanel2.Show();
                    this.Visible = false;
                }
                
            }
            else
            {
                MessageBox.Show("Mohon periksa kembali UID dan Pass anda");
            }
        }
    }
}
