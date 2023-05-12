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
    public partial class FormLogIn : Form
    {
        public FormLogIn()
        {
            InitializeComponent();
            Program.setFormMainMenu(new FormMainMenu() ) ;
            Program.setFormEventPage(new FormEventPage());
            Program.setSignUpForm( new FormSignUp() );
            Program.setControlForm(new FormControls());
            Program.setFormEventControl(new FormEventControl());
            Program.setFormAttend(new FormAttending());
            Program.setFormAdvertisement(new FormAdv());

            Program.getFormMainMenu().Hide();
            Program.getFormEventPage().Hide();
            Program.getSignUpForm().Hide();
            Program.getControlForm().Hide();
            Program.getFormEventControl().Hide();
            Program.getFormAdvertisement().Hide();

        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            Program.getSignUpForm().Show();
            Program.getLogInForm().Hide();
        }

        private void ClearTextBoxes()
        {
            textBoxUser.Text = "";
            textBoxPass.Text = "";
            textBoxErrorPassword.Text = "";
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            string pass = textBoxPass.Text;


            SqlConnection con = new SqlConnection(Program.getConString());
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

                    bool premiumStatus = false;

                    if( DateTime.Now < DateTime.Parse(reader1["premiumUntil"].ToString()) || adminStatus)
                        premiumStatus = true;

                    DateTime time = DateTime.Parse(reader1["premiumUntil"].ToString());

                    Account ac = new Account(reader1["username"].ToString(), reader1["passwrd"].ToString(),
                        reader1["email"].ToString(), money, adminStatus, premiumStatus, time);



                    Program.SetCurrentAccount(ac);
                    ClearTextBoxes();

                    Program.getFormMainMenu().Updater();
                    Program.getFormMainMenu().Show();
                    Program.getLogInForm().Hide();

                    Program.getFormMainMenu().Clear();
                    Program.getFormMainMenu().ShowProducts();

                    Program.getControlForm().CheckAdmin();
                    Program.getControlForm().PremiumCheck();
                    Program.getFormMainMenu().PremiumCheck();

                    Program.getFormEventControl().CheckAdmin();

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

      
    }
}
