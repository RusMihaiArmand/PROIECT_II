using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class SportEvent
    {
        private int id;
        private string name;
        private byte[] img;
        private int totalPlaces;

        public SportEvent(int i, string n, byte[] im, int p)
        {
            this.id = i;
            this.name = n;
            this.img = im;
            this.totalPlaces = p;
        }

        public int getId()
        {
            return id;
        }
        public string getName()
        {
            return name;
        }
        public byte[] getImg()
        {
            return img;
        }
        public int getPlaces()
        {
            return totalPlaces;
        }

    }
}
