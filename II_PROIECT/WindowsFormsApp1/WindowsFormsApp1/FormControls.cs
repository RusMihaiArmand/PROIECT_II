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

        public void PremiumCheck()
        {
            if (Program.getCurrentAccount().getPremium() || Program.getCurrentAccount().getAdmin())
                buttonPremium.Hide();
            else
                buttonPremium.Show();

        }

        public void CheckAdmin()
        {
            if (!Program.getCurrentAccount().getAdmin())
                buttonAdv.Hide();
            else
                buttonAdv.Show();

        }

        private void buttonSignOut_Click(object sender, EventArgs e)
        {
            textBoxFunds.Text = "";
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

                textBoxFunds.Text = "";

                if(s>0)
                {
                    
                    Program.getCurrentAccount().addMoney(s);
                    Program.getFormMainMenu().Updater();

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

                    buttonPremium.Hide();

                    SqlConnection con = new SqlConnection(Program.getConString());
                    con.Open();
                    SqlTransaction tx = con.BeginTransaction();

                    SqlCommand com1 = new SqlCommand("update utilizator set premiumUntil=@date where username=@name", con);


                    try
                    {
                        string prDate = DateTime.Now.AddDays(30).ToString();

                        com1.Parameters.AddWithValue("date", prDate);
                        com1.Parameters.AddWithValue("name", Program.getCurrentAccount().getName());


                        com1.ExecuteNonQuery();
                        tx.Commit();

                        Program.getSignUpForm().Hide();
                        Program.getLogInForm().Show();
                    }
                    catch (Exception exc)
                    {
                        tx.Rollback();
                        MessageBox.Show("Error; contact admins for help", "Message");
                    }
                    finally
                    {
                        con.Close();
                        PremiumCheck();
                        Program.getFormMainMenu().PremiumCheck();
                    }


                }
                else
                    MessageBox.Show("Can't buy premium", "Message");
                

            }
        }

        private void buttonEventAdder_Click(object sender, EventArgs e)
        {
            textBoxFunds.Text = "";
            Program.getControlForm().Hide();
            Program.getFormEventControl().Show();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            textBoxFunds.Text = "";
            Program.getControlForm().Hide();
            Program.getFormMainMenu().Show();
        }

        private void buttonAtt_Click(object sender, EventArgs e)
        {
            textBoxFunds.Text = "";
            Program.getFormAttend().Show();
            Program.getFormAttend().Clear();
            Program.getControlForm().Hide();
        }

        private void buttonAccountDelete_Click(object sender, EventArgs e)
        {
            textBoxFunds.Text = "";

            DialogResult dialogResult = MessageBox.Show("Are you sure?", "WARNING", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if(Program.getCurrentAccount().getAdmin())
                {
                    MessageBox.Show("Can't delete admin accounts like that", "No");
                }
                else
                {


                    SqlConnection con = new SqlConnection(Program.getConString());

                    con.Open();
                    SqlCommand com1 = new SqlCommand("select id from SportEvents where creator like '"
                            + Program.getCurrentAccount().getName() + "'", con);

                    SqlDataReader reader1 = com1.ExecuteReader();

                    List<int> listId = new List<int>();

                    int id;
                    while (reader1.Read())
                    {
                        Int32.TryParse(reader1[0].ToString(), out id);

                        listId.Add(id);
                    }

                    con.Close();

                    foreach (int ide in listId)
                    {
                        con.Open();
                        com1 = new SqlCommand("delete from Attending where idEvent=@id", con);
                        SqlTransaction tx = con.BeginTransaction();



                        try
                        {
                            com1.Transaction = tx;
                            com1.Parameters.AddWithValue("id", ide);
                            com1.ExecuteNonQuery();

                            tx.Commit();

                        }
                        catch (Exception exc)
                        {
                            tx.Rollback();
                        }
                        finally
                        {
                            con.Close();
                        }

                        con.Open();

                        com1 = new SqlCommand("delete from SportEvents where id=@id", con);
                        tx = con.BeginTransaction();

                        try
                        {
                            com1.Transaction = tx;

                            com1.Parameters.AddWithValue("id", ide);
                            com1.ExecuteNonQuery();

                            tx.Commit();

                        }
                        catch (Exception exc)
                        {
                            tx.Rollback();
                        }
                        finally
                        {
                            con.Close();
                        }


                    }



                    con.Open();
                    com1 = new SqlCommand("delete from attending where userName like '"
                            + Program.getCurrentAccount().getName() + "'", con);

                    SqlTransaction tx2 = con.BeginTransaction();

                    try
                    {
                        com1.Transaction = tx2;
                        com1.ExecuteNonQuery();

                        tx2.Commit();

                    }
                    catch (Exception exc)
                    {
                        tx2.Rollback();
                        
                    }
                    finally
                    {
                        con.Close();


                    }


                    con.Open();
                    com1 = new SqlCommand("delete from utilizator where username like '"
                            + Program.getCurrentAccount().getName() + "'", con);

                    tx2 = con.BeginTransaction();

                    try
                    {
                        com1.Transaction = tx2;
                        com1.ExecuteNonQuery();

                        tx2.Commit();

                    }
                    catch (Exception exc)
                    {
                        tx2.Rollback();
                        MessageBox.Show("Something went wrong", "ERROR");
                    }
                    finally
                    {
                        con.Close();

                        Program.SetCurrentAccount(null);
                        Program.getLogInForm().Show();
                        Program.getControlForm().Hide();

                    }


                }
            }
        }

        private void buttonAdv_Click(object sender, EventArgs e)
        {
            textBoxFunds.Text = "";
            Program.getControlForm().Hide();
            Program.getFormAdvertisement().Show();
        }
    }
}
