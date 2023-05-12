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
    public partial class FormEventControl : Form
    {
        public FormEventControl()
        {
            InitializeComponent();

            dateTimePickerStart.Format = DateTimePickerFormat.Custom;
            dateTimePickerStart.CustomFormat = "yyyy-MM-dd HH:mm:ss";

            dateTimePickerEnd.Format = DateTimePickerFormat.Custom;
            dateTimePickerEnd.CustomFormat = "yyyy-MM-dd HH:mm:ss";
        }


        private void Clear()
        {
            textBoxID.Text = "";
            textBoxName.Text = "";
            textBoxDesc.Text = "";
            textBoxPrice.Text = "";
            dateTimePickerStart.Text = DateTime.Now.ToString();
            dateTimePickerEnd.Text = DateTime.Now.ToString();
            textBoxLocation.Text = "";
            textBoxPeople.Text = "";
            textBoxPhotoId.Text = "";
            textBoxCreator.Text = "";
            pictureBox1.Image = null;
            textBoxDEBUG.Text = "";

            listBox1.Items.Clear();
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            textBoxName.Text = "";
            textBoxDesc.Text = "";
            textBoxPrice.Text = "";
            dateTimePickerStart.Text = DateTime.Now.ToString();
            dateTimePickerEnd.Text = DateTime.Now.ToString();
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
            SqlCommand com1 = new SqlCommand("select * from SportEvents where id=@id", con);
            com1.Parameters.AddWithValue("id", id);

            SqlDataReader reader1 = com1.ExecuteReader();
            if (reader1.Read())
            {
                if (Program.getCurrentAccount().getAdmin() ||
                    Program.getCurrentAccount().getName().Equals(reader1["creator"].ToString()))
                {
                    textBoxName.Text = reader1["evName"].ToString();
                    textBoxDesc.Text = reader1["descript"].ToString();
                    textBoxPrice.Text = reader1["price"].ToString();
                    dateTimePickerStart.Text = reader1["dateStart"].ToString();
                    dateTimePickerEnd.Text = reader1["dateEnd"].ToString();
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
                else
                {
                    textBoxDEBUG.Text = "Can't look at other's stuff like that";
                }
            }
            else
            {
                textBoxDEBUG.Text = "What event are you looking for?";
            }
            con.Close();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int id;
            Int32.TryParse(textBoxID.Text, out id);

            SqlConnection con = new SqlConnection(Program.getConString());
            con.Open();
            SqlCommand com1 = new SqlCommand("select * from SportEvents where id=@id", con);
            com1.Parameters.AddWithValue("id", id);

            SqlDataReader reader1 = com1.ExecuteReader();

            if (!reader1.Read())
            {
                textBoxDEBUG.Text = "event not found";
                con.Close();
            }
            else
            {
                if(Program.getCurrentAccount().getName().Equals(reader1["creator"].ToString()) ||
                   Program.getCurrentAccount().getAdmin())
                {
                    con.Close();
                    con.Open();
                    com1 = new SqlCommand("delete from Attending where idEvent=@id", con);
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

                    
                    
                    con.Open();
                    com1 = new SqlCommand("delete from SportEvents where id=@id", con);
                    tx = con.BeginTransaction();  

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
                else
                {
                    Clear();
                    con.Close();
                    textBoxDEBUG.Text = "This isn't your event.";
                }
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Program.getConString());
            con.Open();

            SqlCommand com2 = new SqlCommand("select count(*) from SportEvents where creator=@creat", con);
            com2.Parameters.AddWithValue("creat", Program.getCurrentAccount().getName());
            SqlDataReader reader2 = com2.ExecuteReader();
            int nr;

            if (reader2.Read())
                Int32.TryParse(reader2[0].ToString(), out nr);
            else
                nr = 0;

            con.Close();

            if (nr >= Program.getCurrentAccount().maxEvents())
            {
                textBoxDEBUG.Text = "Too many events made";
            }
            else
            {
                try
                {
                    DateTime ds = DateTime.Parse(dateTimePickerStart.Text);
                    DateTime de = DateTime.Parse(dateTimePickerEnd.Text);

                    if (textBoxName.Text.Length < 3 || textBoxLocation.Text.Length < 3 || de <= ds ||
                        de<DateTime.Now || textBoxName.Text.Length > 30 || textBoxLocation.Text.Length > 60)
                    {
                        textBoxDEBUG.Text = "ERROR";
                    }
                    else
                    {
                        con = new SqlConnection(Program.getConString());
                        con.Open();

                        SqlCommand com1 = new SqlCommand("insert into SportEvents values(@nameEv,@desc,@price,@dateS,@dateE,@loc,@maxPe,@img,@creat)", con);
                        SqlTransaction tx = con.BeginTransaction();

                        try
                        {
                            com1.Transaction = tx;
                            com1.Parameters.AddWithValue("nameEv", textBoxName.Text);
                            com1.Parameters.AddWithValue("desc", textBoxDesc.Text);

                            double price;
                            Double.TryParse(textBoxPrice.Text, out price);
                            com1.Parameters.AddWithValue("price", price);
                            com1.Parameters.AddWithValue("dateS", dateTimePickerStart.Text);
                            com1.Parameters.AddWithValue("dateE", dateTimePickerEnd.Text);
                            com1.Parameters.AddWithValue("loc", textBoxLocation.Text);

                            double people;
                            Double.TryParse(textBoxPeople.Text, out people);
                            com1.Parameters.AddWithValue("maxPe", people);

                            if (textBoxPhotoId.Text.Length < 1)
                            {
                                com1.Parameters.Add("img", SqlDbType.VarBinary).Value = DBNull.Value;
                            }
                            else
                            {
                                byte[] imageData;
                                FileStream fs = new FileStream(textBoxPhotoId.Text, FileMode.Open, FileAccess.Read);
                                BinaryReader br = new BinaryReader(fs);
                                imageData = br.ReadBytes((int)fs.Length);
                                br.Close();
                                fs.Close();
                                com1.Parameters.AddWithValue("img", imageData);
                            }

                            com1.Parameters.AddWithValue("creat", Program.getCurrentAccount().getName());
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
        }



        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.png";

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                textBoxPhotoId.Text = ofd.FileName;
                pictureBox1.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime ds = DateTime.Parse(dateTimePickerStart.Text);
                DateTime de = DateTime.Parse(dateTimePickerEnd.Text);

                if (textBoxName.Text.Length < 3 || textBoxLocation.Text.Length < 3 || de<=ds ||
                      de < DateTime.Now || textBoxName.Text.Length > 30 || textBoxLocation.Text.Length > 60)
                {
                    textBoxDEBUG.Text = "ERROR";
                }
                else
                {
                    SqlConnection con = new SqlConnection(Program.getConString());

                    con.Open();
                    SqlCommand com1 = new SqlCommand("select * from SportEvents where id=@id", con);
                    int id;
                    Int32.TryParse(textBoxID.Text, out id);
                    com1.Parameters.AddWithValue("id", id);
                    SqlDataReader reader1 = com1.ExecuteReader();

                    if(reader1.Read())
                    {
                        if (Program.getCurrentAccount().getName().Equals(reader1["creator"].ToString()) ||
                            Program.getCurrentAccount().getAdmin())
                        {
                            con.Close();
                            con.Open();

                            com1 = new SqlCommand("update SportEvents set evName = @nameEv, descript=@desc, price=@price, dateStart=@dateS," +
                                "dateEnd=@dateE,locat=@loc,nrMaxPeople=@maxPe,img=@img  where id=@id", con);

                            SqlTransaction tx = con.BeginTransaction();
                            try
                            {
                                com1.Transaction = tx;
                                com1.Parameters.AddWithValue("nameEv", textBoxName.Text);
                                com1.Parameters.AddWithValue("desc", textBoxDesc.Text);
                                double price;
                                Double.TryParse(textBoxPrice.Text, out price);
                                com1.Parameters.AddWithValue("price", price);               
                                com1.Parameters.AddWithValue("dateS", dateTimePickerStart.Text);
                                com1.Parameters.AddWithValue("dateE", dateTimePickerEnd.Text);
                                com1.Parameters.AddWithValue("loc", textBoxLocation.Text);

                                double people;
                                Double.TryParse(textBoxPeople.Text, out people);
                                com1.Parameters.AddWithValue("maxPe", people);

                                if (textBoxPhotoId.Text.Length < 1)
                                {
                                    com1.Parameters.Add("img", SqlDbType.VarBinary).Value = DBNull.Value;
                                }
                                else
                                {
                                    byte[] imageData;
                                    FileStream fs = new FileStream(textBoxPhotoId.Text, FileMode.Open, FileAccess.Read);
                                    BinaryReader br = new BinaryReader(fs);
                                    imageData = br.ReadBytes((int)fs.Length);
                                    br.Close();
                                    fs.Close();
                                    com1.Parameters.AddWithValue("img", imageData);                               
                                }

                                com1.Parameters.AddWithValue("creat", Program.getCurrentAccount().getName());
                                com1.Parameters.AddWithValue("id", id);

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
                            textBoxDEBUG.Text = "Not your event";
                        }
                    }
                    else
                    {
                        textBoxDEBUG.Text = "No such event ID found";
                    }
                }
            }
            catch (Exception exc)
            { }
        }

        private void buttonClrImg_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            textBoxPhotoId.Text = "";
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Clear();
            Program.getFormEventControl().Hide();
            Program.getControlForm().Show();
        }

        private void buttonRef_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Program.getConString());

            con.Open();
            SqlCommand com1 = new SqlCommand("select id from SportEvents where creator like '" 
                + Program.getCurrentAccount().getName()  +  "'", con);

            SqlDataReader reader1 = com1.ExecuteReader();

            listBox1.Items.Clear();

            while(reader1.Read())
            {
                string id = reader1[0].ToString();

                listBox1.Items.Add(id);

            }

            con.Close();
        }

        private void buttonDelOld_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(Program.getConString());

            con.Open();
            SqlCommand com1 = new SqlCommand("select id from SportEvents where dateEnd <  GETDATE()", con);

            SqlDataReader reader1 = com1.ExecuteReader();

            List<int> listId = new List<int>();

            int id;
            while (reader1.Read())
            {
                Int32.TryParse( reader1[0].ToString(), out id);

                listId.Add(id);
            }

            con.Close();

            foreach(int ide in listId)
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

                con.Open();

                com1 = new SqlCommand("delete from SportEvents where id=@id", con);
                tx = con.BeginTransaction();

                try
                {
                    com1.Transaction = tx;

                    com1.Parameters.AddWithValue("id", ide);
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

        public void CheckAdmin()
        {
            if (Program.getCurrentAccount().getAdmin())
                buttonDelOld.Show();
            else
                buttonDelOld.Hide();

        }
          

    }
}
