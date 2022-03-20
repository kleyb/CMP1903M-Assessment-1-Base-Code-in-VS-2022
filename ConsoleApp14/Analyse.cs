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
                    if (vowels.Contains(char.ToUpper(i)))
                    {
                        values[1]++;
                    }
                    // Checks if the char from sentenceAsChar is not punctuation , not a symbol and if its not an empty space 
                    // If not any of those 3 then it is a Consonant as if it was a vowel it would have been found in the previous if statment.
                    // then adds 1 to values[2] index
                    else if (char.IsLetter(i) && !vowels.Contains(char.ToUpper(i)))
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
        //Creates a list of long words , words longer than 7 
        public List<string> analyseLongWords (string input)
        {
            //Splits the input by '.' and assigns to the list text
            var text = new List<string>(input.Split("."));
            
            //Removes any empty or null indexes
            text.Remove(text.Find(string.IsNullOrEmpty));
            
            // Creates a new list of words
            List<string> words = new List<string>();
            
            // Loops thorugh the text
            foreach (string sentence in text)
            {
                //Splits the sentences by " " and addes the splitted list into words
                words.AddRange(sentence.Split(" "));                
            }
            //Removes any null or Empty space in the list
            words.Remove(words.Find(string.IsNullOrWhiteSpace));

            //Goes Thorugh the list words
            for (int i = 0; i < words.Count(); i++)
            {
                // Finds puntuation at the index words[i] and replaces the puntuation with ""
                words[i] = System.Text.RegularExpressions.Regex.Replace(words[i], @"[^\w\d\s]", "");
            }            

            //Creates a new list that will store the new values
            List<string> longWords = new List<string>();
            // Goes through the list in words
            foreach (string word in words)
            {
                //if the word is longer than 7 characters it addes it inot the longWords list
                if (word.Count() > 7)
                {
                    longWords.Add(word);
                }
            }
            //Returns longWords list
            return longWords;
        }
       //Creates a Dictionary to count the frequency of letters
        public Dictionary<char,int> frequency (string input)
        {
            //Declares a new dictionary with char as its key and int as values
            Dictionary<char, int> frequency = new Dictionary<char, int>();
            //takes the text and splits per sentence
            var text = new List<string>(input.Split("."));
            //removes any null or empty sentences
            text.Remove(text.Find(string.IsNullOrEmpty));
            // Iterates through the text
            foreach (string sentence in text)
            {
                // Converts each sentence into an Array of Chars and makes it uppercase 
                char[] sentenceAsChar = sentence.ToUpper().ToCharArray();
                //Iterates thorough the char Array
                foreach (char c in sentenceAsChar)
                {
                    //if there is already a key with current char , it adds 1 to the value
                    if (frequency.ContainsKey(c) && char.IsLetter(c))
                    {
                        frequency[c]++;
                    }
                    // if there is not key corresponding to the current char , it adds a new key with it and 1 as it's value
                    else if (!frequency.ContainsKey(c) && char.IsLetter(c))
                    {
                        frequency.Add(c, 1);
                    }
                }
            }
            // Returns the dictionary 
            return frequency;
        }
    }
}
