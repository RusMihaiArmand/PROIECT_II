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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();

            dateTimePickerStart.Format = DateTimePickerFormat.Custom;
            dateTimePickerStart.CustomFormat = "yyyy-MM-dd HH:mm:ss";

            dateTimePickerEnd.Format = DateTimePickerFormat.Custom;
            dateTimePickerEnd.CustomFormat = "yyyy-MM-dd HH:mm:ss";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Clear()
        {
            textBoxName.Text = "";
            textBoxDesc.Text = "";
            textBoxPrice.Text = "";

            dateTimePickerStart.Text = DateTime.Now.ToString();
            dateTimePickerEnd.Text = DateTime.Now.ToString();

            textBoxLocation.Text = "";
            textBoxPeople.Text = "";

            pictureBox1.Image = null;

        }


        private void button1_Click(object sender, EventArgs e)
        {
            Clear();

            int id;
            Int32.TryParse(textBoxID.Text, out id);

            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=STUD;Integrated Security=True");
            con.Open();
            SqlCommand com1 = new SqlCommand("select * from SportEvents where id=@id", con);
            com1.Parameters.AddWithValue("id", id);

            SqlDataReader reader1 = com1.ExecuteReader();

            if (reader1.Read())
            {
                textBoxName.Text = reader1["evName"].ToString();
                textBoxDesc.Text = reader1["descript"].ToString();
                textBoxPrice.Text = reader1["price"].ToString();

                dateTimePickerStart.Text = reader1["dateStart"].ToString();
                dateTimePickerEnd.Text = reader1["dateEnd"].ToString();

                textBoxLocation.Text = reader1["locat"].ToString();
                textBoxPeople.Text = reader1["NrMaxPeople"].ToString();

                if (reader1["img"] == null)
                    pictureBox1.Image = null;
                else
                {

                    byte[] img = (byte[])(reader1["img"]);
                    MemoryStream ms = new MemoryStream(img);
                    pictureBox1.Image = Image.FromStream(ms);
                }


            }
            else
            {
                textBoxDEBUG.Text = "what event are you looking for mate?";
            }


            con.Close();


            //int id;
            //Int32.TryParse(textBox1.Text, out id);

            //textBox2.Text = "";
            //textBox3.Text = "";
            //textBox4.Text = "";
            //textBox5.Text = "";
            //textBox6.Text = "";
            //textBox7.Text = "";
            //pictureBox1.Image = null;

            //foreach (Product p in Program.getProducts())
            //{
            //    if(p.getCode() == id)
            //    {
            //        textBox2.Text = p.getName();
            //        textBox3.Text = p.getDescription();
            //        textBox4.Text = p.getQuantity().ToString();
            //        textBox5.Text = p.getScore().ToString();
            //        textBox6.Text = p.getPrice().ToString();
            //        textBox7.Text = p.getPhotoName();

            //        pictureBox1.Load("pictures\\" + textBox7.Text);
            //    }

            //}



        }

        private void button3_Click(object sender, EventArgs e)
        {
            //int id;
            //Int32.TryParse(textBox1.Text, out id);

            //textBox2.Text = "";
            //textBox3.Text = "";
            //textBox4.Text = "";
            //textBox5.Text = "";
            //textBox6.Text = "";
            //textBox7.Text = "";

            //pictureBox1.Image = null;

            //int i=-1;

            //foreach (Product p in Program.getProducts())
            //{
            //    if (p.getCode() == id)
            //    {
            //        i = Program.getProducts().IndexOf(p);

            //    }

            //}

            //if(i!=-1)
            //{
            //    //Program.getProducts().RemoveAt(i);
            //    //Program.WriteProducts();
            //    //Program.f1.ShowProducts();

            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                if(textBoxName.Text.Length<3 || textBoxLocation.Text.Length<3)
                {
                    textBoxDEBUG.Text = "ERROR";
                }
                else
                {
                    
                    SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=STUD;Integrated Security=True");
                    con.Open();

                    SqlCommand com1 = new SqlCommand("insert into SportEvents values(@nameEv,@desc,@price,@dateS,@dateE,@loc,@maxPe,@img,@creat)", con);

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

                    if(textBoxPhotoId.Text.Length < 1)
                    {
                        //com1.Parameters.AddWithValue("img", "Null");
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


                    SqlDataReader reader1 = com1.ExecuteReader();
                    con.Close();

                    DateTime.Now.ToString();
                }

            }
            catch(Exception exc)
            { }
  
        }

        private void button4_Click(object sender, EventArgs e)
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

        private void button5_Click(object sender, EventArgs e)
        {
            textBoxDEBUG.Text = dateTimePickerStart.Text;
        }
    }
}
