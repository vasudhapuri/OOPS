using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            pig p = new pig();
            
        }
    }

    interface IAnimal
    {
        void AnimalMove();
        void AnimalSleep();
    }


    public class pig:IAnimal
    {
        public void AnimalMove()
        {
            Console.WriteLine("pig moves");

        }
        public void AnimalSleep()
        {
            Console.WriteLine("pig sleeps");
        }
    }
        
}
