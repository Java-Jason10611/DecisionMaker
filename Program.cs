using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace DecisionMaker
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("please enter your name");
            string name=Console.ReadLine();
            Console.WriteLine($"thank you {name}");
            do
            {
              
                    Console.WriteLine($"{name} please enter a number between 1-100");
                    int userInput = Convert.ToInt32(Console.ReadLine());
                if (userInput >= 1 && userInput <= 100)
                {
                    if (userInput > 60 && userInput % 2 != 0)
                    {
                        Console.WriteLine($"{name} your number {userInput} is Odd");
                    }

                    else if (userInput > 60 && userInput % 2 == 0)
                    {
                        Console.WriteLine($"{name} your number {userInput} is Even");
                    }

                    else if (userInput < 60 && userInput > 26 && userInput % 2 == 0)
                    {
                        Console.WriteLine($"{name} your number {userInput} is Even");
                    }

                    else if (userInput < 60 && userInput > 26 && userInput % 2 == 0)
                    {
                        Console.WriteLine($"{name} your number {userInput} is Even");
                    }

                    else if (userInput < 26 && userInput % 2 == 0)
                    {
                        Console.WriteLine($"{name} your number {userInput} is even and less than 25");
                    }

                    else if (userInput % 2 != 0)
                    {
                        Console.WriteLine($"{name} your number {userInput} is odd");
                    }
                }
                else {
                    Console.WriteLine($"{name} that number was not between 1-100");
                }
                    Console.WriteLine("play again? [Y | N]");
             
                }
            while (Console.ReadLine().ToUpper() != "N");
            Console.WriteLine($"thank you for playing {name}");
         

        } 
        
    }
}
