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
    public partial class FormFrontPanelAtasan : Form
    {
        public FormFrontPanelAtasan()
        {
            InitializeComponent();
        }

        static string connectionString = "server=139.255.11.84;uid=student;pwd=isbmantap;database=DBD_04_TOKOSEPATU;";
        public MySqlConnection sqlConnect = new MySqlConnection(connectionString);
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        public string sqlQuery;

        private void FormFrontPanel_Load(object sender, EventArgs e)
        {
            DataTable NamaPegawai = new DataTable();
            
            sqlQuery = "select  ID_PEGAWAI, NAMA_PEGAWAI, LVL_PEGAWAI from PEGAWAI";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(NamaPegawai);
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

        
    }

}
