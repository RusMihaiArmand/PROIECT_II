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
               // pictureBox1.Load("logo.png");
            }
            else
            {
                MemoryStream ms = new MemoryStream(img);
                pictureBox1.Image = Image.FromStream(ms);
            }

            textBoxCreator.Text = cr;

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonAttend_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Program.getConString());
            con.Open();
            SqlCommand com1 = new SqlCommand("select * from Attending where idEvent=@id and userName like '" +
                Program.getCurrentAccount().getName() + "'", con);

            int id;
            Int32.TryParse(textBoxId.Text, out id);
            com1.Parameters.AddWithValue("id", id);

            SqlDataReader reader1 = com1.ExecuteReader();

            int totalP, freeP;
            Int32.TryParse(textBoxTotalPlaces.Text, out totalP);
            Int32.TryParse(textBoxAvailablePlaces.Text, out freeP);

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

                if (Program.getCurrentAccount().getName().Equals(textBoxCreator.Text))
                {
                    MessageBox.Show("This is your event", "Message");
                }
                else
                {
                    double price;
                    Double.TryParse(textBoxPrice.Text, out price);

                    if (Program.getCurrentAccount().getMoney() < price)
                    {
                        MessageBox.Show("Not enough money", "Message");
                    }
                    else
                    {


                        con = new SqlConnection(Program.getConString());
                        con.Open();

                        SqlTransaction tx = con.BeginTransaction();

                        com1 = new SqlCommand("insert into Attending values(@id,@ut)", con);


                        SqlCommand com2 = new SqlCommand("update utilizator set wallet=@mon where username like '" +
                            Program.getCurrentAccount().getName() + "'", con);


                        try
                        {
                            com1.Transaction = tx;

                            com1.Parameters.AddWithValue("id", textBoxId.Text);
                            com1.Parameters.AddWithValue("ut", Program.getCurrentAccount().getName());


                            com1.ExecuteNonQuery();

                            tx.Commit();
                        }
                        catch (Exception exc)
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
                            double newM = Program.getCurrentAccount().getMoney() - price;
                            com2.Parameters.AddWithValue("mon", newM);
                            com2.Parameters.AddWithValue("us", Program.getCurrentAccount().getName());


                            com2.ExecuteNonQuery();

                            tx.Commit();

                            Program.getFormEventPage().Hide();
                            Program.getFormMainMenu().Show();

                            Program.getCurrentAccount().setMoney(newM);
                            Program.getFormMainMenu().Updater();

                        }
                        catch (Exception exc)
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

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Program.getFormEventPage().Hide();
            Program.getFormMainMenu().Show();
        }
    }
}
