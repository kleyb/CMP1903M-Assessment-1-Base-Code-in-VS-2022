using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Analyse
    {
        //Handles the analysis of text

        //Method: analyseText
        //Arguments: string
        //Returns: list of integers
        //Calculates and returns an analysis of the text
        public List<int> analyseText(string input)
        {
            List<string> vowels = new List<string>() { "A", "E", "I", "O", "U", "a", "e", "i", "o", "u" };

            var text = new List<string>(input.Split("."));

            //List of integers to hold the first five measurements:
            //1. Number of sentences
            //2. Number of vowels
            //3. Number of consonants
            //4. Number of upper case letters
            //5. Number of lower case letters
            List<int> values = new List<int>();
            //Initialise all the values in the list to '0'
            for (int i = 0; i < 5; i++)
            {
                values.Add(0);
            }
            //Sets the number of sentences 
            values[0] = text.Count();

            foreach (string sentence in text)
            {
                Console.WriteLine(sentence);
                Console.WriteLine(sentence.Length);
                for (int i = 0; i < sentence.Length; i++)
                {
                    
                    if (vowels.Contains(sentence[i].ToString()))
                    {
                        values[1]++;
                    }
                    else if (!vowels.Contains(sentence[i].ToString()))
                    {
                        values[2]++;
                    }
                }
                
            }
            //values.FindAll().ToString().ToUpper()
            //List<string> vowels = values.FindAll("A","E","I","O","U","a","e","i","o","u");
            //values[1] = vowels.Count();

            Console.WriteLine("Results");
            Console.WriteLine("Number of Sentences " + values[0]);
            Console.WriteLine("Number of Vowels " + values[1]);
            Console.WriteLine("Number of Consonants " + values[2]);
            return values;
        }
    }
}
