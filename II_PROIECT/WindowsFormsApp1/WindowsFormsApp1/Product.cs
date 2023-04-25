using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Product
    {
        
        private int code;
        private int price;
        private string name;
        private string photoName;
        private int quantity;
        private double score;
        private string description;

        public Product(int c, int p, string n, string ph, int q, double sc, string des)
        {
            this.code = c;
            this.price = p;
            this.name = n;
            this.photoName = ph;
            this.quantity = q;
            this.score = sc;
            this.description = des;

        }

        public Product()
        {
            this.code = 0;
            this.price = 0;
            this.name = "";
            this.photoName = "";
            this.quantity = 0;
            this.score = 0;
            this.description = "";

        }

        public int getCode()
        {
            return this.code;
        }
        public void setCode(int c)
        {
            this.code = c;
        }

        public int getPrice()
        {
            return this.price;
        }
        public void setPrice(int p)
        {
            this.price = p;
        }

        public int getQuantity()
        {
            return this.quantity;
        }
        public void setQuantity(int q)
        {
            this.quantity = q;
        }

        public string getName()
        {
            return this.name;
        }
        public void setName(string n)
        {
            this.name = n;
        }

        public string getDescription()
        {
            return this.description;
        }
        public void setDescription(string d)
        {
            this.description = d;
        }

        public string getPhotoName()
        {
            return this.photoName;
        }
        public void setPhotoName(string p)
        {
            this.photoName = p;
        }

        public double getScore()
        {
            return this.score;
        }
        public void setScore(double s)
        {
            this.score = s;
        }

        override
        public string ToString()
        {
            return this.code + "," + this.price + "," + this.name + "," +
                this.photoName + "," + this.quantity + "," + this.score + ","
                +this.description;

        }

    }
}
