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
    public partial class NewCustomer : Form
    {
        SqlConnection con;
        public NewCustomer()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox_address_TextChanged(object sender, EventArgs e)
        {

        }

        private void SignUp_button_Click(object sender, EventArgs e)
        {
            Guid myNewId = Guid.NewGuid();

            SqlConnection con = new SqlConnection("Integrated security=true; Initial Catalog=MWC_CustomOrder; Data source = MJ0E1DP0\\MSSQLSERVER01");
            SqlCommand cmd;
            con.Open();
            string s = "insert into customer values (@customerID, @firstName, @lastName, @phone, @address, @city, @state, @zip, @email, @password)";
            cmd = new SqlCommand(s, con);
            cmd.Parameters.AddWithValue("@customerID", myNewId);
            cmd.Parameters.AddWithValue("@firstName", textBox_FirstName.Text);
            cmd.Parameters.AddWithValue("@lastName", textBox_LastName.Text);
            cmd.Parameters.AddWithValue("@phone", textBox_phoneNumber.Text);
            cmd.Parameters.AddWithValue("@address", textBox_address.Text);
            cmd.Parameters.AddWithValue("@city", textBox_city.Text);
            cmd.Parameters.AddWithValue("@state", comboBox_state.Text);
            cmd.Parameters.AddWithValue("@zip", textBox_zipcode.Text);
            cmd.Parameters.AddWithValue("@email", textBox_email.Text);
            cmd.Parameters.AddWithValue("@password", textBox_password.Text);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Your Account has been created! Please Login to continue.");
            this.Hide();
        }

    }
}
