using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WriteToFile
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstFilelist = new List<string>();
            var secondFilelist = new List<string>();
            var resultFilelist = new List<string>();
            readFirstList(firstFilelist);
            readSecondList(secondFilelist);
            //here
            //here
            Console.ReadLine();
        }
        private static List<string> readFirstList(List<string> firstList)
        {

            string currentLineInFile;
            string firstFileLocation = null;
            firstFileLocation = "c:/" + "firstFile" + ".txt";
            System.IO.StreamReader firstFile = new System.IO.StreamReader(firstFileLocation);

            while ((currentLineInFile = firstFile.ReadLine()) != null)
            {
                firstList.Add(currentLineInFile.ToUpper());
            }
            firstFile.Close();
            return firstList;
        }
        private static List<string> readSecondList(List<string> secondList)
        {

            string currentLineInFile;
            string secondFileLocation = null;
            secondFileLocation = "c:/" + "secondFile" + ".txt";
            System.IO.StreamReader secondFile = new System.IO.StreamReader(secondFileLocation);

            while ((currentLineInFile = secondFile.ReadLine()) != null)
            {
                secondList.Add(currentLineInFile.ToUpper());
            }
            secondFile.Close();
            return secondList;
        }
        private static List<string> searchForResults(List<string> firstList, List<string> secondList, List<string> returnResults)
        {
            int searchSelection;
            string searchedItem;
            Console.WriteLine("What type of data are you searching for?");
            Console.WriteLine("1. Search for Name");
            Console.WriteLine("2. Search for street address");
            Console.WriteLine("3. Search for City Locations");
            Console.WriteLine("4. Search for State Locations");
            Console.WriteLine("5. Search for Zip code Locations");
            searchSelection = Convert.ToInt32(Console.ReadLine());

            switch (searchSelection)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                default:
                    break;
                
            }
            return returnResults;
        }
    }
}
