using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormEventPage : Form
    {
        public FormEventPage()
        {
            InitializeComponent();  
        }

        public void Display(int id, string name, string desc, double price, string dateS, string dateE,
            string location, int maxPeople, int taken, byte[] img, string cr)
        {
            textBoxId.Text = id.ToString();
            textBoxName.Text = name;
            textBoxDesc.Text = desc;
            textBoxPrice.Text = price.ToString();

            textBoxDateStart.Text = dateS;
            textBoxDateEnd.Text = dateE;
            textBoxLocation.Text = location;

            if (maxPeople > 0)
            {
                textBoxAvailablePlaces.Text = (maxPeople-taken).ToString();
                textBoxTotalPlaces.Text = maxPeople.ToString();

            }
            else
            {
                textBoxAvailablePlaces.Text = "no limit";
                textBoxTotalPlaces.Text = "no limit";
            }


            if (img == null)
            {
                pictureBox1.Image = null;
            }
            else
            {
                MemoryStream ms = new MemoryStream(img);
                pictureBox1.Image = Image.FromStream(ms);
            }

            textBoxCreator.Text = cr;
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonAttend_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Program.GetConString());
            con.Open();
            SqlCommand com1 = new SqlCommand("select * from Attending where idEvent=@id and userName like '" +
                Program.GetCurrentAccount().GetName() + "'", con);

            Int32.TryParse(textBoxId.Text, out int id);
            com1.Parameters.AddWithValue("id", id);

            SqlDataReader reader1 = com1.ExecuteReader();

            Int32.TryParse(textBoxTotalPlaces.Text, out int totalP);
            Int32.TryParse(textBoxAvailablePlaces.Text, out int freeP);

            if (freeP == 0 && totalP > 0)
            {
                MessageBox.Show("No places left", "Message");
            }
            else
            {
                if (reader1.Read())
                {
                    MessageBox.Show("You're already attending", "Message");
                    con.Close();
                }
                else
                {
                    con.Close();

                    if (Program.GetCurrentAccount().GetName().Equals(textBoxCreator.Text))
                    {
                        MessageBox.Show("This is your event", "Message");
                    }
                    else
                    {
                        Double.TryParse(textBoxPrice.Text, out double price);

                        if (Program.GetCurrentAccount().GetMoney() < price)
                        {
                            MessageBox.Show("Not enough money", "Message");
                        }
                        else
                        {
                            con = new SqlConnection(Program.GetConString());
                            con.Open();

                            SqlTransaction tx = con.BeginTransaction();
                            com1 = new SqlCommand("insert into Attending values(@id,@ut)", con);

                            SqlCommand com2 = new SqlCommand("update utilizator set wallet=@mon where username like '" +
                                Program.GetCurrentAccount().GetName() + "'", con);


                            try
                            {
                                com1.Transaction = tx;

                                com1.Parameters.AddWithValue("id", textBoxId.Text);
                                com1.Parameters.AddWithValue("ut", Program.GetCurrentAccount().GetName());

                                com1.ExecuteNonQuery();

                                tx.Commit();
                            }
                            catch (Exception)
                            {
                                tx.Rollback();
                                MessageBox.Show("ERROR", "Message");
                            }
                            finally
                            {
                                con.Close();
                            }


                            con.Open();
                            tx = con.BeginTransaction();

                            try
                            {
                                com2.Transaction = tx;
                                double newM = Program.GetCurrentAccount().GetMoney() - price;
                                com2.Parameters.AddWithValue("mon", newM);
                                com2.Parameters.AddWithValue("us", Program.GetCurrentAccount().GetName());


                                com2.ExecuteNonQuery();
                                tx.Commit();

                                Program.GetFormEventPage().Hide();
                                Program.GetFormMainMenu().Show();

                                Program.GetCurrentAccount().SetMoney(newM);
                                Program.UpdaterAll();
                            }
                            catch (Exception)
                            {
                                tx.Rollback();
                                MessageBox.Show("ERROR", "Message");
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

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            Program.GetFormEventPage().Hide();
            Program.GetFormMainMenu().Show();
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
