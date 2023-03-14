using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> options = new List<string> { "rock", "paper", "scissors" };
            int computerScore = 0;
            int playerScore = 0;

            bool isRunning = true;
            while (isRunning)
            {
                Console.Write("Enter your choice among (Rock, Paper, and Scissors): ");
                string playerChoice = Console.ReadLine().ToLower();
                string computerChoice = options[new Random().Next(options.Count)];

                // Player's win zone
                if (playerChoice == "paper" && computerChoice == "rock")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You won");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Player score + 1");
                    Console.ResetColor();
                    playerScore++;
                }
                else if (playerChoice == "scissors" && computerChoice == "paper")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You won");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Player score + 1");
                    Console.ResetColor();
                    playerScore++;
                }
                else if (playerChoice == "rock" && computerChoice == "scissors")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You won");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Player score + 1");
                    Console.ResetColor();
                    playerScore++;
                }

                // Computer's win zone
                else if (playerChoice == "scissors" && computerChoice == "rock")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You lost");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Computer score + 1");
                    Console.ResetColor();
                    computerScore++;
                }
                else if (playerChoice == "paper" && computerChoice == "scissors")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You lost");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Computer score + 1");
                    Console.ResetColor();
                    computerScore++;
                }
                else if (playerChoice == "rock" && computerChoice == "paper")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You lost");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Computer score + 1");
                    Console.ResetColor();
                    computerScore++;
                }

                // Draw zone
                else if (playerChoice == computerChoice)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Draw!");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Player score + 0");
                    Console.WriteLine("Computer score + 0");
                    Console.ResetColor();
                }

                else if (playerChoice == "q")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Thanks for using!");
                    Console.ResetColor();
                    Console.WriteLine("-------------ScoreBord-------------");
                    Console.WriteLine($"Player score is: {playerScore}");
                    Console.WriteLine($"Computer score is: {computerScore}");
                    Console.WriteLine("-----------------------------------");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("GitHub: https://github.com/toghr0l");
                    Console.ResetColor();
                    isRunning = false;
                }
                else
                {
                    Console.WriteLine("Invalid operation!");
                }
            }
        }
    }
}
