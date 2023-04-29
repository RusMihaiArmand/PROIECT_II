using System;
using System.Collections.Generic;
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

        
        public Account(string n, string p, string em, double mone, bool a)
        {
            this.name = n;
            this.pass = p;
            this.email = em;
            
            this.money = mone;
            this.isAdmin = a;
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

        /*
        public bool getPremium()
        {
            return this.hasPremium;
        }
        public void setPremium(bool p)
        {
            this.hasPremium = p;
        }


        
        

        override
        public string ToString()
        {
            return this.name + "," + this.pass + "," + this.isAdmin.ToString() + "," +
                this.hasPremium.ToString() + "," + this.money.ToString();

        }
        */



    }
}
