﻿using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace DecisionMaker
{
    class Program
    {
        static void Main(string[] args)
        {   int rageMeter = 0;
            Console.WriteLine("please enter your name");
            string name = Console.ReadLine();
            Console.WriteLine($"thank you {name}");

            do
            {

                Console.WriteLine($"{name} please enter a number between 1-100");
                int userInput = Convert.ToInt32(Console.ReadLine());
                if (userInput >= 1 && userInput <= 100)
                {
                    if (userInput > 60 && userInput % 2 != 0)
                    {
                        Console.WriteLine($"{userInput} Odd");
                    }

                    else if (userInput > 60 && userInput % 2 == 0)
                    {
                        Console.WriteLine($"{userInput} Even");
                    }

                    else if (userInput <= 60 && userInput >= 26 && userInput % 2 == 0)
                    {
                        Console.WriteLine($"Even");
                    }

                    else if (userInput < 26 && userInput % 2 == 0)
                    {
                        Console.WriteLine($"Even and less than 25");
                    }

                    else if (userInput % 2 != 0)
                    {
                        Console.WriteLine($" {userInput}  Odd");
                    }
                }
                switch(rageMeter)
                {
                    case 0:
                    {
                        Console.WriteLine($"{name} that number was not between 1 - 100");
                        rageMeter++;
                            break;
                    }
                    case 1:
                    {
                        Console.WriteLine($"Seriously {name} lets try again between 1-100");
                        rageMeter++;
                            break;
                    }
                    case 2:
                    {
                        Console.WriteLine($"What dont you get {name} I said between 1 and 100?");
                        rageMeter++;
                            break;
                        }
                    case 3: 
                    {
                        Console.WriteLine($"Really we're here again... come on {name} try again 1 and 100");
                        rageMeter++;
                            break;
                        }
                    case 4:
                    {
                        Console.WriteLine($"Your killing me smalls I'll try to slow it down BE-TWEEN 1 and wait for it...100");
                        rageMeter++;
                            break;
                        }
                    case 5:
                    {
                        Console.WriteLine($"What the hell {name} now you're just here to see how much i was trying to type fine I'll play your sick game pick a number NOT between 1-100 ");
                        rageMeter++;
                            break;
                        }
                    case 6:
                    {
                        Console.WriteLine($"Yeah {name} I have no life either keep trying or just do it right please... ");
                        rageMeter++;
                            break;
                        }
                    case 7:
                    {
                        Console.WriteLine($"{name} you're gonna get on my last nerve I swear... just please for the love of god put in a number between 1 and 100");
                        rageMeter++;
                            break;
                        }
                    case 8: 
                    {
                        Console.WriteLine($"I hate you {name}...there i said it");
                        rageMeter++;
                            break;
                        }
                    case 9: 
                    {
                        Console.WriteLine($"You know {name} you're persistent or stupid either way we should grab a beer some time but please for the sake of everything jus enter a number between 1-100 and get this over with");
                        rageMeter++;
                            break;
                        }
                default:
                    {
                        Console.WriteLine($"ok {name}, you asked for it...");
                        Console.WriteLine("We're no strangers to love you know the rules and so do I a full commitment's what I'm thinking of you wouldn't get this from any other guy");
                        Console.WriteLine("I just wanna tell you how I'm feeling gotta make you understand");
                        Console.WriteLine("Never gonna give you up never gonna let you down never gonna run around and desert you");
                        Console.WriteLine("Never gonna make you cry never gonna say goodbye never gonna tell a lie and hurt you");

                            break;

                        }
                    
                }
                 Console.WriteLine($"Would you like to play again {name}? [Y | N]");
            }  
                while (Console.ReadLine().ToUpper() != "N") ;
             Console.WriteLine($"thank you for playing {name}");
        }

    }
        
}

