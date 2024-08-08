using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebugFixMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            (new Program()).Run(); // Although it worked, did not follow best practices for run to be lowercase
        }


        void Run() // Although it worked, did not follow best practices for run to be lowercase
        {
            int choice = 0;

            WritePrompt();
            choice = ReadChoice();
            WriteChoice(choice);
            Console.ReadLine(); // Force pause on screen
        }

        void WritePrompt() // C# is case sensitive, and Writeprompt did not call WritePrompt
        {
            Console.WriteLine("Giles: Please select a course for which you want to register by typing the number inside []");
            Console.WriteLine("[1]IT 145\n[2]IT 200\n[3]IT 201\n[4]IT 270\n[5]IT 315\n[6]IT 328\n[7]IT 330");
            Console.Write("Enter your choice : ");
        }

        int ReadChoice()
        {
            string s = "";
            s = Console.ReadLine();
            return (Int32.Parse(s)); // Converting string to integer
        }

        void WriteChoice(int choice) // Specified variable type
        {
            Console.WriteLine("Your choice is {0}", choice); // C in choice was capitalized, C# is case sensitive
            Console.WriteLine("Press any key to continue..."); // added to match the desired output per instructions
        }

    }
}
