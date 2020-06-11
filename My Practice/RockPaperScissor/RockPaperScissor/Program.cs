using System;

namespace RockPaperScissor
{
    class Program
    {
        static void Main(string[] args)
        {
            int Playerscore = 0;
            int Compscore = 0;

            Rematch:
            string userinput , compinput;
            
            Random randint = new Random();
            int input = randint.Next(1, 4);

            Console.WriteLine("Enter your input as rock, paper or scissor");
            userinput = Console.ReadLine();

            switch (input)
            {
                case 1:
                    compinput = "Rock";
                    Console.WriteLine("The computer chose Rock");
                    if(userinput=="rock")
                    {
                        Console.WriteLine("Match Draw");
                    }
                    else if(userinput == "paper")
                    {
                        Console.WriteLine("You win");
                        Playerscore++;
                    }
                    else if (userinput == "scissor")
                    {
                        Console.WriteLine("Comp wins");
                        Compscore++;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input");
                    }
                    break;
                case 2:
                    compinput = "Paper";
                    Console.WriteLine("The computer chose Paper");
                    if (userinput == "rock")
                    {
                        Console.WriteLine("Comp Wins");
                        Compscore++;
                    }
                    else if (userinput == "paper")
                    {
                        Console.WriteLine("Match Draw");
                    }
                    else if (userinput == "scissor")
                    {
                        Console.WriteLine("You win");
                        Playerscore++;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input");
                    }
                    break;
                case 3:
                    compinput = "Scissor";
                    Console.WriteLine("The computer chose Scissor");
                    if (userinput == "rock")
                    {
                        Console.WriteLine("You win");
                        Playerscore++;
                    }
                    else if (userinput == "paper")
                    {
                        Console.WriteLine("Comp Wins");
                        Compscore++;
                    }
                    else if (userinput == "scissor")
                    {
                        Console.WriteLine("Match Draw");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input");
                    }
                    break;
                default:
                    compinput = "Invalid";
                    break;

            }
            Console.WriteLine("Game over");
            Console.WriteLine("Your score:"+ Playerscore);
            Console.WriteLine("Comp Score:"+ Compscore);
            Console.WriteLine("Do you want to play again?" +
                "Press 1 to Rematch" +
                "Press 2 to Quit");
            
            var rematch = Convert.ToInt32(Console.ReadLine());
            if (rematch==1)
            {
                goto Rematch;
            }
            if (rematch==2)
            {
                Console.WriteLine("Bye!");
            }
        }
    }
}
