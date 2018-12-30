using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage1._0
{
    class Bus : Vehicle
    {
        public string DeploymentRoute { get; set; }
        public void Drive()
        {
            Console.WriteLine("Wrooom");
        }

        public void Break()
        {
            Console.WriteLine("eeehehhhhhhehhhhh");
        }
        public void Park()
        {
            Console.WriteLine("Parking========>Booom===>I´m parked !");
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
            sb.Append("Typ Of Vehcle: ").Append("\t").Append("\t");
            sb.AppendLine(TypOfVehicle);
            sb.Append("Deployment Route: ").Append("\t").Append("\t");
            sb.AppendLine(DeploymentRoute.ToString());
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
            sb.Append("Cylinder Volume: ").Append("\t").Append("\t");
            sb.AppendLine(CylinderVolume.ToString());
            sb.Append("Number Of Engins: ").Append("\t").Append("\t");
            sb.AppendLine(NumberOfEnignes.ToString());
            sb.Append("Number Of Seats: ").Append("\t").Append("\t");
            sb.AppendLine(NumberOfSeats.ToString());
            sb.Append("===================================");
            return sb.ToString();

        }

    }
}
