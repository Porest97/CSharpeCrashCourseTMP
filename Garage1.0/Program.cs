using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage1._0
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
                Year = 2010,
                TypOfVehicle = "Car",
                NumberOfEnignes = 1,
                CylinderVolume = 2050.92,
                NumberOfSeats = 5,
                Length = 6.92,
                Width = 2.23,
            };
            
            Airplane airplane = new Airplane()
            {
                Color = "Blue",
                LicenceNumber = "ZZF999",
                Make = "Look Head",
                WingSpan = 69.32,
                TypOfVehicle = "Airplane",
                NumberOfEnignes = 4,
                CylinderVolume = 0,
                NumberOfSeats = 590,
                Length = 23.92,
            };
            Bus bus = new Bus()
            {
                Color = "Blue",
                LicenceNumber = "SCO 111",
                Make = "Scania",
                Width = 2.21,
                DeploymentRoute = "school route 1",
                TypOfVehicle = "Bus",
                NumberOfEnignes = 1,
                CylinderVolume = 5032.19,
                NumberOfSeats = 39,
                Length = 14.92,
            };
            Boat boat = new Boat()
            {
                Color = "Green",
                LicenceNumber =  "OHOJ123",
                Make = "ASSA Atom",
                FuleType = "Diesel",
                Width = 19.21,
                TypOfVehicle = "Boat",
                WaterlineLength = 293.21,
                NumberOfEnignes = 8,
                NumberOfSeats = 1629,
                Length = 312.19,
                Weight = 316.92,


            };
            


            // Console.WriteLine("___________________________");

            Console.WriteLine(theCar.ToString());
            Console.WriteLine(airplane.ToString());
            Console.WriteLine(bus.ToString());
            Console.WriteLine(boat.ToString());

            //Console.WriteLine("____________________________");

            Console.WriteLine("===========The Car Starts !========================");

            theCar.Drive();
            theCar.Break();
            theCar.Drive();
            theCar.Break();
            theCar.Park();
            Console.WriteLine();
            Console.WriteLine("========The Airplane Takes OFF !===================");

            airplane.TakeOff();
            airplane.Fly();
            airplane.Land();
            Console.WriteLine();
            Console.WriteLine("========The Bus Starts !===================");

            bus.Drive();
            bus.Break();
            bus.Park();

            Console.WriteLine();
            Console.WriteLine("========The Boat Starts !===================");
            boat.LayOutFromTheQuay();
            boat.Sail();
            boat.Docking();
                       
            Console.WriteLine();
            Console.WriteLine("==================================================");
            Console.WriteLine("---------------------->Booom<---------------------");
            Console.WriteLine("------------------>We are done !<---------------------");

            Console.ReadLine();
            


        }
    }
}
