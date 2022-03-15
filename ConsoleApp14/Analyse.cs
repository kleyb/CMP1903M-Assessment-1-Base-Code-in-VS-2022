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
            //Iterates throufh the text
            foreach (string sentence in text)
            {                
                // Create a new char Array and converts every string in sentence to a char array
                char[] sentenceAsChar = sentence.ToCharArray();
                //Iterates through every char in the sentenceAsChar array
                foreach (char i in sentenceAsChar)
                {
                    //checks if any char from sentenceAsChar is also in the char list 'vowels' 
                    // if true , then it adds 1 to the values[1] index
                    if (vowels.Contains(i) || vowels.Contains(char.ToUpper(i)))
                    {
                        values[1]++;
                    }
                    // Checks if the char from sentenceAsChar is not punctuation , not a symbol and if its not an empty space 
                    // If not any of those 3 then it is a Consonant as if it was a vowel it would have been found in the previous if statment.
                    // then adds 1 to values[2] index
                    else if (!char.IsPunctuation(i) && !char.IsSymbol(i) && !char.IsWhiteSpace(i))
                    {
                        values[2]++;
                    }
                    // Created a new set of if statments so that they would have no relation with the previous on but it is is inside the same loop so to check the same char
                    // Checks if the char is a UpperCase , if true then adds 1 to the values[3] index
                    if (char.IsUpper(i))
                    {
                        values[3]++;
                    }
                    // check if the char is a LowerCase , if true then adds 1 to values[4]
                    else if (char.IsLower(i))
                    {
                        values[4]++;
                    }                                      
                }               
                
            }
            //Looks for an Empty or Null string in the list , if found , removes it , otherwise does nothing
            text.Remove(text.Find(string.IsNullOrEmpty));

            //Sets the number of sentences 
            values[0] = text.Count();
            
            return values;
        }
        public List<string> analyseLongWords (string input)
        {
            var text = new List<string>(input.Split("."));
            
            text.Remove(text.Find(string.IsNullOrEmpty));
            
            List<string> words = new List<string>();
            foreach (string sentence in text)
            {
                words.AddRange(sentence.Split(" "));
            }
            words.Remove(words.Find(string.IsNullOrEmpty));

            List<string> longWords = new List<string>();
            foreach (string word in words)
            {
                if (word.Count() > 7)
                {
                    longWords.Add(word);
                }
            }
            
            return longWords;
        }
    }
}
