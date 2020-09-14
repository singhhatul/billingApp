using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace billingProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = D:\billing\billing.mdf; Integrated Security = True; Connect Timeout = 30");
            con.Open();
            String query = "Select Count(*) From login where usename='" + textBox1.Text + "' and password ='" + textBox2.Text + "'";
            SqlCommand sqlCmd = new SqlCommand(query);
            String output = sqlCmd.ExecuteScalar().ToString();
            if (output == "1")
            {
                Form2 f = new Form2();
                f.Show();
            }
            else
            {
                this.Hide();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
