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
    public partial class FormLoadPembelian : Form
    {
        public FormLoadPembelian()
        {
            InitializeComponent();
        }

        static string connectionString = "server=139.255.11.84;uid=student;pwd=isbmantap;database=DBD_04_TOKOSEPATU;";
        public MySqlConnection sqlConnect = new MySqlConnection(connectionString);
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        public string sqlQuery;

        DataTable Supplier = new DataTable();
        DataTable Sepatu = new DataTable();
        private void FormLoadPembelian_Load(object sender, EventArgs e)
        {
            sqlQuery = "select ID_SUPPLIER, NAMA_SUPPLIER FROM SUPPLIER;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(Supplier);
            cBoxSupplier.DataSource = Supplier;
            cBoxSupplier.DisplayMember = "NAMA_SUPPLIER";
            cBoxSupplier.ValueMember = "ID_SUPPLIER";

            sqlQuery = "select ID_SEPATU, STOCK_SEPATU, HARGA_PENJUALAN FROM SEPATU;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(Sepatu);
            cBoxIDSepatu.DataSource = Sepatu;

            cBoxIDSepatu.DisplayMember = "ID_SEPATU";
            cBoxIDSepatu.ValueMember = "ID_SEPATU";
        }

        private void numQuantity_ValueChanged(object sender, EventArgs e)
        {
            int posisiIndex = cBoxIDSepatu.SelectedIndex;
            lblHargaSatuan.Text = Sepatu.Rows[posisiIndex]["HARGA_PENJUALAN"].ToString();

            int HarjaJual = Convert.ToInt32(lblHargaSatuan.Text);
            int Quantity = Convert.ToInt32(numQuantity.Value);
            int TotalJual = HarjaJual * Quantity;
            lblTotalHarga.Text = TotalJual.ToString();

        }
    }
}
