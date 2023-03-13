using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UP
{
    internal class Firma
    {
        private string name;
        private double area;
        private double lenght;

        public string Name
        {
            get
            {
                return name; 
            }
            set
            {
                name = value;
            }
        }

        public double Area
        {
            get
            {
                return area;
            }
            set
            {
                area = value;
            }
        }

        public double Lenght
        {
            get
            {
                return lenght;
            }
            set
            {
                lenght = value;
            }
        }

        public Firma() {
            name = "";
            area = 0;
            lenght = 0;
        }



        public Firma(string n, double a, double l)
        {
            name = n;
            area = a;
            lenght = l;
        }

        public void Set_ALL(string n, double a, double l)
        {
            Name = n;
            Area = a;
            Lenght = l;
        }

        public void Write()
        {
            Console.WriteLine($"Адрес :'{Name}'");
            Console.WriteLine($"Площадь :'{Area}'");
            Console.WriteLine($"Длина :'{Lenght}'");
        }
    }
}
