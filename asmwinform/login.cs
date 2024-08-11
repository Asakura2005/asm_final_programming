using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asmwinform
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = tbName.Text;
            string password = tbPass.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter username and password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (username == "admin" && password == "strong_password")
            {
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username or password is incorrect!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
