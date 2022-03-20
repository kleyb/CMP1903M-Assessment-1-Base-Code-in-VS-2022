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
        public void write(List<string> reportAsList, Dictionary<char,int> frequency)
        {   // Asks the user if he wants to print the report , if no then nothing is done
            Console.WriteLine("Would you like to print the report ? Please enter 'Yes' to confirm, anything else to cancel ");
            if (Console.ReadLine().ToString().ToUpper() == "YES")
            {   
                // Asks the user to give the file a name and stores it into fileName
                Console.WriteLine("Please write a name for the file");
                string fileName = Console.ReadLine();
                
                // Asks the user to indicated the location for the file, stores into fileLocation
                Console.WriteLine("Please enter a File Location");
                string fileLocation = Console.ReadLine();
                
                //Using System.IO writes all lines of the List into the the file (filelocation\filaName.txt )
                File.WriteAllLines(fileLocation + fileName + ".txt", reportAsList);
                
                //Display that the file has been printed sucessfully 
                Console.WriteLine("The Report has been printed at the indicated location ");

                //Ask the user if he wants to add the frequency of letters into the report
                Console.WriteLine("Would you also like to add the frequency to your report? Please enter 'Yes' to confirm, anything else to cancel ");
                if (Console.ReadLine().ToString().ToUpper() == "YES")
                {
                   //Iterates through the dictionary pairs of keys and values
                    foreach (KeyValuePair<char,int> i in frequency)
                    {                   
                        // Appends to the files previous created , the keys and pairs, each pair in a single line
                        File.AppendAllText(fileLocation + fileName + ".txt", i.Key.ToString() + " " + i.Value.ToString() + "\n");
                    };
                }
            }            
        }
        
        //Prints a file with words longer than 7 characters 
        public void writeLongWords (List<string> longWords)
        {
            //if there isnt an empty list
            if (longWords.Count() > 0)
            {
                // If there is a file in this location with the current name it appends, otherwise creates a new one
                // Appends all lines of the longWords list into the location of the current directory 
                File.AppendAllLines(AppDomain.CurrentDomain.BaseDirectory + "long words.txt", longWords);
                //Displays to the user the location to which the file has been created
                Console.WriteLine("A file 'long words.txt' has been created and placed at {0} ",AppDomain.CurrentDomain.BaseDirectory);
            }
            else // if there is no long words in the longWords list , displays a message to the user
            {
                Console.WriteLine("There are no words longer than 7 Characters, therefore a longWords File has not been created ");
            }
        }

    }
}
