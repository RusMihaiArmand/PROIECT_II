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
    public partial class FormAdv : Form
    {
        public FormAdv()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Clear();
            Program.getFormAdvertisement().Hide();
            Program.getControlForm().Show();
        }

        private void Clear()
        {

            textBoxName.Text = "";

            textBoxPhotoId.Text = "";

            pictureBox1.Image = null;
            textBoxDEBUG.Text = "";

            listBox1.Items.Clear();
        }

        private void buttonClrImg_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            textBoxPhotoId.Text = "";
        }

        private void buttonImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.png";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBoxPhotoId.Text = ofd.FileName;
                pictureBox1.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void buttonRef_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Program.getConString());

            con.Open();
            SqlCommand com1 = new SqlCommand("select advName from Advertisements", con);

            SqlDataReader reader1 = com1.ExecuteReader();

            listBox1.Items.Clear();

            while (reader1.Read())
            {
                string id = reader1[0].ToString();
                listBox1.Items.Add(id);
            }

            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            textBoxPhotoId.Text = "";
            pictureBox1.Image = null;
            textBoxDEBUG.Text = "";

            string name = textBoxName.Text;


            SqlConnection con = new SqlConnection(Program.getConString());
            con.Open();
            SqlCommand com1 = new SqlCommand("select * from Advertisements where advName like'"+
                name + "'", con);

            SqlDataReader reader1 = com1.ExecuteReader();
            if (reader1.Read())
            {

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
    

            }
            else
            {
                textBoxDEBUG.Text = "No ad found with the given name.";
            }
            con.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Program.getConString());
            

          
                try
                {
                 

                    if (textBoxName.Text.Length < 3 || textBoxName.Text.Length > 30 || textBoxPhotoId.Text.Length <2)
                    {
                        textBoxDEBUG.Text = "ERROR";
                    }
                    else
                    {
                        con.Open();

                        SqlCommand com1 = new SqlCommand("insert into Advertisements values(@nameAdv,@img)", con);
                        SqlTransaction tx = con.BeginTransaction();

                        try
                        {
                            com1.Transaction = tx;
                            com1.Parameters.AddWithValue("nameAdv", textBoxName.Text);


                                byte[] imageData;
                                FileStream fs = new FileStream(textBoxPhotoId.Text, FileMode.Open, FileAccess.Read);
                                BinaryReader br = new BinaryReader(fs);
                                imageData = br.ReadBytes((int)fs.Length);
                                br.Close();
                                fs.Close();
                                com1.Parameters.AddWithValue("img", imageData);
                            

                            Clear();
                            com1.ExecuteNonQuery();
                            tx.Commit();
                            textBoxDEBUG.Text = "";
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
                }
                catch (Exception exc)
                { }
            
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            try
            {


                if (textBoxName.Text.Length < 3 || textBoxName.Text.Length > 30 || textBoxPhotoId.Text.Length < 2)
                {
                    textBoxDEBUG.Text = "ERROR";
                }
                else
                {
                    SqlConnection con = new SqlConnection(Program.getConString());

                    con.Open();

                    string name = textBoxName.Text;
                    SqlCommand com1 = new SqlCommand("select * from Advertisements where advName like'" +
                        name + "'", con);


                    SqlDataReader reader1 = com1.ExecuteReader();

                    if (reader1.Read())
                    {
                        
                            con.Close();
                            con.Open();

                            com1 = new SqlCommand("update Advertisements set advName = @nameAd,img=@img where advName like'" +
                        name + "'", con);

                        SqlTransaction tx = con.BeginTransaction();
                            try
                            {
                                com1.Transaction = tx;
                                com1.Parameters.AddWithValue("nameAd", name);
                            
       

                               
                                    byte[] imageData;
                                    FileStream fs = new FileStream(textBoxPhotoId.Text, FileMode.Open, FileAccess.Read);
                                    BinaryReader br = new BinaryReader(fs);
                                    imageData = br.ReadBytes((int)fs.Length);
                                    br.Close();
                                    fs.Close();
                                    com1.Parameters.AddWithValue("img", imageData);
                                


                                com1.ExecuteNonQuery();
                                tx.Commit();
                                textBoxDEBUG.Text = "";
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
                    else
                    {
                        textBoxDEBUG.Text = "No such advertisement found";
                    }
                }
            }
            catch (Exception exc)
            { }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;

            SqlConnection con = new SqlConnection(Program.getConString());
            con.Open();
            SqlCommand com1 = new SqlCommand("select * from Advertisements where advName like'" +
                        name + "'", con);

            SqlDataReader reader1 = com1.ExecuteReader();

            if (!reader1.Read())
            {
                textBoxDEBUG.Text = "Ad not found";
                con.Close();
            }
            else
            {
                
                    con.Close();
                    con.Open();
                    com1 = new SqlCommand("delete from Advertisements where advName like'" +
                        name + "'", con);
                SqlTransaction tx = con.BeginTransaction();



                    try
                    {
                        com1.Transaction = tx;
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

        }
    }
}
