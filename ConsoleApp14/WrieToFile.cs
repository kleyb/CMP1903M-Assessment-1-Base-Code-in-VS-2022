using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    internal class WrieToFile
    {
        public void write(List<string> reportAsList)
        {
            Console.WriteLine("Would you like to print the report ?");
            if (Console.ReadLine() == "yes")
            {
                Console.WriteLine("Please write a name for the file");
                string fileName = Console.ReadLine();
                Console.WriteLine("Please enter a File Location");
                string fileLocation = Console.ReadLine();
                File.WriteAllLines(fileLocation + fileName + ".txt", reportAsList);
                Console.WriteLine("The Report has been printed ");
            }
        }
    }
}
