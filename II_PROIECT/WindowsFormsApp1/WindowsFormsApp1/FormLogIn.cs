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
            Program.SetFormMainMenu(new FormMainMenu() ) ;
            Program.SetFormEventPage(new FormEventPage());
            Program.SetSignUpForm( new FormSignUp() );
            Program.SetControlForm(new FormControls());
            Program.SetFormEventControl(new FormEventControl());
            Program.SetFormAttend(new FormAttending());
            Program.SetFormAdvertisement(new FormAdv());

            Program.GetFormMainMenu().Hide();
            Program.GetFormEventPage().Hide();
            Program.GetSignUpForm().Hide();
            Program.GetControlForm().Hide();
            Program.GetFormEventControl().Hide();
            Program.GetFormAdvertisement().Hide();
        }

        private void ButtonSignUp_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            Program.GetSignUpForm().Show();
            Program.GetLogInForm().Hide();
        }

        private void ClearTextBoxes()
        {
            textBoxUser.Text = "";
            textBoxPass.Text = "";
            textBoxErrorPassword.Text = "";
        }

        private void ButtonLogIn_Click(object sender, EventArgs e)
        {
            string pass = textBoxPass.Text;


            SqlConnection con = new SqlConnection(Program.GetConString());
            con.Open();
            SqlCommand com1 = new SqlCommand("select * from utilizator where username=@name", con);
            com1.Parameters.AddWithValue("name", textBoxUser.Text);

            SqlDataReader reader1 = com1.ExecuteReader();

            if (reader1.Read())
            {
                if(textBoxPass.Text.Equals(reader1["passwrd"].ToString()))
                {
                    Double.TryParse(reader1["wallet"].ToString(), out double money);

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

                    Program.UpdaterAll();
                    Program.GetFormMainMenu().Show();
                    Program.GetLogInForm().Hide();

                    Program.GetFormMainMenu().Clear();
                    Program.GetFormMainMenu().ShowProducts();

                    Program.GetControlForm().CheckAdmin();
                    Program.GetControlForm().PremiumCheck();
                    Program.GetFormMainMenu().PremiumCheck();

                    Program.GetFormEventControl().CheckAdmin();

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

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Close();
        }

      
    }
}
