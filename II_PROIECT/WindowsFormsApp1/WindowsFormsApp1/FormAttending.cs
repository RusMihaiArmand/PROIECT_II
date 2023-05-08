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
    public partial class FormAttending : Form
    {
        public FormAttending()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Program.GetFormAttend().Hide();
            Program.getControlForm().Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            textBoxName.Text = "";
            textBoxDesc.Text = "";
            textBoxPrice.Text = "";
            textBoxDateStart.Text = "";
            textBoxDateEnd.Text = "";
            textBoxLocation.Text = "";
            textBoxPeople.Text = "";
            textBoxPhotoId.Text = "";
            textBoxCreator.Text = "";
            pictureBox1.Image = null;
            textBoxDEBUG.Text = "";

            int id;
            Int32.TryParse(textBoxID.Text, out id);

            SqlConnection con = new SqlConnection(Program.getConString());
            con.Open();
            SqlCommand com1;

            com1 = new SqlCommand("select * from attending where idEvent=@id and userName like '" + Program.getCurrentAccount().getName() + "'",con);
                com1.Parameters.AddWithValue("id", id);
            SqlDataReader reader1 = com1.ExecuteReader();

            if(reader1.Read())
            {
                con.Close();
                con.Open();
            

                com1 = new SqlCommand("select * from SportEvents where id=@id", con);
                com1.Parameters.AddWithValue("id", id);

                reader1 = com1.ExecuteReader();
                if (reader1.Read())
                {
               
                        textBoxName.Text = reader1["evName"].ToString();
                        textBoxDesc.Text = reader1["descript"].ToString();
                        textBoxPrice.Text = reader1["price"].ToString();
                        textBoxDateStart.Text = reader1["dateStart"].ToString();
                        textBoxDateEnd.Text = reader1["dateEnd"].ToString();
                        textBoxLocation.Text = reader1["locat"].ToString();
                        textBoxPeople.Text = reader1["NrMaxPeople"].ToString();

                        if (reader1["img"] == DBNull.Value)
                        {
                            pictureBox1.Image = null;
                        }
                        else
                        {
                            byte[] img = (byte[])(reader1["img"]);
                            MemoryStream ms = new MemoryStream(img);
                            pictureBox1.Image = Image.FromStream(ms);
                        }

                        textBoxCreator.Text = reader1["creator"].ToString();
              
                }
       
            }
            else
            {
                textBoxDEBUG.Text = "You're not attending this event";

            }
            con.Close();



        }

        public void Clear()
        {
            textBoxID.Text = "";
            textBoxName.Text = "";
            textBoxDesc.Text = "";
            textBoxPrice.Text = "";
            textBoxDateStart.Text = "";
            textBoxDateEnd.Text = "";
            textBoxLocation.Text = "";
            textBoxPeople.Text = "";
            textBoxPhotoId.Text = "";
            textBoxCreator.Text = "";
            pictureBox1.Image = null;
            textBoxDEBUG.Text = "";

            listBox1.Items.Clear();

            listBox1.Items.Clear();
        }


        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int id;
            Int32.TryParse(textBoxID.Text, out id);

            SqlConnection con = new SqlConnection(Program.getConString());
            con.Open();

            SqlCommand com1 = new SqlCommand("delete from Attending where idEvent=@id and userName like '" + Program.getCurrentAccount().getName() + "'", con);
            SqlTransaction tx = con.BeginTransaction();



            try
            {
                com1.Transaction = tx;
                com1.Parameters.AddWithValue("id", id);
                com1.ExecuteNonQuery();

                tx.Commit();
                Clear();

            }
            catch (Exception exc)
            {
                tx.Rollback();
                textBoxDEBUG.Text = "ERROR";
            }
            finally
            {
                con.Close();
            }

        }

        private void buttonRef_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Program.getConString());

            con.Open();
            SqlCommand com1 = new SqlCommand("select idEvent from attending where userName like '"
                + Program.getCurrentAccount().getName() + "'", con);

            SqlDataReader reader1 = com1.ExecuteReader();

            listBox1.Items.Clear();

            while (reader1.Read())
            {
                string id = reader1[0].ToString();

                listBox1.Items.Add(id);

            }

            con.Close();
        }
    }
}
