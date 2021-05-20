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
            Console.WriteLine($"So {name}, What is it you want me to answer?");
            Console.WriteLine("Please remember that I can only answer yes or no typed questions:");

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
                Console.WriteLine($"So {name}, What is it you want me to answer?");
                Console.WriteLine("Please remember that I can only answer yes or no questions");
                Console.ReadLine();
            }

            var answers = new List<string>(){
                "It is Certain",
                "It is decidedly so",
                "Without a doubt",
                "Yes definitely",
                "You may rely on it",
                "As I see it, yes",
                "Most likely",
                "Outlook good",
                "Yes",
                "Signs point to yes",
                "Reply hazy, try again",
                "Ask again later",
                "Better not tell you now",
                "Cannot predict now",
                "Concentrate and try again",
                "Don't count on it",
                "My reply is no",
                "My sources say no",
                "Outlook not so good",
                "Very doubtful",
            };
            //Below is the random num generator and its possible outcomes (Answers from the Magic 8 Ball
            rannum = r.Next(0, answers.Count);

            Console.WriteLine(answers[rannum]);

            Console.ReadLine();
        }
    }
}
