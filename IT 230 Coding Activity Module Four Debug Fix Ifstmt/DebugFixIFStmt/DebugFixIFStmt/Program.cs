/* The program is to print values of three ordered integers variables (firstChoice, secondChoice, thirdChoice) 
   only when the values are not zero. If the value is zero for any integer, the program does not print it. 
   Additionally, a value of zero is only possible if the preceding value is non-zero in the order of the variables. 
   For example, secondChoice can have a value of zero only if firstChoice has a non-zero value. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebugFixIFStmt
{
    class Program
    {
        static void Main(string[] args)
        {
            (new Program()).run();
        }


        void run()
        {
            int firstChoice = 0, secondChoice = 0, thirdChoice = 0;

            System.Console.WriteLine("Giles Copy");

            firstChoice = 0; secondChoice = 0; thirdChoice = 0;
            WriteCurrentChoices(firstChoice, secondChoice, thirdChoice);

            firstChoice = 2; secondChoice = 0; thirdChoice = 0;
            WriteCurrentChoices(firstChoice, secondChoice, thirdChoice);

            firstChoice = 2; secondChoice = 5; thirdChoice = 0;
            WriteCurrentChoices(firstChoice, secondChoice, thirdChoice);

            firstChoice = 2; secondChoice = 5; thirdChoice = 7;
            WriteCurrentChoices(firstChoice, secondChoice, thirdChoice);

            Console.WriteLine("Press any key to continue...");
            Console.ReadLine(); // added to force system pause
        }


        void WriteCurrentChoices(int firstChoice, int secondChoice, int thirdChoice)
        {
            if (firstChoice == 0) // corrected parameter choice to sequence, begin with firstChoice
                Console.WriteLine("Choices are: {0}, {1}, {2} => There are no choices yet", firstChoice, secondChoice, thirdChoice);
            else if (secondChoice == 0) // added the second =, so that secondChoice would check if true
                Console.WriteLine("Choices are: {0}, {1}, {2} => Currently choices are {0}", firstChoice, secondChoice, thirdChoice, firstChoice);
            else if (thirdChoice == 0) // removed the extra =
                Console.WriteLine("Choices are: {0}, {1}, {2} => Currently choices are {0}, {1}", firstChoice, secondChoice, thirdChoice, firstChoice, secondChoice);
            else if(thirdChoice != 0 ) // was rechecking the thirdChoice variable again, needed to be changed to if not equal to 0
                Console.WriteLine("Choices are: {0}, {1}, {2} => Currently choices are {0}, {1}, {2}",
                    firstChoice, secondChoice, thirdChoice, firstChoice, secondChoice, thirdChoice);
        }
    }
}
