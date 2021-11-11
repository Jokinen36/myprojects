using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGameDemo
{

    //Runs game Logic
    public class Game
    {
      
        public void Run()
        {

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine(@"  ____  _           ____                      
 |  _ \(_) ___ ___ / ___| __ _ _ __ ___   ___ 
 | | | | |/ __/ _ \ |  _ / _` | '_ ` _ \ / _ \TM
 | |_| | | (_|  __/ |_| | (_| | | | | | |  __/
 |____/|_|\___\___|\____|\__,_|_| |_| |_|\___|
                                              

");


            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Title = "DiceGame";
           

            //Create Player object, get user info
            Player currentPlayer = new Player(0);
            currentPlayer.GetPlayerInfo();
            Console.WriteLine(" ");
            currentPlayer.GreetPlayer(); 

            //Create Computer player object
            Player computerPlayer = new Player("Computer",  0);

            //Create dice object
            Dice dice = new Dice();

            //Game loop
            while (true)
            {                                          

                Console.WriteLine(" \n\n");
                Console.WriteLine($"    ----------------------");
                Console.WriteLine("■ Press Enter to roll the dice ■");
                Console.WriteLine($"    ----------------------");
                Console.ReadKey();
                Console.Clear();

                // Assigns human player dice number via RollDice method
                currentPlayer.Number = dice.RollDice();


                //Prints dice value to screen
                dice.Draw(currentPlayer.Number);
                Console.WriteLine(" \n");

                //Ask user to guess computers dice roll
                currentPlayer.PlayerGuess = currentPlayer.CheckInput(currentPlayer.Number);       
                Console.Clear();


                //Roll computers dice and draw
                computerPlayer.Number = dice.RollDice();
                Console.WriteLine(" \n \n ");
                dice.Draw(computerPlayer.Number);
                Console.WriteLine("\n \n ");


                // Logic to determine winner of round (would like to put in a method to clean up?)
                if (currentPlayer.Number == computerPlayer.Number && currentPlayer.PlayerGuess == "equal")
                { currentPlayer.Score += 5; Console.WriteLine("Correct! They are the same! You get 5 points"); }
                else if (currentPlayer.Number < computerPlayer.Number && currentPlayer.PlayerGuess == "higher")
                { currentPlayer.Score++; Console.WriteLine("Correct! Your dice was higher! You gain a point"); }
                else if (currentPlayer.Number > computerPlayer.Number && currentPlayer.PlayerGuess == "lower")
                { currentPlayer.Score++; Console.WriteLine("Bingo! Your dice was lower! You get a point"); }
                else { computerPlayer.Score++; Console.WriteLine("Sorry! You guessed incorrectly, computer gets a point"); }

                // Display current game stats
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine(" \n");
                Console.WriteLine($"{currentPlayer.Name}'s score is: {currentPlayer.Score} \n" +
                    $"Computer's score is: {computerPlayer.Score}");


                //Win conditions
                Console.ForegroundColor = ConsoleColor.Blue;
                if (currentPlayer.Score >= 8) { Console.WriteLine($"Congrats {currentPlayer.Name}, you got to 8 points, you win!");
                    Console.ReadKey(); break;                }
                else if (computerPlayer.Score >= 5) { Console.WriteLine($"Computer got to 5 points before you got to 8, you lose :(");
                    Console.ReadKey(); break;                }

                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("");
                Console.WriteLine("Press Enter to continue to next round");
                Console.ReadKey();
                Console.Clear();

            }
            Console.WriteLine("Thanks for playing!");
                        
        }


       

    }
}
