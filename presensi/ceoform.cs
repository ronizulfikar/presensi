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
using MySql.Data.MySqlClient;
using static presensi.Form1;

namespace presensi
{
    public partial class ceoform : Form
    {
        private DatabaseConnector databaseconnector;
        public ceoform(DatabaseConnector dbconnector)
        {
            InitializeComponent();
            databaseconnector = dbconnector;
            DisplayPelajarData();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nama = txtnama.Text;
            string kelas = txtkelas.Text;
            string kelompokBelajar = txtkelompokbelajar.Text;
            string keterangan = txtketerangan.Text;

            // Simpan data absensi ke tabel "pelajar"
            if (SaveAttendanceData(nama, kelas, kelompokBelajar, keterangan))
            {
                MessageBox.Show("Data berhasil disimpan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInputFields();
                DisplayPelajarData();
            }
            else
            {
                MessageBox.Show("Gagal menyimpan data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearInputFields()
        {
            txtnama.Text = "";
            txtkelas.Text = "";
            txtkelompokbelajar.Text = "";
            txtketerangan.Text = "";
        }
        private bool SaveAttendanceData(string nama, string kelas, string kelompokBelajar, string keterangan)
        {
            databaseconnector.OpenConnection();

            try
            {
                // Gunakan parameterized query untuk mencegah SQL injection
                string query = "INSERT INTO pelajar (nama, kelas, kelompok_belajar, keterangan) VALUES (@nama, @kelas, @kelompokBelajar, @keterangan)";
                MySqlCommand command = new MySqlCommand(query, databaseconnector.Connection);
                command.Parameters.AddWithValue("@nama", nama);
                command.Parameters.AddWithValue("@kelas", kelas);
                command.Parameters.AddWithValue("@kelompokBelajar", kelompokBelajar);
                command.Parameters.AddWithValue("@keterangan", keterangan);

                int rowsAffected = command.ExecuteNonQuery();

                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                databaseconnector.CloseConnection();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtnama.Text = "";
            txtkelas.Text = "";
            txtkelompokbelajar.Text = "";
            txtketerangan.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtkelompokbelajar_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ExportToCSV();
        }
        private void ExportToCSV()
        {
            try
            {
                // Dialog penyimpanan file
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "CSV files (*.csv)|*.csv";
                saveFileDialog.Title = "Save CSV File";
                saveFileDialog.FileName = "pelajar_data.csv";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Membuat objek StreamWriter untuk menulis ke file CSV
                    using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName, false, Encoding.UTF8))
                    {
                        // Menulis header kolom
                        for (int i = 0; i < tabelketeranganpelajar.Columns.Count; i++)
                        {
                            sw.Write(tabelketeranganpelajar.Columns[i].HeaderText);
                            if (i < tabelketeranganpelajar.Columns.Count - 1)
                                sw.Write(",");
                        }
                        sw.WriteLine();

                        // Menulis data
                        for (int i = 0; i < tabelketeranganpelajar.Rows.Count; i++)
                        {
                            for (int j = 0; j < tabelketeranganpelajar.Columns.Count; j++)
                            {
                                sw.Write(tabelketeranganpelajar.Rows[i].Cells[j].Value);
                                if (j < tabelketeranganpelajar.Columns.Count - 1)
                                    sw.Write(",");
                            }
                            sw.WriteLine();
                        }

                        MessageBox.Show("Data berhasil diekspor ke file CSV.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
        private void ceoform_Load(object sender, EventArgs e)
        {

        }
    }
}
