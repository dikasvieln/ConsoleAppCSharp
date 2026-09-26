using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppCSharp.Algorithm
{
    internal class Codingbat
    {
        public void modEven()
        {
            Console.WriteLine("input your mod number:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input your number to be count");
            int num2 = Convert.ToInt32(Console.ReadLine());
            if (num2 % num1 == 0 )
            {
                Console.WriteLine("your number after modulus is even" );
               
            } else
            {
                Console.WriteLine("your number after modulus is odd");
            }

        }

        public int bigHeights(int[] heights, int start, int end)
        {
            int count = 0;

            for (int i = start; i < end; i++)
            {
                if (Math.Abs(heights[i] - heights[i + 1]) >= 5) count++;
            }

            return count;
        }

        public int UserCompare(string aName, int aId, string bName,int bId)
        {
            /* We have data for two users, A and B, each with a String name and an int id. 
            * The goal is to order the users such as for sorting. Return -1 if A comes 
            * before B, 1 if A comes after B, and 0 if they are the same. Order first by 
            * the string names, and then by the id numbers if the names are the same.
             */

            string aLower = aName.ToLower();
            string bLower = bName.ToLower();

            if (aLower.CompareTo(bLower) < 0)
            {
                return -1; // A comes before B
            }
            else if (aLower.CompareTo(bLower) > 0)
            {
                return 1; // A comes after B
            }
            else if (aId < bId)
            {
                return -1; // Same name, A id is less than B id
            }
            else if (aId > bId)
            {
                return 1; // Same name, A id is greater than B id
            }

            // Same name and same id
            else
            {
                return 0; // A and B are the same
            }

            return 0;
        }

        // string bits 
        public string StringBits(string str)
        {
            int Store = (int) Math.Ceiling((double)str.Length / 2);
            char [] result = new char[(int)Store];

            int index = 0;
            for (int i = 0; i < str.Length; i += 2)
            {
                result[index] = str[i];
                index++;
            }

            return new string(result);
        }

        public string StringSplosion(string str)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                result.Append(str.Substring(0, i + 1));
            }
            return result.ToString();
        }

    }
}
