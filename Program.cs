using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Firma firma = new Firma();
            firma.Set_ALL("privet", 2.0, 2.0);
            firma.Write();
            Console.ReadKey(true);
            Console.ReadKey();
            Console.ReadLine();
        }
    }
}
