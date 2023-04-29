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

namespace WindowsFormsApp1
{
    public partial class FormTesting : Form
    {
        public FormTesting()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=STUD;Integrated Security=True");
            con.Open();
            SqlCommand com1 = new SqlCommand("select * from studenti where id=@id", con);
            com1.Parameters.AddWithValue("id", textBox1.Text);

            SqlDataReader reader1 = com1.ExecuteReader();

            if(reader1.Read())
            {
                textBox2.Text = reader1["name"].ToString();
                textBox3.Text = reader1["registry_date"].ToString();
            }
            else
            {
                //textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }

            con.Close();

        }
    }
}
