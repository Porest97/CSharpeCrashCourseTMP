﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("type a number");

            string theNumberAsAString = Console.ReadLine();
            int theNumber;
            if(int.TryParse(theNumberAsAString, out theNumber))
            {
                Console.WriteLine("the number was " + theNumber);
            }
            else
            {
                Console.WriteLine("This is not a Number of the type int, this is a string, float or double !");
                // Console.WriteLine("You wrote => " + theNumber + " Witch means that we have to convert the type !");
            }
            
            Console.ReadLine();
        }
    }
}
