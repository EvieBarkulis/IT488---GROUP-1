using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT488_Group1_Project
{
    public partial class Order_Menu : Form
    {
        public Order_Menu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var myForm = new TableOrderForm();
            myForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var myForm = new Quilt_Order_Form();
            myForm.Show();
        }
    }
}
