using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
     class Account
     {
        private string name;
        private string pass;
        private string email;
        private double money;
        private bool isAdmin;
        private bool hasPremium;
        private DateTime premiumUntil;
            

        
        public Account(string n, string p, string em, double mone, bool a, bool pr, DateTime premTime)
        {
            this.name = n;
            this.pass = p;
            this.email = em;
            
            this.money = mone;
            this.isAdmin = a;

            this.hasPremium = pr;
            this.premiumUntil = premTime;

            
        }
        

        public double getMoney()
        {
            return this.money;
        }
        public void setMoney(double n)
        {
            this.money = n;
        }
        public void addMoney(double n)
        {
            this.money = this.money + n;

            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=STUD;Integrated Security=True");
            con.Open();
            SqlCommand com1 = new SqlCommand("update utilizator set wallet=@mon where username=@name", con);

            com1.Parameters.AddWithValue("mon", this.money);
            com1.Parameters.AddWithValue("name", this.name);

            SqlDataReader reader1 = com1.ExecuteReader();
            con.Close();
        }


        public string getName()
        {
            return this.name;
        }
        public void setName(string n)
        {
            this.name = n;
        }


        public string getPass()
        {
            return this.pass;
        }
        public void setPass(string n)
        {
            this.pass = n;
        }

        public string getEmail()
        {
            return this.email;
        }
        public void setEmail(string n)
        {
            this.email = n;
        }

        public bool getAdmin()
        {
            return this.isAdmin;
        }
        public void setAdmin(bool p)
        {
            this.isAdmin = p;
        }

        
        public bool getPremium()
        {
            return this.hasPremium;
        }
        public void setPremium(bool p)
        {
            this.hasPremium = p;
        }

        public DateTime getPremiumTime()
        {
            return this.premiumUntil;
        }
        public void setPremiumTime(DateTime p)
        {
            this.premiumUntil = p;
        }


        /*
        override
        public string ToString()
        {
            return this.name + "," + this.pass + "," + this.isAdmin.ToString() + "," +
                this.hasPremium.ToString() + "," + this.money.ToString();

        }
        */



    }
}
