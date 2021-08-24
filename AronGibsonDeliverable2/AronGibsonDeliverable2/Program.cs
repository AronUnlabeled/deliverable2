using System;

namespace AronGibsonDeliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            string lastInput = "";
            do {
                Console.WriteLine("What would you like to say to the chat bot?");
                userInput = Console.ReadLine().ToLower();

                if (userInput == lastInput) {
                    Console.WriteLine("I'm sorry but you have already said that.");
                }
                else if (userInput == "hello") {
                    Console.WriteLine("Hi good to see you.");
                }
                else if (userInput == "sup"){
                    Console.WriteLine("I am good.");
                }
                else if (userInput == "hello there") {
                    Console.WriteLine("General Kenobi.");
                }
                else if (userInput == "bye") {       
                    Console.WriteLine("Good bye!");
                }

                lastInput = userInput;
            } while (userInput != "bye");
        }
    }
}
