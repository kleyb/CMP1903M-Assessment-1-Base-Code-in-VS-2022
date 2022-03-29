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
            bool loop = true;

            //Local list of integers to hold the first five measurements of the text
            List<int> parameters = new List<int>();

            // Create a new Analyse Object
            Analyse analyseObj = new Analyse();

            //The WriteToFile Object allows the Report to printed into a text file
            WrieToFile writeToFile = new WrieToFile();

            //Created a new Report obj, which will report the result of the Analyses
            Report report = new Report();            

            // A loop is used to keep the questions being asked if no valid inputs are entered 
            while (loop == true)
            {
                Console.WriteLine("Do you want to enter the text via the keyboard? Please enter 'Yes or No' ");
                // takes the input from the user ,converts it string , and into a lower case .Then it stores into option
                // then it checks if that is equal to the string "yes" , if it is , it then executes the code inside the if statement 
                if ((option = Console.ReadLine().ToString().ToLower()) == "yes")
                {
                    //Create a new keyboardInput Obj
                    Input keyboardInput = new();
                    
                    //Stores what is returned from keyboardInput.manualTextInput into text
                    text = keyboardInput.manualTextInput();
                    
                    //Breaks out of the loop and continues the program
                    break;
                }
                Console.WriteLine("Do you want to read in the text from a file? Please enter 'Yes or No' ");

                // takes the input from the user ,converts it string , and into a lower case .Then it stores into option2
                // then it checks if that is equal to the string "yes" , if it is , it then executes the code inside the if statement 
                if ((option2 = Console.ReadLine().ToString().ToLower()) == "yes")
                {
                    //Creates a new keyboard Obj
                    Input keyboardInput = new();
                    
                    // Stores what is returned from the object method into text
                    text = keyboardInput.fileTextInput();
                    
                    // makes loop false which ends the loop
                    loop = false;
                }
                //if the user enters No on both question , display what is inside the if statement 
                else if (option == "no" && option2 == "no")
	            {
                    Console.WriteLine("You have entered 'No' on both options. Please select how would you like to enter your text");
	            }
                else // if the use enter a invalid input , displays 
                {
                    Console.WriteLine("You have entered a invalid input on one or both of the questions. Please enter 'Yes or No'" );
                }                
            }
            //Display the text the user entered
            Console.WriteLine(text);

            //Passes the text into the analyseText the AnalyseObj, receives the list of measuments  
            parameters = analyseObj.analyseText(text);
            
            // Analyses the Text and returns a list of frequency of letters
            //Returns a dictionary and stores it into frequency
            Dictionary<char,int> frequency = analyseObj.frequency(text);
                        
            //The report Obj prints the Report to the console and returns a list                        
            List<string> reportAsList = report.outputConsole(parameters,frequency) ;            

            //Prints report into a text File
            writeToFile.write(reportAsList,frequency);

            if (loop == false)
            {
                //Created a list of long words , longer than 7 characters 
                List<string> longwords = analyseObj.analyseLongWords(text);

                //Creates a File of longWords
                writeToFile.writeLongWords(longwords);
            }
            Console.ReadKey();
        }


    }
}
