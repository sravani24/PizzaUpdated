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
    public partial class Order : Form
    {
    public Order()
        {
            InitializeComponent();
        }

    private void button1_Click(object sender, EventArgs e)
    {
        shared.con = new SqlConnection(ConfigurationManager.ConnectionStrings["PizzaDBConnectionString"].ConnectionString);
        shared.con.Open();

        SqlCommand cmd = new SqlCommand("Insert into Customer(Uname,Address,PhNumber,Pizza,Size,Toppings,Status) values(@Uname,@Address,@PhNumber,@Pizza,@Size,@Toppings,@status)", shared.con);

        cmd.Parameters.AddWithValue("@Uname", NameTxt.Text);
        cmd.Parameters.AddWithValue("@Address", Address.Text);
        cmd.Parameters.AddWithValue("@PhNumber", PhoneNumber.Text);
        cmd.Parameters.AddWithValue("@Pizza", Pizza.Text);
        cmd.Parameters.AddWithValue("@Size", Size.Text);
        cmd.Parameters.AddWithValue("@Toppings", Toppings.Text);
        cmd.Parameters.AddWithValue("@Status", "Pending");

        int success = cmd.ExecuteNonQuery();

        if (success == 1)
        {
            int cost1=0;
            string pizza = Pizza.SelectedItem.ToString();
            string size = Size.SelectedItem.ToString();
            SqlCommand c = new SqlCommand("select Cost from Pizza where Pizname='" + pizza + "' and Size='" + size + "'", shared.con);
            using (SqlDataReader read1 = c.ExecuteReader())
            {

                if (read1.HasRows)
                {
                    while (read1.Read())
                    {
                        cost1 = Int32.Parse(read1[0].ToString()) * 3;

                    }

                }
            }

            textBox1.Text = cost1.ToString()+ "$";
        }
    }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You order has been Placed");
            this.Hide();
            shared.con.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }

    public static class shared
    {
        public static SqlConnection con;
        public static SqlDataAdapter adap;
    }
}

