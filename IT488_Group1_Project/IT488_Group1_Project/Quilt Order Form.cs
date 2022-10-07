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
    public partial class Quilt_Order_Form : Form
    {
        public Quilt_Order_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Guid myNewId = Guid.NewGuid();

            SqlConnection con = new SqlConnection("Integrated security=true; Initial Catalog=MWC_CustomOrder; Data source = MJ0E1DP0\\MSSQLSERVER01");
            SqlCommand cmd;
            con.Open();
            string s = "insert into quiltOrders values (@quiltOrderID, @email, @quiltOrderType, @quiltOrderSize, @quiltOrderFabric, @quiltOrderDesign, @quiltOrderFiller, @quiltOrderBacking)";
            cmd = new SqlCommand(s, con);
            cmd.Parameters.AddWithValue("@quiltOrderID", myNewId);
            cmd.Parameters.AddWithValue("@email", textBox_email.Text);
            cmd.Parameters.AddWithValue("@quiltOrderType", comboBox_type.Text);
            cmd.Parameters.AddWithValue("@quiltOrderSize", comboBox_size.Text);
            cmd.Parameters.AddWithValue("@quiltOrderFabric", comboBox_fabric.Text);
            cmd.Parameters.AddWithValue("@quiltOrderDesign", comboBox_design.Text);
            cmd.Parameters.AddWithValue("@quiltOrderFiller", comboBox_filler.Text);
            cmd.Parameters.AddWithValue("@quiltOrderBacking", comboBox_backing.Text);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Your Order has been submitted! We will email you shortly with a confirmation number.");
            this.Close();
        }
    }
}
