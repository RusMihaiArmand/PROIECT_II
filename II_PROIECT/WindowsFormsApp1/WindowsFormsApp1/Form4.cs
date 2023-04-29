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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void buttonCreateAccount_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=STUD;Integrated Security=True");
            con.Open();
            SqlCommand com1 = new SqlCommand("select * from utilizator where username=@name", con);
            com1.Parameters.AddWithValue("name", textBoxUser.Text);

            SqlDataReader reader1 = com1.ExecuteReader();

            

            if (!reader1.Read())
            {
                con.Close();
                string user = textBoxUser.Text;
                string pass = textBoxPass.Text;

                textBoxError.Text = "";

                if (pass.Length > 10)
                    textBoxError.Text = "Password too long";
                else
                {
                    if (user.Length > 20)
                        textBoxError.Text = "Username too long";
                    else
                    {
                        if (pass.Length < 3)
                            textBoxError.Text = "Password too short";
                        else
                        {
                            if (user.Length < 3)
                                textBoxError.Text = "Username too short";
                            else
                            {
                                //to add mail errors
                                con = new SqlConnection("Data Source=.;Initial Catalog=STUD;Integrated Security=True");
                                con.Open();
                                SqlCommand com2 = new SqlCommand("insert into utilizator values(@nameUt,@pass," +
                                    "@email,0,0,null)", con);
                                com2.Parameters.AddWithValue("nameUt", textBoxUser.Text);
                                com2.Parameters.AddWithValue("pass", textBoxPass.Text);
                                com2.Parameters.AddWithValue("email", textBoxMail.Text);

                                
                                
                                reader1 = com2.ExecuteReader();
                                con.Close();

                                ClearText();
                                Program.f4.Hide();
                                Program.f3.Show();

                            }

                        }

                    }

                }

            }
            else
            {
                con.Close();
                textBoxError.Text = "Username in use";
            }

            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Close();
        }

        private void ClearText()
        {
            textBoxError.Text = "";
            textBoxUser.Text = "";
            textBoxPass.Text = "";
            textBoxMail.Text = "";

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            ClearText();
            Program.f3.Show();
            Program.f4.Hide();
        }
    }
}
