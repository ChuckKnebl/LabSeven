using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    public class MainClass
    {

        static List<Movie> movies = new List<Movie>()
        {
        new Movie("Snow White", "animated"),
        new Movie("Shrek", "animated"),
        new Movie("Madagascar", "animated"),
        new Movie("Sleeping Beauty", "animated"),
        new Movie("The Lion King", "animated"),
        new Movie("A Beautiful Mind", "drama"),
        new Movie("Top Gun", "drama"),
        new Movie("A Wonderful Life", "drama"),
        new Movie("Casablanca", "drama"),
        new Movie("The Longest Yard", "drama"),
        new Movie("Psycho", "horror"),
        new Movie("The Birds", "horror"),
        new Movie("Jaws", "horror"),
        new Movie("Alien", "horror"),
        new Movie("Jurassic Park", "horror"),
        new Movie("Star Wars", "scifi"),
        new Movie("2001:  A Space Odyssey", "scifi"),
        new Movie("E.T.:  The Extra-terrestrial", "scifi"),
        new Movie("Clockwork Orange", "scifi"),
        new Movie("Close Encounters of the Third Kind", "scifi")
        };    
        
        
    static void Main(string[] args)
    {
        Boolean run = true;
        while (run == true)
        {
            Console.WriteLine("WELCOME TO THE MOVIE LIST APPLICATION!");
            Console.WriteLine("There are 20 movies in the list.");
            Console.WriteLine("What category are you interested in: animated, drama, horror or scifi? ");
            string input = Console.ReadLine();
            foreach (Movie m in movies)
            {
                if (input == m.GetCategory())
                {
                        Console.WriteLine(m.GetTitle());
                }

            }
        }
    }

    public static Boolean Continue()
    {
        Boolean run;
        Console.WriteLine("Would you like to continue? (y/n)");
        String answer = Console.ReadLine();

        if (answer == "y")
        {
            run = true;
        }
        else if (answer == "n")
        {
            run = false;
            Console.WriteLine("Good Bye!");
        }
        else
        {
            Console.WriteLine("I'm sorry; I don't understand.  Let's try again");
            run = Continue();
        }
        return run;
    }
}
}

