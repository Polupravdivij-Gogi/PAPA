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
            Console.WriteLine(firma.Name);
            Console.WriteLine(firma.Area);


            Console.ReadKey(true);
            Console.ReadKey();
            Console.ReadLine();
        }
    }
}
