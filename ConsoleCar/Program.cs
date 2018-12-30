using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarConsole.Model;

namespace CarConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Car theCar = new Car()
            {
                Color = "Seashell",
                LicenceNumber = "NTB 441",
                Make = "Volvo",
                Year = 2010
            };
           
            
            
            // Console.WriteLine("___________________________");

            Console.WriteLine(theCar.ToString());
           

            //Console.WriteLine("____________________________");
           
            theCar.Drive();
            theCar.Break();
            theCar.Drive();
            theCar.Break();
            Console.WriteLine("==================================================");
            Console.WriteLine("---------------------->Booom<---------------------");
            Console.WriteLine("------------------>We are done !<---------------------");

            Console.ReadLine();
        }
    }
}
