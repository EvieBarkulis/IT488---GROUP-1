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
    public partial class TableOrderForm : Form
    {
        public TableOrderForm()
        {
            InitializeComponent();
        }

        private void TableOrderForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Guid myNewId = Guid.NewGuid();

            SqlConnection con = new SqlConnection("Integrated security=true; Initial Catalog=MWC_CustomOrder; Data source = MJ0E1DP0\\MSSQLSERVER01");
            SqlCommand cmd;
            con.Open();
            string s = "insert into tableOrders values (@tableOrderID, @email, @tableOrderType, @tableOrderFinish, @tableOrderWood, @tableOrderThickness, @tableOrderDesign)";
            cmd = new SqlCommand(s, con);
            cmd.Parameters.AddWithValue("@tableOrderID", myNewId);
            cmd.Parameters.AddWithValue("@email", textBox_email.Text);
            cmd.Parameters.AddWithValue("@tableOrderType", comboBox_type.Text);
            cmd.Parameters.AddWithValue("@tableOrderFinish", comboBox_finish.Text);
            cmd.Parameters.AddWithValue("@tableOrderWood", comboBox_wood.Text);
            cmd.Parameters.AddWithValue("@tableOrderThickness", comboBox_thickness.Text);
            cmd.Parameters.AddWithValue("@tableOrderDesign", textBox_design.Text);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Your Order has been submitted! We will email you shortly with a confirmation number.");
            this.Close();
        }
    }
}
