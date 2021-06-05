using System;

namespace MultipleClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            Console.WriteLine(animal.color);
            Console.WriteLine(animal.sound);
            animal.name = "cow";
            Console.WriteLine(animal.name);
        }
    }

      class Animal
    {
        public String color="white";
        public String sound="moo";
        public String name;

    }
}
