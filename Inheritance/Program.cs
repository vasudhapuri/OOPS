using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Cow c = new Cow();
            c.name = "cow";
            c.sound = "moos";
            Console.WriteLine(c.name + " "+c.sound);
            c.move();
            c.sleep();
        }
    }

    class Animal
    {
        public string name;
        public string sound;
        public void move()
        {
            Console.WriteLine("animal moving");
        }
    }

    sealed class DomesticAnimals
    {
        public string animal_color;
    }
    class Cow:Animal
    {
        public void sleep()
        {
            Console.WriteLine("cow sleeping");
        }
    }


    //below class cannot derive from sealed class error
    //class HomeAnimals:DomesticAnimals
    //{

    //}
}
