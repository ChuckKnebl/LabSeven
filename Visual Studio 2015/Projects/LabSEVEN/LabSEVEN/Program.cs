using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSEVEN
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean run = true;
            while (run == true)
            {
                Console.WriteLine("WELCOME TO OUR C# CLASS.  Please type print to view a list of students: ");
                string input = Console.ReadLine();

                //Provides list of student names.
                List<string> studentNames = new List<string>();
                studentNames.Add("Chuck Knebl");
                studentNames.Add("Anne Buckleitner");
                studentNames.Add("Claire Knebl");
                studentNames.Add("Julia Knebl");
                studentNames.Add("Mike Buckleitner");
                studentNames.Add("Chris Buckleitner");
                studentNames.Add("Ed McAtee");
                studentNames.Add("Carol Buckleitner");

                //Provides if statement to capture input from user.
                if (input == "print")
                
                    //Provides foreach loop to display list of student names.

                foreach (string name in studentNames)
                {
                    Console.WriteLine(name);
                }

                ///Provides option for user to continue.
                Console.WriteLine("Continue ? y / n");
                string answer = Console.ReadLine();
                if (answer == "y")
                {
                    run = true;
                }

                else if (answer == "n")
                {
                    run = false;
                    Console.WriteLine("Good Bye.");
                }
            }

        }
    }
}
        
        

