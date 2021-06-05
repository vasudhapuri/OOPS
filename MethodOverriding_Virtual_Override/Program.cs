using System;

namespace MethodOverriding_Virtual_Override
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            animal.AnimalSound();

            Animal animal1 = new pig();
            animal1.AnimalSound(); //calls method from pig child class since virtual and override keywords are used in methods

            Animal animal2 = new cow(); //calls method from base class, since override keyword is not written in child class method
            animal2.AnimalSound();

        }
    }

    class Animal
    {
        public virtual  void AnimalSound()
        {
            Console.WriteLine("Animal makes sound");
        }
    }

    class pig:Animal
    {
        public override void AnimalSound()
        {
            Console.WriteLine("Animal pig makes oink sound");
        }

    }

    class cow:Animal
    {
        public void AnimalSound()
        {
            Console.WriteLine("Animal cow makes moo sound");
        }

    }

}
