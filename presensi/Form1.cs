using MySql.Data.MySqlClient;
using static presensi.Form1;

namespace presensi
{
    public partial class Form1 : Form
    {
        private DatabaseConnector databaseconnector;
        public class DatabaseConnector
        {
            private static DatabaseConnector instance;
            private MySqlConnection connection;

            public MySqlConnection Connection
            {
                get { return connection; }
            }

            public DatabaseConnector()
            {
                Initialize();
            }
            public static DatabaseConnector GetInstance()
            {
                if (instance == null)
                {
                    instance = new DatabaseConnector();
                }
                return instance;
            }
            private void Initialize()
            {
                string connectionString = "Server=localhost;Database=absensi;User ID=root;Password=;";

                connection = new MySqlConnection(connectionString);
            }

            public void OpenConnection()
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
            }

            public void CloseConnection()
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
        public Form1()
        {
            InitializeComponent();
            databaseconnector = new DatabaseConnector();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void OpenFormBasedOnUserRole(string userRole)
        {
            if (!string.IsNullOrEmpty(userRole))
            {
                // Tentukan form yang harus dibuka berdasarkan peran pengguna
                Form targetForm = null;

                switch (userRole)
                {
                    case "administrator":
                        targetForm = new ceoform(databaseconnector);
                        break;
                    case "operator":
                        targetForm = new manajerform(databaseconnector);
                        break;
                    case "participant":
                        targetForm = new karyawanform(databaseconnector);
                        break;
                    default:
                        MessageBox.Show("Unknown user role.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }

                // Jika form target ditentukan, buka form tersebut dan sembunyikan form login
                if (targetForm != null)
                {
                    targetForm.Show();
                    this.Hide(); // Menyembunyikan form login atau form sebelumnya
                }
            }
            else
            {
                MessageBox.Show("User role not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string GetUserRole(string username)
        {
            databaseconnector.OpenConnection();

            try
            {
                // Gunakan parameterized query untuk mencegah SQL injection
                string query = "SELECT role FROM users WHERE username = @username";
                MySqlCommand command = new MySqlCommand(query, databaseconnector.Connection);
                command.Parameters.AddWithValue("@username", username);

                object result = command.ExecuteScalar();

                return result != null ? result.ToString() : null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            finally
            {
                databaseconnector.CloseConnection();
            }
        }
        private bool AuthenticateUser(string username, string password)
        {
            databaseconnector.OpenConnection();

            try
            {
                // Gunakan parameterized query untuk mencegah SQL injection
                string query = "SELECT COUNT(*) FROM users WHERE username = @username AND password = @password";
                MySqlCommand command = new MySqlCommand(query, databaseconnector.Connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                int count = Convert.ToInt32(command.ExecuteScalar());

                return count > 0;
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

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text;
            string password = txtpassword.Text;

            // Lakukan otentikasi dengan database MySQL
            if (AuthenticateUser(username, password))
            {
                // Mendapatkan peran pengguna setelah berhasil login
                string userRole = GetUserRole(username);

                // Panggil fungsi untuk membuka form berdasarkan peran pengguna
                OpenFormBasedOnUserRole(userRole);
            }
            else
            {
                MessageBox.Show("Login failed. Please check your credentials.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenKaryawanForm();
        }
        private void OpenKaryawanForm()
        {
            // Buka form karyawan dan sembunyikan form presensi
            karyawanform KaryawanForm = new karyawanform(databaseconnector);
            KaryawanForm.Show();
            this.Hide();
        }
    }
}