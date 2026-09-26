using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppCSharp.Games
{
    internal class DuckHunt
    {

        const int duck = 0;
        
        void mainContent()
        {
            Console.WriteLine("data duck hunt");
        }

        bool duckHit(int duck)
        {
            return true;
        }

       
    }

    class Bird
    {
        public int shoot;

        public Bird(int shoot)
        {
            this.shoot = shoot;
        }
    }


    
}
