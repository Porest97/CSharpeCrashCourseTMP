using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceVsValueType
{
    class Program
    {
        static void ChangeValue(out int x)
        {
            x = 200;

            Console.WriteLine(x);
        }
        static void Main(string[] args)
        {
            int i = 100;

            Console.WriteLine(i);

            ChangeValue(out i);

            Console.WriteLine(i);

            Console.ReadLine();
        }
    }
}
