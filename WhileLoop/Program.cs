using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write the code : ");

            string codeAttempt = Console.ReadLine();

            while (codeAttempt != "SecretCode")
            {
                Console.WriteLine("Code incorrect");
                Console.WriteLine("Try Again");
                codeAttempt = Console.ReadLine();
            }
            Console.WriteLine("You got the right Code");
            Console.ReadLine();

        }
    }
}
