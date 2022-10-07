using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace IT488_Group1_Project
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }

        public void login_button_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Integrated security=true; Initial Catalog=MWC_CustomOrder; Data source = MJ0E1DP0\\MSSQLSERVER01");
            sqlConnection.Open();
            string query = "Select * from customer Where Email = @email and Password = @password";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlConnection;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;

            cmd.Parameters.AddWithValue("@Email", textBox_email2.Text.Trim());
            cmd.Parameters.AddWithValue("@Password", textBox_password2.Text.Trim());

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read() == true)
            {
                this.Hide();
                var myForm = new Order_Menu();
                myForm.Show();
            }
            else
            {
                MessageBox.Show("Email or/and Password is/are invalid. Please try again");
            }
        }
    }
}
