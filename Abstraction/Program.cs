using System;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Pig pig = new Pig();
            pig.Animalmove();
            pig.AnimalSleep();
        }
    }

     public abstract class Animal
    {
        public abstract void Animalmove();
        
            public void AnimalSleep()
        {
            Console.WriteLine("Animal sleeps");
        }

    }

    public class Pig: Animal
    {

        public override void Animalmove()
        {
            Console.WriteLine("pig moves");
        }
    
    }
}
