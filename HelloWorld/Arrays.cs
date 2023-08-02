using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Arrays
    {
        static void Main(string[] args)
        {
            string[] friends = { "Mike", "Harvey", "Jessica", "Louis", "Donna" };

            foreach (string friend in friends)
            {
                Console.WriteLine("Hello {0}", friend);
            }

            Console.ReadKey();
        }
    }
}
