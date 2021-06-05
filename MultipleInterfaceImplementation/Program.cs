using System;

namespace MultipleInterfaceImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            whale whale = new whale();
            whale.Animalmoves();
            whale.mammalmoves();
        }
    }

   interface Animal
    {
        void Animalmoves();

    }

    interface mammal
    {
        void mammalmoves();
    }


    class whale: Animal, mammal
    {
        public void Animalmoves()
        {
            Console.WriteLine("whale is animal which moves");

        }


        public void mammalmoves()
        {
            Console.WriteLine("whale is mammal which swims");
        }
    }
}
