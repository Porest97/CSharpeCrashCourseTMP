using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage1._0
{
    class Airplane : Vehicle
    {
        public double WingSpan { get; set; }



        //public void Break()
        //{
        //    Console.WriteLine("eeehehhhhhhehhhhh");
        //}
        public void TakeOff()
        {
            Console.WriteLine("Please fasten your seatbelts....Whroaaaaaa!");
        }
        public void Fly()
        {
            Console.WriteLine("We are flying @ 12000 feet and having a speed of 600 N/hour !");
        }
        public void Land()
        {
            Console.WriteLine("We are going in for landing at LAX and ask all the passangers to remain in there seats with there seatbelts on until the green sign lights up !");
            Console.WriteLine("==================>EAAAHHHHHHHEEEEEEEEE!!!!!=======> BOOOM ! Welcome to LA ;) ");
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
            sb.Append("Typ Of Vehcle:").Append("\t\t");
            sb.AppendLine(TypOfVehicle);
            sb.Append("Make:").Append("\t\t\t");
            sb.AppendLine(Make);
            sb.Append("Licence Number:").Append("\t\t");
            sb.AppendLine(LicenceNumber);
            sb.Append("Color:").Append("\t\t\t");
            sb.AppendLine(Color);
            sb.Append("Wing Span:").Append("\t\t");
            sb.AppendLine(WingSpan.ToString());
            sb.Append("Legth:").Append("\t\t\t");
            sb.AppendLine(Length.ToString());
            sb.Append("Cylinder Volume:").Append("\t");
            sb.AppendLine(CylinderVolume.ToString());
            sb.Append("Number Of Engins:").Append("\t");
            sb.AppendLine(NumberOfEnignes.ToString());
            sb.Append("Number Of Seats:").Append("\t");
            sb.AppendLine(NumberOfSeats.ToString());
            sb.Append("===================================");
            return sb.ToString();

        }
    }
}
