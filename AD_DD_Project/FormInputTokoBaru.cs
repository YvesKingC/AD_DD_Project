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
    public partial class FormInputTokoBaru : Form
    {
        public FormInputTokoBaru()
        {
            InitializeComponent();
        }

        static string connectionString = "server=139.255.11.84;uid=student;pwd=isbmantap;database=DBD_04_TOKOSEPATU;";
        public MySqlConnection sqlConnect = new MySqlConnection(connectionString);
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        public string sqlQuery;

        private void FormInputTokoBaru_Load(object sender, EventArgs e)
        {
            sqlQuery = "SELECT * FROM TOKO;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);

            DataTable dgw = new DataTable();
            sqlAdapter.Fill(dgw);
            dgwDataToko.DataSource = dgw;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form formback = new FormFrontPanel();
            formback.Show();
            this.Visible = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            sqlConnect.Open();
            sqlQuery = "insert INTO TOKO (ID_TOKO, LOKASI_TOKO, TELP_TOKO) values ('"+ tBoxIDtokoBaru.Text +"','"+ tBoxAlamat.Text +"','"+ tBoxNoTelp.Text +"');";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();
        }
    }
}
