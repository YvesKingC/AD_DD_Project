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
        DataTable dtSepatuYangDibeli = new DataTable();
        DataTable masukdatabase = new DataTable();

        public static int indexidnotasekarang = 0;
        public static string lunas;
        public static string belumLunas;
        public static string supplier;
        public static string hargasatuan;
        public static string hargatotal;

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

            hargasatuan = lblHargaSatuan.Text;
            hargatotal = lblTotalHarga.Text;

        }

        private void btnCetak_Click(object sender, EventArgs e)
        {
            sqlQuery = "SELECT ID_SEPATU, STOCK_SEPATU FROM SEPATU WHERE ID_SEPATU = '" + cBoxIDSepatu.SelectedValue.ToString() + "'";
            sqlCommand =   new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtSepatuYangDibeli);
            int stokSekarang = Convert.ToInt16(dtSepatuYangDibeli.Rows[0][1]);
            int totalStok = stokSekarang + Convert.ToInt16(numQuantity.Value);

            sqlConnect.Open();
            sqlQuery = "UPDATE SEPATU SET STOCK_SEPATU = " + totalStok.ToString() + " WHERE ID_SEPATU = '"+cBoxIDSepatu.SelectedValue.ToString()+"' ";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();


            //BUAT DATA TABLE BARU UNTUK MENGISI HISTORY PEMBELIAN DAN DATA TABLE BARU UNTUK HISTORY PENJUALAN.
            sqlQuery = "select ID_NOTA_PEMBELIAN, ID_SUPPLIER, ID_PEGAWAI, TGL_PEMBELIAN,TOTAL_HARGA_PEMBELIAN,STATUS_PEMBELIAN from NOTA_PEMBELIAN;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(masukdatabase);
            indexidnotasekarang = masukdatabase.Rows.Count - 1;
            int index = indexidnotasekarang;
            int idnotabelisekarang = Convert.ToInt32(masukdatabase.Rows[index][0]) + 1;
            string idnotabelitambah = "NB00" + idnotabelisekarang.ToString();

            sqlConnect.Open();
            sqlQuery = "insert into NOTA_PEMBELIAN (ID_NOTA_PEMBELIAN, ID_SUPPLIER, ID_PEGAWAI, TGL_PEMBELIAN,TOTAL_HARGA_PEMBELIAN,STATUS_PEMBELIAN) VALUES ('"+ idnotabelitambah +"','','','','','')";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlCommand.ExecuteNonQuery();
            supplier = cBoxSupplier.Text;

            if (rBtnLunas.Checked)
            {
                lunas = "Lunas";
            }
            else if (rBtnBelumLunas.Checked)
            {
                belumLunas = "Belum Lunas";
            }

            Form formcetaknota = new FormNotaPembelian();
            formcetaknota.Show();
            this.Visible = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form formback = new FormFrontPanel();
            formback.Show();
            this.Visible = false;
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            Form formhistory = new FormHistoryPembelian();
            formhistory.Show();
            this.Visible = false;
        }
    }
}
