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
    public partial class FormSignUp : Form
    {
        public FormSignUp()
        {
            InitializeComponent();
        }

        private void ButtonCreateAccount_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Program.GetConString());
            con.Open();
            SqlCommand com1 = new SqlCommand("select * from utilizator where username=@name or email=@mail", con);
            com1.Parameters.AddWithValue("name", textBoxUser.Text);
            com1.Parameters.AddWithValue("mail", textBoxMail.Text);
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
                                //mail
                                String mail = textBoxMail.Text;
                                bool problem = false;

                                if (mail.Length == 0)
                                    problem = true;
                                else
                                {
                                    if (!Char.IsLetter(mail[0]) || !Char.IsLetter(mail[mail.Length - 1]))
                                    {
                                        problem = true;
                                    }

                                    int arPos = -1;

                                    string specialCh = "!#$%&'*+-/=?^_`{|}~";
                                    for (int i = 1; i < mail.Length - 1; i++)
                                    {
                                        if (!Char.IsLetterOrDigit(mail[i])  && mail[i] != '@'
                                                && !specialCh.Contains(mail[i]))
                                        {
                                            problem = true;
                                        }
                                        else
                                        {
                                            if (mail[i] == '@')
                                            {
                                                if (arPos == -1)
                                                    arPos = i;
                                                else
                                                    problem = true;
                                            }
                                        }
                                    }

                                    if (arPos == -1)
                                        problem = true;

                                    bool invalid = true;

                                    if (mail[arPos + 1] == '.')
                                        problem = true;

                                    for (int i = arPos + 2; i < mail.Length - 1; i++)
                                    {
                                        if (mail[i] == '.')
                                            invalid = false;
                                    }

                                    if (invalid)
                                        problem = true;

                                    
                                }

                                //end mail

                                if (problem)
                                    textBoxError.Text = "invalid mail";
                                else
                                {
                                    con = new SqlConnection(Program.GetConString());
                                    con.Open();

                                    SqlTransaction tx = con.BeginTransaction();
                                    SqlCommand com2 = new SqlCommand("insert into utilizator values(@nameUt,@pass," +
                                        "@email,0, '" + DateTime.Now.AddDays(-1).ToString() + "')", con);
                                    


                                    try
                                    {
                                        com2.Transaction = tx;
                                        com2.Parameters.AddWithValue("nameUt", textBoxUser.Text);
                                        com2.Parameters.AddWithValue("pass", textBoxPass.Text);
                                        com2.Parameters.AddWithValue("email", textBoxMail.Text);

                                        com2.ExecuteNonQuery();
                                        tx.Commit();
                                        ClearText();
                                        Program.GetSignUpForm().Hide();
                                        Program.GetLogInForm().Show();
                                    }
                                    catch(Exception)
                                    {
                                        tx.Rollback();
                                        textBoxError.Text = "ERROR";
                                    }
                                    finally
                                    {
                                        con.Close();
                                    }         
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                con.Close();

                con.Open();
                com1 = new SqlCommand("select * from utilizator where username=@name", con);
                com1.Parameters.AddWithValue("name", textBoxUser.Text);
                reader1 = com1.ExecuteReader();

                if(reader1.Read())
                {
                    textBoxError.Text = "Username already in use";
                }
                else
                {
                    textBoxError.Text = "Mail already in use";
                }
            }
        }

        private void ButtonExit_Click(object sender, EventArgs e)
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

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            ClearText();
            Program.GetLogInForm().Show();
            Program.GetSignUpForm().Hide();
        }
    }
}
