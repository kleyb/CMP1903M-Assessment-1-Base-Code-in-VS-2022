//Base code project for CMP1903M Assessment 1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    class Program
    {
        static void Main()
        {
            string text = "";
            string option = "";
            string option2 = "";

            //Local list of integers to hold the first five measurements of the text
            List<int> parameters = new List<int>();

            //Create 'Input' object
            //Get either manually entered text, or text from a file
            Console.WriteLine("Do you want to enter the text via the keyboard? ");

            if ((option = Console.ReadLine()) == "yes")
            {
                Input keyboardInput = new();
                text = keyboardInput.manualTextInput();
            }
            Console.WriteLine("Do you want to read in the text from a file? ");

            if (option == "no" & (option2 = Console.ReadLine()) == "yes")
            {
                Input keyboardInput = new();
                text = keyboardInput.fileTextInput(Console.ReadLine());
            }
           

            //Create an 'Analyse' object
            //Pass the text input to the 'analyseText' method

            Analyse analyseObj = new Analyse();
            
            //Receive a list of integers back
            parameters = analyseObj.analyseText(text);
            
            //Report the results of the analysis
            Report report = new Report();
            Console.WriteLine(text);
            report.outputConsole(parameters);

            //TO ADD: Get the frequency of individual letters?

            Console.ReadKey();
        }


    }
}
