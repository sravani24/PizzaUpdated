using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Pizza
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            comboBox1.Items.Clear();
            shared.con = new SqlConnection(ConfigurationManager.ConnectionStrings["PizzaDBConnectionString"].ConnectionString);
            shared.con.Open();
            SqlCommand cmd = new SqlCommand("select Uid from Customer where Status='Pending';", shared.con);
            using (SqlDataReader read = cmd.ExecuteReader())
            {
                while (read.Read())
                {
                    comboBox1.Items.Add(read[0].ToString());
                    listBox1.Items.Add("Order ID " + read[0].ToString());
                }

            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            SqlCommand cmd = new SqlCommand("select * from Customer where Status='Pending';", shared.con);
            using (SqlDataReader read1 = cmd.ExecuteReader())
            {

                if (read1.HasRows)
                {
                    while (read1.Read())
                    {
                       textBox1.Text=  read1[0].ToString() +"\n";
                        textBox2.Text=  read1[1].ToString() + "\n";
                        textBox3.Text=  read1[2].ToString() + "\n";
                        textBox4.Text= read1[3].ToString() + "\n";
                        textBox5.Text=  read1[4].ToString() + "\n";
                        textBox6.Text= read1[5].ToString()+"\n";
                        textBox7.Text= read1[6].ToString()+ "\n";
                        textBox8.Text=  read1[7].ToString() + "\n";    
                        
                    }
                }
            }


            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            SqlCommand c= new SqlCommand("update Customer set Status = 'completed' where Uid="+comboBox1.SelectedItem,shared.con);
            c.ExecuteNonQuery();
            comboBox1.Text = " ";
            comboBox1.Items.Clear();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = ""; textBox4.Text = ""; textBox5.Text = ""; textBox6.Text = ""; textBox7.Text = ""; textBox8.Text = "";
            listBox1.Items.Clear();
            MessageBox.Show("status updated");
        }

      

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
        }
    }

