using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public int MaxEvents()
        {
            if (this.isAdmin)
                return 999;

            if (this.hasPremium)
                return 10;

            return 2;

        }
        

        public double GetMoney()
        {
            return this.money;
        }
        public void SetMoney(double n)
        {
            this.money = n;
        }
        public void AddMoney(double n)
        {

            SqlConnection con = new SqlConnection(Program.GetConString());
            con.Open();


            SqlCommand com1 = new SqlCommand("update utilizator set wallet=@mon where username=@name", con);
            SqlTransaction tx = con.BeginTransaction();

            try
            {
                com1.Transaction = tx;
                com1.Parameters.AddWithValue("mon", this.money+n);
                com1.Parameters.AddWithValue("name", this.name);
                com1.ExecuteNonQuery();
                tx.Commit();
                this.money = this.money + n;
                MessageBox.Show("Money added", "Message");

            }
            catch (Exception)
            {
                tx.Rollback();
                MessageBox.Show("Error; no money added", "Message");
            }
            finally
            {
                con.Close();
            }
        }


        public string GetName()
        {
            return this.name;
        }
        public void SetName(string n)
        {
            this.name = n;
        }


        public string GetPass()
        {
            return this.pass;
        }
        public void SetPass(string n)
        {
            this.pass = n;
        }

        public string GetEmail()
        {
            return this.email;
        }
        public void SetEmail(string n)
        {
            this.email = n;
        }

        public bool GetAdmin()
        {
            return this.isAdmin;
        }
        public void SetAdmin(bool p)
        {
            this.isAdmin = p;
        }

        
        public bool GetPremium()
        {
            return this.hasPremium;
        }
        public void SetPremium(bool p)
        {
            this.hasPremium = p;
        }

        public DateTime GetPremiumTime()
        {
            return this.premiumUntil;
        }
        public void SetPremiumTime(DateTime p)
        {
            this.premiumUntil = p;
        }

    }
}
