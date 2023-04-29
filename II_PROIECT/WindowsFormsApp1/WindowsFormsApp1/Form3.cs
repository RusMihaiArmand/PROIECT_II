using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            Program.f1 = new Form1();
            Program.f4 = new Form4();

            Program.f1.Hide();
            Program.f4.Hide();

        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            Program.f4.Show();
            Program.f3.Hide();
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            List<Account> accountsList = Program.getAccounts();

            //string name = textBox1.Text;
            string pass = textBoxPass.Text;


            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=STUD;Integrated Security=True");
            con.Open();
            SqlCommand com1 = new SqlCommand("select * from utilizator where username=@name", con);
            com1.Parameters.AddWithValue("name", textBoxUser.Text);

            SqlDataReader reader1 = com1.ExecuteReader();

            if (reader1.Read())
            {
                if(textBoxPass.Text.Equals(reader1["passwrd"].ToString()))
                {
                    double money;
                    Double.TryParse(reader1["wallet"].ToString(), out money);

                    bool adminStatus = false;

                    if (reader1["email"].ToString().Contains("@admin"))
                        adminStatus = true;

                    Account ac = new Account(reader1["username"].ToString(), reader1["passwrd"].ToString(),
                        reader1["email"].ToString(), money, adminStatus);

                    Program.SetCurrentAccount(ac);

                    textBoxErrorPassword.Text = "";

                    Program.f1.Show();
                    Program.f3.Hide();

                }
                else
                {
                    textBoxErrorPassword.Text = "Wrong password";

                }
                
            }
            else
            {
                textBoxErrorPassword.Text = "Wrong username";
            }


            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
