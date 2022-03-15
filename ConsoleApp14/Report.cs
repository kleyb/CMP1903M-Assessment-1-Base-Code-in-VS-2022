using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Report
    {
        //Handles the reporting of the analysis
        //Maybe have different methods for different formats of output?
        //eg.   public void outputConsole(List<int>)

        public List<string> outputConsole(List<int> values)
        {   // Creates a new string lists , adds the value list with the meaning of each value into the List      
            List<string> reportAsList = new List<string>
            {
                "The text you have inserted has: ",
                values[0] + " Sentences ",
                values[1] + " Vowels ",
                values[2] + " Consonants ",
                values[3] + " Upper Cases ",
                values[4] + " Lower Cases "
            };
            //Loops through the list and display it's elements 
            foreach (string line in reportAsList)
            {
                Console.WriteLine(line);
            }
            //Return the report as a List of Strings
            return reportAsList;
        }
        
    }
   
}
