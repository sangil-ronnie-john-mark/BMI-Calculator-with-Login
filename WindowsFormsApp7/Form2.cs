using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp7.Properties;

namespace WindowsFormsApp7
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void LOGIN_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == Resources.username && txtPassword.Text == Resources.password) {
                this.Hide();
                Form form1 = new Form1();
                form1.Show();
            } else
            {
                MessageBox.Show("Invalid Username or Password");
            }
        }
    }
}
