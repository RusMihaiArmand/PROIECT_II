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
    public partial class FormControls : Form
    {
        public FormControls()
        {
            InitializeComponent();

            /*
            if (Program.getCurrentAccount() == null || Program.getCurrentAccount().getAdmin() == false)
                button5.Hide();
            else
                button5.Show();


            if (Program.getCurrentAccount() == null || Program.getCurrentAccount().getPremium() == true)
                button4.Hide();
            else
                button4.Show();
                */

        }

        private void buttonSignOut_Click(object sender, EventArgs e)
        {
            Program.SetCurrentAccount(null);
            Program.getControlForm().Hide();

            Program.getLogInForm().Show();

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonAddFunds_Click(object sender, EventArgs e)
        {
            if (Program.getCurrentAccount() == null)
                MessageBox.Show("You have to log in first", "Message");
            else
            {
                int s;
                Int32.TryParse(textBoxFunds.Text, out s);

                if (s < 0)
                    s = 0;

                textBoxFunds.Text = s.ToString();

                if(s>0)
                {
                    MessageBox.Show("Money added", "Message");
                    Program.getCurrentAccount().addMoney(s);


                }

            }
        }

        private void buttonPremium_Click(object sender, EventArgs e)
        {
            if (Program.getCurrentAccount() != null)
            {

                if (Program.getCurrentAccount().getMoney() >= 50
                      && Program.getCurrentAccount().getPremium() == false)
                {
                    Program.getCurrentAccount().addMoney(-50);
                    Program.getCurrentAccount().setPremium(true);

                    Program.getForm1().SetUsername();

                    buttonPremium.Hide();


                    SqlConnection con = new SqlConnection(Program.getConString());
                    con.Open();
                    SqlCommand com1 = new SqlCommand("update utilizator set premiumUntil=@date where username=@name", con);

                    string prDate =   DateTime.Now.AddDays(30).ToString()  ;

                    com1.Parameters.AddWithValue("date", prDate);
                    com1.Parameters.AddWithValue("name", Program.getCurrentAccount().getName());

                    SqlDataReader reader1 = com1.ExecuteReader();
                    con.Close();


                }
                else
                    MessageBox.Show("Can't buy premium", "Message");
                

            }
        }

        private void buttonEventAdder_Click(object sender, EventArgs e)
        {
            Program.getControlForm().Hide();
            Program.getFormEventControl().Show();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
