using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capybara
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i<n; i+=3)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
