using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vvedi vosrast");
            string a = Console.ReadLine();
            int b = Convert.ToInt32((string)a);
            Console.WriteLine(b * 2);
            Console.ReadKey();
        }
    }
}
