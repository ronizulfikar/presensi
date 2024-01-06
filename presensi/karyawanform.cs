using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static presensi.Form1;

namespace presensi
{
    public partial class karyawanform : Form
    {
        private DatabaseConnector databaseconnector;
        public karyawanform(DatabaseConnector dbconnector)
        {
            InitializeComponent();
            databaseconnector = dbconnector;
            DisplayPelajarData();
        }
        private void DisplayPelajarData()
        {
            databaseconnector.OpenConnection();

            try
            {
                // Gunakan query SELECT untuk mendapatkan data dari tabel pelajar
                string query = "SELECT nama, kelas, kelompok_belajar, keterangan FROM pelajar";
                MySqlCommand command = new MySqlCommand(query, databaseconnector.Connection);

                // Menggunakan MySqlDataAdapter untuk mengisi DataSet dengan hasil query
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                {
                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet);

                    // Mengisi DataGridView dengan data dari DataSet
                    tabelketeranganpelajar.DataSource = dataSet.Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                databaseconnector.CloseConnection();
            }
        }
        private void karyawanform_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();

        }
    }
}
