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
            bool loop = true;

            while (loop == true)
            {
                Console.WriteLine("Do you want to enter the text via the keyboard? Please enter 'Yes or No' ");
                if ((option = Console.ReadLine().ToString().ToLower()) == "yes")
                {
                    Input keyboardInput = new();
                    text = keyboardInput.manualTextInput();
                    break;
                }
                Console.WriteLine("Do you want to read in the text from a file? Please enter 'Yes or No' ");

                if ((option2 = Console.ReadLine().ToString().ToLower()) == "yes")
                {
                    Input keyboardInput = new();
                    Console.WriteLine("Please enter the File location: ");
                    text = keyboardInput.fileTextInput(Console.ReadLine());
                    loop = false;
                }
                else
                {
                    Console.WriteLine("You have entered 'No' on both options. Please select how would you like to enter your text");                    
                }                
            }
            Console.WriteLine(text);

            // Create a new Analyse Object
            Analyse analyseObj = new Analyse();
            
            //Passes the text into the analyseText the AnalyseObj, receives the list of measuments  
            parameters = analyseObj.analyseText(text);
            
            //Created a list of long words , longer than 7 characters 
            List<string> longwords = analyseObj.analyseLongWords(text);

            // Analyses the Text and returns a list of frequency of letters
            //Returns a dictionary and stores it into frequency
            Dictionary<char,int> frequency = analyseObj.frequency(text);

            //Created a new Report obj, which will report the result of the Analyses
            //The report Obj prints the Report to the console and returns a list 
            Report report = new Report();            
            List<string> reportAsList = report.outputConsole(parameters,frequency) ;
            
            //The WriteToFile Object allows the Report to printed inot a text File
            WrieToFile writeToFile = new WrieToFile();
            //Prints report into a text File
            writeToFile.write(reportAsList);

            

            Console.ReadKey();
        }


    }
}
