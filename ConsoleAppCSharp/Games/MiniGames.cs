using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading;

namespace ConsoleAppCSharp.Games
{
    internal class MiniGames
    {

        public void MenuGames()
        {
            int choose1;

            do {

                Console.WriteLine("Welcome to a games with simple console");
                /*
                Console.WriteLine("1. Stars Project (Star) or (star2)");
                Console.WriteLine("2. Hangmans (Hangman)");
                Console.WriteLine("3. Pathfinder a* algo (astar)");
                Console.WriteLine("4. Djikstra algo (djikstra)");
                Console.WriteLine("5. Play Banjo (banjo)");
                Console.WriteLine("6. back to the future"); 
                */
                choose1 = Convert.ToInt32(Console.ReadLine());
            }
            while (choose1 != 7);
        }
        public void Hangman()
        {
            Console.WriteLine("welcome to hangman");

            string guess;

            do
            {
                Console.WriteLine("gues your input: ");

                guess = Console.ReadLine();

                if (guess != "guess") Console.WriteLine("not corrects");

            } while (guess != "guess");

            Console.WriteLine("you win");

        }

        public void ParalellogramStar(int count)
        {
         
            for (int i = 1; i <= count; i++)
            {
                for (int y = 1; y < i; y++)
                {
                    Console.Write(" ");
                }

                for (int x = 0; x < count; x++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine("* ");
            }
        }

        public void CheckIfSay(string name)
        {
            // from codewars case: statement of if the name was starting with capital 'R'
            // or consonant 'r' 
            // it will be return " play banjo before the sunset"
            // but if not starting with 'r' or capital 'R' then play data

            if (name.ToUpper().StartsWith('R'))
            {
                Console.WriteLine( name + " plays banjo before the sunset at the opera house.");
            }
            else
            {
                Console.WriteLine(name + " has not play banjo before the sunset. Instead play piano at the station");
            }
        }

        public static int[] twoSums(int[] anums, int target)
        {
            // some of challanges in the codewars with 7 kyu;
            // which calculate the sums of between two number
            // and adding to a new int 
         
            for (int y = 0; y < anums.Length; y++)
            {
                for (int z =  y + 1; z < anums.Length; z++)
                {
                   if (anums[y] + anums[z] == target )
                     return new int[] { y, z };
                }
            }

            return new int[0];
        }


        public void fastReflex()
        {
            Exception? exception = null;

            const string menu = "Quick draw";

        }

        public void CheckCigar(int cigar, bool isWeekend)
        {
            // from codewars case: statement of if the cigar was between 40 and 60
            // and the weekend was true, then it will be return true
            // but if not, then return false
            //int cigar = 50;
            //bool weekend = true;

            Console.WriteLine("Here is the case simple question");
            if (cigar >= 40 && cigar <= 60 && isWeekend)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
