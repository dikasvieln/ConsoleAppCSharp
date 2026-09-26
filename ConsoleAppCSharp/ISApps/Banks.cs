using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppCSharp.ISApps
{

    
    internal class Banks
    {
        // define for property get set of init banks 
        public string BankName { get; set; }
        public string BankType { get; set; }
    }
    

    class Accounts : Banks
    {
        public string Account { get; set; }
        public string AccountType { get; set; }

        public void accountName (string account)
        {
            this.Account = account;
        }


    }
    
    // define class
    class Person : Accounts
    {
        public string PersonName { get; set; }
        public string PersonType { get; set; }  

    }

    class Deposite : Banks
    {

    }

    class Withdraw
    {

    }

    class Transfer
    {

    }
}
