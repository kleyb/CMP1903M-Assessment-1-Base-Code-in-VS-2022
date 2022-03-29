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

        public List<string> outputConsole(List<int> values, Dictionary<char,int> frequency )
        {

            // Creates a new string lists , adds the value list with the meaning of each value into the List      
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

            //Private method , example of Encapsulation and Data Abstraction
            displayFrequency(frequency);
            
            //Return the report as a List of Strings
            return reportAsList;
        }
        // Private method that displayes the Frequency 
        private static void displayFrequency(Dictionary<char, int> frequency)
        {
            //ask if the user would like to see the frequency of letters
            Console.WriteLine("Would you also like to see the frequency of letters? Please enter 'Yes' to confirm, anything else to cancel ");
            //Check for the answer
            if ((Console.ReadLine().ToString().ToUpper()) == "YES")
            {
                //Creates a loop that looks at each pair of Char and Int in the Dictionary
                foreach (KeyValuePair<char, int> i in frequency)
                {
                    // Prints every Pair in each iteration 
                    Console.WriteLine(i.Key + " " + i.Value);
                }
            }
        }
    }
   
}
