using System;
using System.Text;
using System.Threading;
using System.Linq;
using System.Collections.Generic;


namespace IM8B
{
    class Program
    {
        static void Main(string[] args)
        {

        int rannum = 0;
        Random r = new Random();

            //Ask user for name
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Hello");
            Thread.Sleep(1000);
            Console.WriteLine("I am IM8B a C# console program created by Ash");
            Thread.Sleep(1000);
            Console.WriteLine("Who are you?");

            //Makes sure a user enters a valid name
            string name = Console.ReadLine();
            while (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("What? You must have a name! Please enter your name again:");
                name = Console.ReadLine();
            }
            //Repeats user's name and asks what is requested from user
            Console.Clear();
            Thread.Sleep(1500);
            Console.WriteLine($"You are named {name}? That is a very cool name!");
            Thread.Sleep(2000);
            Console.Clear();
            System.Console.WriteLine($"So {name}, What is it you want me to answer?");
            System.Console.WriteLine("Please remember that I can only answer yes or no typed questions:");

            //Makes sure user asks a valid question
            string question = Console.ReadLine();
            while (string.IsNullOrEmpty(question))
            {
                Console.WriteLine("You need to ask me a question!");
                question = Console.ReadLine();
            }
            //Easter egg :)
            if (question == "no bell tolls")
            {
                Console.WriteLine("...and yet, you've slipped into the painting?");
                Thread.Sleep(2500);
                Console.Clear();
                System.Console.WriteLine($"So {name}, What is it you want me to answer?");
                System.Console.WriteLine("Please remember that I can only answer yes or no questions");
                Console.ReadLine();
            }

        //Below is the random num generator and its possible outcomes (Answers from the Magic 8 Ball)
        rannum = r.Next(1,20);

        switch (rannum)
        {
            case 1:
            Console.WriteLine("It is Certain");
            break;

            case 2:
            Console.WriteLine("It is decidedly so");
            break;

            case 3:
            Console.WriteLine("Without a doubt");
            break;

            case 4:
            Console.WriteLine("Yes definitely");
            break;

            case 5:
            Console.WriteLine("You may rely on it");
            break;
            
            case 6:
            Console.WriteLine("As I see it, yes");
            break;
            
            case 7:
            Console.WriteLine("Most likely");
            break;
            
            case 8:
            Console.WriteLine("Outlook good");
            break;

            case 9:
            Console.WriteLine("Yes");
            break;

            case 10:
            Console.WriteLine("Signs point to yes");
            break;

            case 11:
            Console.WriteLine("Reply hazy, try again");
            break;

            case 12:
            Console.WriteLine("Ask again later");
            break;

            case 13:
            Console.WriteLine("Better not tell you now");
            break;

            case 14:
            Console.WriteLine("Cannot predict now");
            break;

            case 15:
            Console.WriteLine("Concentrate and try again");
            break;

            case 16:
            Console.WriteLine("Don't count on it");
            break;

            case 17:
            Console.WriteLine("My reply is no");
            break;

            case 18:
            Console.WriteLine("My sources say no");
            break;

            case 19:
            Console.WriteLine("Outlook not so good");
            break;

            case 20:
            Console.WriteLine("Very doubtful");
            break;

        }

        Console.ReadLine();
        }
    }
}
