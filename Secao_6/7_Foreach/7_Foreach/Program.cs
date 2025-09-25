using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] vect = new string[] { "Maria", "Bob", "Alex" };

            foreach (string pessoa in vect)
            {
                Console.WriteLine(pessoa);
            }
        }
    }
}
