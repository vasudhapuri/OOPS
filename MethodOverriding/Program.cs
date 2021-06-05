using System;

namespace MethodOverriding
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal a = new Animal();
            a.sound();
            Animal p = new pig();
            p.sound(); //base class mehtod overrides the derived class method
        }
    }

    class Animal
    {
        public void sound()
        {
            Console.WriteLine("animal makes sound");
        }
    }

    class pig:Animal
    {
        public void sound()
        {
            Console.WriteLine("pig makes oink sound");
        }
    }

   
}
