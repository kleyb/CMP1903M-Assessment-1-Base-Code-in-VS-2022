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
            List<char> vowels = new List<char>() { 'A','E','I','O','U' };

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
                char[] senteceAsChar = sentence.ToCharArray();
                foreach (char i in senteceAsChar)
                {
                    if (vowels.Contains(i) || vowels.Contains(char.ToUpper(i)))
                    {
                        values[1]++;
                    }
                    else if (!char.IsPunctuation(i) && !char.IsSymbol(i) && !char.IsWhiteSpace(i))
                    {
                        values[2]++;
                    }

                    if (char.IsUpper(i))
                    {
                        values[3]++;
                    }
                    else if (char.IsLower(i))
                    {
                        values[4]++;
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
            Console.WriteLine("Number of Upper Cases " + values[3]);
            Console.WriteLine("Number of Lower Cases " + values[4]);
            return values;
        }
    }
}
