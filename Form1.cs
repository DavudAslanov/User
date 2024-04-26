using System.Data.SqlClient;

namespace User
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SqlConnectionStringBuilder sqlConnectionString = new SqlConnectionStringBuilder();
            //sqlConnectionString.InitialCatalog = "UserDB";
            //sqlConnectionString.DataSource = "Localhost";
            //sqlConnectionString.IntegratedSecurity = true;
            //string sqlconnection = sqlConnectionString.ConnectionString;
            string sqlconnection = DataBase.ConnectionDatabase("Localhost", "UserDB", true);

            using (SqlConnection connection = new SqlConnection(sqlconnection))
            {
                connection.Open();
                string script = @"Select * from Users Where Name=@user and  Passwords=@password;";

                using (SqlCommand command = new SqlCommand(script, connection))
                {
                    if(user.Text=="admin" && pass.Text == "admin")
                    {
                        AdminPanel adminPanel = new AdminPanel();
                        adminPanel.Show();
                        this.Hide();
                    }
                    command.Parameters.AddWithValue("@user",user.Text);
                    command.Parameters.AddWithValue("@password",pass.Text);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Giris edildi:");
                };
            };

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SignUP signUP = new SignUP();
            signUP.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
