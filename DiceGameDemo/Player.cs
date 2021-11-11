using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGameDemo
{
    public class Player
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public string PlayerGuess { get; set; }
        public int Number { get; set; }



        public Player(int score)
        {
            Score = score;
        }
        public Player(string name, int score)
        {
            Score = score;
            Name = name;
        }

        public void GetPlayerInfo()
        {
            Console.WriteLine("What's your name?");
            string name = Console.ReadLine();
            Name = name;            
            Score = 0;
        }

        public void GreetPlayer()
        {           
            Console.WriteLine($"\nHello {Name}, welcome to DiceGame!\n\n\nYou will roll your dice first, " +
                $"and then guess whether the computer will roll\nhigher, lower, or the same as your dice." +
                $" Guessing higher or lower will get you\n1 point if you are correct, 5 points if you guess " +
                $"equal and are correct.\nComputer gets a point if you guess incorrectly.\n\nYou win by reaching 8 points before the computer reaches 5. Good luck.");
        }

        public string CheckInput(int playerNum)
        {
            Console.WriteLine($"You rolled a {playerNum}, do you think your opponnent " +
                    $"will roll a higher, lower, or equal number?");
            string guess = Console.ReadLine().ToLower();
            Console.WriteLine($"You type {guess}");

            while (guess != "higher" && guess != "lower" && guess != "equal")
            { Console.WriteLine("Please type 'higher', 'lower', or 'equal'.");
                guess = Console.ReadLine().ToLower();
            } 
            return guess;             
                        
        }
    
      

    }
}
