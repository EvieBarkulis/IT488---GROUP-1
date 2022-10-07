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
    public partial class WelcomeScreen : Form
    {
        public void hidePanels()
        {
            panel1.Visible = false;
            panel2.Visible = false;
 
        }
            
        public WelcomeScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hidePanels();
            panel1.Visible = false;
            panel2.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            hidePanels();
            panel1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var myForm = new NewCustomer();
            myForm.Show();
        }

        private void returningcustomer_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            var myForm = new Login();
            myForm.Show();

        }
    }
}
