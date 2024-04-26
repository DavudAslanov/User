using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace User
{
    public partial class SignUP : Form
    {
        public SignUP()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string sqlconnection = DataBase.ConnectionDatabase("Localhost", "UserDB", true);

            using (SqlConnection connection = new SqlConnection(sqlconnection))
            {
                connection.Open();
                string script = @"Insert Into  Users(Name,Surname,Email,Passwords,Age)
                                    Values(@name,@surname,@email,@password,@age)";

                using (SqlCommand command = new SqlCommand(script, connection))
                {
                    command.Parameters.AddWithValue("@name", name.Text);
                    command.Parameters.AddWithValue("@surname", surname.Text);
                    command.Parameters.AddWithValue("@email", email.Text);
                    command.Parameters.AddWithValue("@password", password.Text);
                    command.Parameters.AddWithValue("@age", int.Parse(age.Text));
                    command.ExecuteNonQuery();
                    MessageBox.Show("Istifadeci Elave olundu", "Bildiris", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form1 form1 = new Form1();
                    form1.Show();
                    this.Hide();
                };
            }
        }

        private void SignUP_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
