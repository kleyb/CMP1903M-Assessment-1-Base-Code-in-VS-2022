using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CMP1903M_Assessment_1_Base_Code
{
    public class Input
    {
        //Handles the text input for Assessment 1



        //Method: manualTextInput
        //Arguments: none
        //Returns: string
        //Gets text input from the keyboard

        public string manualTextInput()
        {
            Console.WriteLine("Please enter your sentence: ");
            string text = Console.ReadLine();

            return text;

        }

        //Method: fileTextInput
        //Arguments: string (the file path)
        //Returns: string
        //Gets text input from a .txt file
        public string fileTextInput()
        {
            string text;
            //Loop keeps to keep asking for an input
            while (true)
            {                
                //Tries to open and read the file at the indicated location by the user
                try
                {
                    Console.WriteLine("Please enter the File location: ");
                    // Open and read the file at the indicated location , then stores at the variable text
                    text = System.IO.File.ReadAllText(Console.ReadLine());
                    break;
                }
                //if the indicated location is not valid , an error is shown and then the loop continues
                catch (Exception)
                {
                    Console.WriteLine("The Location is not valid , please enter a valid location");
                    continue;
                }
            }
            //Return the text
            return text;
        }

    }
}
