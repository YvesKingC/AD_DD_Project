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
    public partial class FormHistoryPembelian : Form
    {
        public FormHistoryPembelian()
        {
            InitializeComponent();
        }

        static string connectionString = "server=139.255.11.84;uid=student;pwd=isbmantap;database=DBD_04_TOKOSEPATU;";
        public MySqlConnection sqlConnect = new MySqlConnection(connectionString);
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        public string sqlQuery;

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form formback = new FormLoadPembelian();
            formback.Show();
            this.Visible = false;
        }
        private void FormHistoryPembelian_Load(object sender, EventArgs e)
        {
            sqlQuery = "SELECT N.ID_NOTA_PEMBELIAN, N.ID_SUPPLIER, N.ID_PEGAWAI, N.TGL_PEMBELIAN, D.QTY_PEMBELIAN, D.HARGA_PEMBELIAN, N.TOTAL_HARGA_PEMBELIAN, N.STATUS_PEMBELIAN FROM NOTA_PEMBELIAN N, DETAIL_PEMBELIAN D WHERE N.ID_NOTA_PEMBELIAN = D.ID_NOTA_PEMBELIAN GROUP BY ID_NOTA_PEMBELIAN ORDER BY 1;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);

            DataTable dgw = new DataTable();
            sqlAdapter.Fill(dgw);
            dgwHistoryPembelian.DataSource = dgw;
        }
    }
}
