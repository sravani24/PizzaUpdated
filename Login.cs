using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pizza
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void CustBtn_Click(object sender, EventArgs e)
        {
            Order obj = new Order();
            obj.Show();
            this.Hide();
        }

        private void AdminBtn_Click(object sender, EventArgs e)
        {
            Admin obj = new Admin();
            obj.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Adam" && textBox2.Text == "Adam")
            {
                Order obj = new Order();
                obj.Show();
                this.Hide();
            }
            else if (textBox1.Text == "Admin" && textBox2.Text == "Admin")
            {
                Admin obj = new Admin();
                obj.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Invalid Credentials");
            }
        }
    }
}
