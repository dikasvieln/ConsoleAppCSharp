using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

// learn Ienumaration and threads in C#
namespace ConsoleAppCSharp.ISApps
{
    internal class Cenums
    {
        public int TotalAmount;
        int chs;
        public void ListOfDaysWeek()
        {
            string[] monthsOfYear =
            {
                "January",
                "February",
                "March",
                "April",
                "May",
                "June",
                "July",
                "Agustus",
                "September",
                "Oktober",
                "November",
                "Desember"
            };

            string[] daysOfWeek = {
                "Monday",
                "Tuesday",
                "Wenesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday",
            };
            _ = new List<string>();

            Console.WriteLine("Which do you want to display?");
            Console.WriteLine("(Monday = 1, etc) > ");

            int iDay = int.Parse(Console.ReadLine());

            string chosenDay = daysOfWeek[iDay];

            if (daysOfWeek[iDay] == "7")
            {
                Console.WriteLine("no other day"); 
            }

            Console.WriteLine($"That day is {chosenDay}");

            Console.WriteLine("Before:");
            foreach (string day in daysOfWeek)
                Console.WriteLine(day);

            daysOfWeek[2] = "Wednesday";

            Console.WriteLine("\r\nBefore:");
            foreach (string day in daysOfWeek)
                Console.WriteLine(day);
        }

        public void menuAccount()
        {

            do
            {
                Console.WriteLine("==== mini account bank ===");
                Console.WriteLine("1. Deposite your money");
                Console.WriteLine("2  Transfer your money");
                Console.WriteLine("3. Withdraw your money");
                Console.WriteLine("4  Status account");
                Console.WriteLine("please kindly choose your option: ");
                chs = int.Parse(Console.ReadLine());


                switch (chs)
                {
                    case 1:
                        Console.WriteLine("Deposite your money");
                        depositMoney();
                        break;
                    default:
                        Environment.Exit(0);
                        break;
                }
            } while (chs != 5);
            
        }

        public void depositMoney()
        {

            Console.Clear();
            Console.WriteLine("Input the amount you want to deposite: ");
            int amount = Convert.ToInt32(Console.ReadLine());
            TotalAmount += amount;
        }

        public void withdrawMoney()
        {
            Console.Clear();
            Console.WriteLine("Input the amount you want wish to withdraw: ");
            int amo = Convert.ToInt32(Console.ReadLine());

            if (amo <= TotalAmount)
            {
                TotalAmount -= amo;
            } else
            {
                Console.WriteLine("insufficient balance");
            }
        }

        public void transferMoney()
        {
            Console.Clear();
            Console.WriteLine("Input the amount you want to transfer: ");
            int transMo = Convert.ToInt32(Console.ReadLine());

            if (transMo <= TotalAmount)
            {
                TotalAmount -= transMo;
            }
            else
            {
                Console.WriteLine("Insufficient Balance is not transfer");
            }
        }

        public void checkDetails()
        {
            Console.WriteLine("here is your status account bank");
        }
    }
}
