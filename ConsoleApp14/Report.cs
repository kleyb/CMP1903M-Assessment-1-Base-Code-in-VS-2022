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
        //Maybe have different methods for different formats of output?
        //eg.   public void outputConsole(List<int>)

        public void outputConsole(List<int> values)
        {
            Console.WriteLine();
            Console.WriteLine("The text you have inserted has: ");
            Console.WriteLine("{0} Sentences " , values[0]);
            Console.WriteLine("{0} Vowels " ,values[1]);
            Console.WriteLine("{0} Consonants " ,values[2]);
            Console.WriteLine("{0} Upper Cases " , values[3]);
            Console.WriteLine("{0} Lower Cases " , values[4]);

        }
    }
}
