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
        {   // Asks the user if he wants to print the report , if no then nothing is done
            Console.WriteLine("Would you like to print the report ?");
            if (Console.ReadLine() == "yes")
            {   // Asks the user to give the file a name and stores it into fileName
                Console.WriteLine("Please write a name for the file");
                string fileName = Console.ReadLine();
                // Asks the user to indicated the location for the file, stores into fileLocation
                Console.WriteLine("Please enter a File Location");
                string fileLocation = Console.ReadLine();
                //Using System.IO writes all lines of the List into the the file (filelocation\filaName.txt )
                File.WriteAllLines(fileLocation + fileName + ".txt", reportAsList);
                //Display that the file has been printed sucessfully 
                Console.WriteLine("The Report has been printed ");
            }
        }
    }
}
