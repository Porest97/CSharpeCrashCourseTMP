using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloSomethingNotWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello dude !");
            Console.WriteLine("Now You write something !");
            var input = Console.ReadLine();
            Console.WriteLine("Hello dude You wrote => " + input);
            Console.ReadLine();
        }
    }
}
