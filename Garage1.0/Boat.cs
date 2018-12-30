using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage1._0
{
    class Boat : Vehicle
    {
        public double WaterlineLength { get; set; }
        public double Weight { get; set; }

        public void LayOutFromTheQuay()
        {
            Console.WriteLine("X=========Clear Ship, ship ohoj!======@Sea===>");
        }
        public void Sail()
        {
            Console.WriteLine(">======Clear sky and a calm sea, we are doing 10 knots/hour, ship Ohoj!==>");
        }
        public void Docking()
        {
            Console.WriteLine(">====Land in site, prepare to dock====Docking===Boom==Docked in to a parkingspace for boats called Quay!==X");
        }
        public override string ToString()
        {
            Console.WriteLine("==================================");
            StringBuilder sb = new StringBuilder();
            sb.Append("Typ Of Vehcle: ").Append("\t").Append("\t");
            sb.AppendLine(TypOfVehicle);
            sb.Append("Waterline Leght: ").Append("\t").Append("\t");
            sb.AppendLine(WaterlineLength.ToString());
            sb.Append("Make: ").Append("\t").Append("\t");
            sb.AppendLine(Make);
            sb.Append("LicenceNumber: ").Append("\t");
            sb.AppendLine(LicenceNumber);
            sb.Append("Color: ").Append("\t").Append("\t");
            sb.AppendLine(Color);
            sb.Append("Width: ").Append("\t").Append("\t");
            sb.AppendLine(Width.ToString());
            sb.Append("Legth: ").Append("\t").Append("\t");
            sb.AppendLine(Length.ToString());
            sb.Append("Weight in deadweight: ").Append("\t").Append("\t");
            sb.AppendLine(Weight.ToString());
            sb.Append("Number Of Engins: ").Append("\t").Append("\t");
            sb.AppendLine(NumberOfEnignes.ToString());
            sb.Append("Number Of Passangers: ").Append("\t").Append("\t");
            sb.AppendLine(NumberOfSeats.ToString());
            sb.Append("===================================");
            return sb.ToString();

        }


    }
}
