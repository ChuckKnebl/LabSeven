using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Seven_B
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean run = true;
            while(run == true)
            {
                Console.WriteLine("Welcome to our C# class.  Please type 'print' to view a class list: ");
                string input = Console.ReadLine();
                
                //Using list to name students.
                List<string> studentNames = new List<string>();
                studentNames.Add("Albert Einstein");
                studentNames.Add("George Washington");
                studentNames.Add("Aristotle");
                studentNames.Add("Robert Redford");
                studentNames.Add("Carl Bernstein");
                studentNames.Add("Bob Woodward");
                studentNames.Add("Dan Rather");
                studentNames.Add("Shaquelle O'Neal");
                studentNames.Add("LaBron James");

                //Using if statement to confirm user input.
                if (input == "print")

                //Using for loop to iterate through list and print names of students.
                for (int i = 0; i < studentNames.Count; i++)
                    {
                        Console.WriteLine(studentNames[i]);
                    }
                Console.WriteLine("Continue?  y/n:");
                string answer = Console.ReadLine();
                if (answer == "y")
                {
                    run = true;
                }

                else if (answer == "n")
                {
                    run = false;
                    Console.WriteLine("Goodbye!");

                }
            }

        }
    }
}
