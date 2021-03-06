﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarConsole.Model;

namespace CarConsole.Model
{
    public class Car
    {

        public string Make { get; set; }
        public int Year { get; set; }
        public string LicenceNumber { get; set; }
        public string Color { get; set; }

        public void Drive()
        {
            Console.WriteLine("Wrooom");
        }

        public void Break()
        {
            Console.WriteLine("eeehehhhhhhehhhhh");
        }

        public int AccidentCount()
        {
            return 29;
        }

        // public override string ToString()
        // {
        //    return "Year: " + Year + " Make: " + Make + " Color: " + Color + " LicenceNumber: " + LicenceNumber;
        // }

         public override string ToString()
         {
            Console.WriteLine("==================================");
            StringBuilder sb = new StringBuilder();
            sb.Append("Year: ").Append("\t").Append("\t");
            sb.AppendLine(Year.ToString());
            sb.Append("Make: ").Append("\t").Append("\t");
            sb.AppendLine(Make);
            sb.Append("LicenceNumber: ").Append("\t");
            sb.AppendLine(LicenceNumber);
            sb.Append("Color: ").Append("\t").Append("\t");
            sb.AppendLine(Color);
            sb.Append("===================================");            
            return sb.ToString();
         } 

    }
}
