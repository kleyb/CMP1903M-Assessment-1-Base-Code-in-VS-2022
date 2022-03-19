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
        public string fileTextInput(string fileName)
        {
            string text = System.IO.File.ReadAllText(fileName);

            return text;
        }

    }
}
