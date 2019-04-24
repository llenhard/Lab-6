using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            int dice, diceSides, outcome, roll = 1;
            Console.WriteLine("Welcoem to the Casino!");

            Console.WriteLine("How many dice? ");
            dice = int.Parse(Console.ReadLine());

            Console.WriteLine("How many sides will each die have?");
            diceSides = int.Parse(Console.ReadLine());

            RollDice(diceSides, dice, roll);

            
        }

        public static int RollDice(int diceSides, int diceAmt, int rolls)
        {
            Random r = new Random();

            if(diceAmt >= 1)
            {
                int outcome = r.Next(0, diceSides + 1);
                Console.WriteLine("Roll {0}: {1}", rolls, outcome);
                System.Threading.Thread.Sleep(500);
                return RollDice(diceSides, diceAmt - 1, rolls + 1);
            }
            else
            {
                return -1;
            }
        }
    }
}
