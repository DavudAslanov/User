using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace User
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            FillTable();
        }

        private void FillTable()
        {
            string sqlconnection = DataBase.ConnectionDatabase("Localhost", "UserDB", true);

            using (SqlConnection conn = new SqlConnection(sqlconnection))
            {
                conn.Open();
                string script = @"Select * From Users";
                using (SqlCommand cmd = new SqlCommand(script, conn))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
        }

        private void AdminPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sqlconnection = DataBase.ConnectionDatabase("Localhost", "UserDB", true);

            using (SqlConnection connection = new SqlConnection(sqlconnection))
            {
                connection.Open();
                string script = @"Insert Into  Users(Name,Surname,Email,Passwords,Age)
                                    Values(@name,@surname,@email,@password,@age)";
                if (name.Text != string.Empty && surname.Text != string.Empty && email.Text != string.Empty && password.Text != string.Empty && age.Text != string.Empty)
                {
                    using (SqlCommand command = new SqlCommand(script, connection))
                    {
                        command.Parameters.AddWithValue("@name", name.Text);
                        command.Parameters.AddWithValue("@surname", surname.Text);
                        command.Parameters.AddWithValue("@email", email.Text);
                        command.Parameters.AddWithValue("@password", password.Text);
                        command.Parameters.AddWithValue("@age", int.Parse(age.Text));
                        command.ExecuteNonQuery();
                        MessageBox.Show("Istifadeci Elave olundu", "Bildiris", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FillTable();
                    };
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string sqlconnection = DataBase.ConnectionDatabase("Localhost", "UserDB", true);

            using (SqlConnection connection = new SqlConnection(sqlconnection))
            {
                connection.Open();
                string script = @"Select * From Users Name=@name";
                using (SqlCommand command = new SqlCommand(script, connection))
                {
                    command.Parameters.AddWithValue("@name", name.Text);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        name.Text = reader.GetString(1);
                        surname.Text = reader.GetString(2);
                        email.Text = reader.GetString(3);
                        password.Text = reader.GetString(4);
                        age.Text = reader.GetString(5);
                    }
                    FillTable();
                }
            }
        }
    }
}
