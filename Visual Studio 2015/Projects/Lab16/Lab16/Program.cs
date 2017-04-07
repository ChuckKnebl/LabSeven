using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab16
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean run = true;
            while (run == true)
            {


                int[] primeNums = new int[] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53,
                59, 61, 67, 71, 73, 79, 83, 89, 97, 101, 103, 107, 109, 113, 127, 131, 137, 139, 149,
                151, 157, 163, 167, 173, 179, 181, 191, 193, 197, 199};

                Console.WriteLine("Let's locate some primes!  This app will find any prime, in order, from the first prime number on.");
                Console.WriteLine("Which prime number are you looking for, in ascending order, up to 200: ");

                int selectedPrime;
                bool valid = int.TryParse(Console.ReadLine(), out selectedPrime);

                if (valid == false)
                {
                    Console.WriteLine("That wasn't a valid integer; please try again.");
                }

                else
                {
                    Console.WriteLine("The " + selectedPrime + " prime number is " + PullPrime(selectedPrime, primeNums) + ".");
                }
            }
            while (run == true)
            {

            }
        }
            public static int PullPrime(int selectedPrime, int[] primeNums)
            {
            int answer = primeNums[(selectedPrime - 1)];
            return answer;
            }
            public static Boolean Continue()
            {
            Boolean run = true;
            while (run == true) ;
            Console.WriteLine("Do you want to find another prime number?  (y/n");
            String answer = Console.ReadLine();
        
            if(answer == "y")
            {
                run = true;
            }
            else if (answer == "n")
            {
                run = false;
                Console.WriteLine("Good Bye!");
            }
            return run;
        }
           
    }
}

       

     








