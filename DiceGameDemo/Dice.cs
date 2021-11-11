using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace DiceGameDemo
{
    public class Dice
    {
        public int Number { get; set; }   

        public void Draw(int number)
        {
            if (Number == 1) 
            { Console.WriteLine(@"    +---------+
    |         |
    |    o    |
    |         |
    +---------+ "); }
            else if (Number == 2) { Console.WriteLine(@"    +---------+
    | o       |
    |         |
    |       o |
    +---------+"); }
            else if (Number == 3) { Console.WriteLine(@"    +---------+
    | o       |
    |    o    |
    |       o |
    +---------+"); }
            else if (Number == 4) { Console.WriteLine(@"
    +---------+
    | o     o |
    |         |
    | o     o |
    +---------+"); }
            else if (Number == 5) { Console.WriteLine(@"    +---------+
    | o     o |
    |    o    |
    | o     o |
    +---------+"); }
            else { Console.WriteLine(@"    +---------+
    | o     o |
    | o     o |
    | o     o |
    +---------+"); }

        }

        public int RollDice()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"*Shake*");
            Thread.Sleep(250);
            Console.WriteLine($"*Shake*");
            Thread.Sleep(250);
            Console.WriteLine($"*Shake*");
            Thread.Sleep(250);
            Console.WriteLine($"*Shake*");
            Thread.Sleep(250);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"*Throw...*");
            Console.WriteLine(" \n");
            Console.ForegroundColor = ConsoleColor.Gray;
            Thread.Sleep(25);
            Console.Beep();
            Random random = new Random();
            Number = random.Next(1, 7);       
            return Number; 
        }




    }
}
