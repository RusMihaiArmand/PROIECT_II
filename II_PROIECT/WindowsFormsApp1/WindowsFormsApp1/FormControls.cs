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
        }

        public void PremiumCheck()
        {
            if (Program.GetCurrentAccount().GetPremium() || Program.GetCurrentAccount().GetAdmin())
                buttonPremium.Hide();
            else
                buttonPremium.Show();
        }

        public void CheckAdmin()
        {
            if (!Program.GetCurrentAccount().GetAdmin())
                buttonAdv.Hide();
            else
                buttonAdv.Show();
        }

        private void ButtonSignOut_Click(object sender, EventArgs e)
        {
            textBoxFunds.Text = "";
            Program.SetCurrentAccount(null);
            Program.GetControlForm().Hide();

            Program.GetLogInForm().Show();

            Program.UpdaterAll();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonAddFunds_Click(object sender, EventArgs e)
        {
            if (Program.GetCurrentAccount() == null)
                MessageBox.Show("You have to log in first", "Message");
            else
            {
                Int32.TryParse(textBoxFunds.Text, out int s);

                if (s < 0)
                    s = 0;

                textBoxFunds.Text = "";

                if(s>0)
                {        
                    Program.GetCurrentAccount().AddMoney(s);
                    Program.UpdaterAll();
                }
            }
        }

        private void ButtonPremium_Click(object sender, EventArgs e)
        {
            if (Program.GetCurrentAccount() != null)
            {
                if (Program.GetCurrentAccount().GetMoney() >= 50
                      && Program.GetCurrentAccount().GetPremium() == false)
                {
                    Program.GetCurrentAccount().AddMoney(-50);
                    Program.GetCurrentAccount().SetPremium(true);

                    buttonPremium.Hide();

                    SqlConnection con = new SqlConnection(Program.GetConString());
                    con.Open();
                    SqlTransaction tx = con.BeginTransaction();

                    SqlCommand com1 = new SqlCommand("update utilizator set premiumUntil=@date where username like '" +
                       Program.GetCurrentAccount().GetName() + "'", con);

                    try
                    {
                        com1.Transaction = tx;
                        string prDate = DateTime.Now.AddDays(30).ToString();

                        com1.Parameters.AddWithValue("date", DateTime.Now.AddDays(30));

                        com1.ExecuteNonQuery();
                        tx.Commit();

                    }
                    catch (Exception)
                    {
                        tx.Rollback();
                        MessageBox.Show("Error; contact admins for help", "Message");
                    }
                    finally
                    {
                        con.Close();
                        PremiumCheck();
                        Program.GetFormMainMenu().PremiumCheck();
                    }
                }
                else
                    MessageBox.Show("Can't buy premium", "Message");
            }
        }

        private void ButtonEventAdder_Click(object sender, EventArgs e)
        {
            textBoxFunds.Text = "";
            Program.GetControlForm().Hide();
            Program.GetFormEventControl().Show();
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            textBoxFunds.Text = "";
            Program.GetControlForm().Hide();
            Program.GetFormMainMenu().Show();
        }

        private void ButtonAtt_Click(object sender, EventArgs e)
        {
            textBoxFunds.Text = "";
            Program.GetFormAttend().Show();
            Program.GetFormAttend().Clear();
            Program.GetControlForm().Hide();
        }

        private void ButtonAccountDelete_Click(object sender, EventArgs e)
        {
            textBoxFunds.Text = "";

            DialogResult dialogResult = MessageBox.Show("Are you sure?", "WARNING", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if(Program.GetCurrentAccount().GetAdmin())
                {
                    MessageBox.Show("Can't delete admin accounts like that", "No");
                }
                else
                {
                    SqlConnection con = new SqlConnection(Program.GetConString());

                    con.Open();
                    SqlCommand com1 = new SqlCommand("select id from SportEvents where creator like '"
                            + Program.GetCurrentAccount().GetName() + "'", con);

                    SqlDataReader reader1 = com1.ExecuteReader();

                    List<int> listId = new List<int>();

                    while (reader1.Read())
                    {
                        Int32.TryParse(reader1[0].ToString(), out int id);
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
                        catch (Exception)
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
                        catch (Exception)
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
                            + Program.GetCurrentAccount().GetName() + "'", con);

                    SqlTransaction tx2 = con.BeginTransaction();
                    try
                    {
                        com1.Transaction = tx2;
                        com1.ExecuteNonQuery();
                        tx2.Commit();
                    }
                    catch (Exception)
                    {
                        tx2.Rollback();      
                    }
                    finally
                    {
                        con.Close();
                    }


                    con.Open();
                    com1 = new SqlCommand("delete from utilizator where username like '"
                            + Program.GetCurrentAccount().GetName() + "'", con);

                    tx2 = con.BeginTransaction();
                    try
                    {
                        com1.Transaction = tx2;
                        com1.ExecuteNonQuery();
                        tx2.Commit();
                    }
                    catch (Exception)
                    {
                        tx2.Rollback();
                        MessageBox.Show("Something went wrong", "ERROR");
                    }
                    finally
                    {
                        con.Close();
                        Program.SetCurrentAccount(null);
                        Program.GetLogInForm().Show();
                        Program.GetControlForm().Hide();
                    }
                }
            }

            Program.UpdaterAll();
        }

        private void ButtonAdv_Click(object sender, EventArgs e)
        {
            textBoxFunds.Text = "";
            Program.GetControlForm().Hide();
            Program.GetFormAdvertisement().Show();
        }

        public void Updater()
        {
            if (Program.GetCurrentAccount() == null)
            {
                textBoxUsername.Text = "";
                textBoxMoney.Text = "";
            }
            else
            {
                textBoxUsername.Text = Program.GetCurrentAccount().GetName();
                textBoxMoney.Text = Program.GetCurrentAccount().GetMoney().ToString();
            }
        }
    }
}
