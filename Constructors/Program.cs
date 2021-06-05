using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            Console.WriteLine(c.model);
            Console.WriteLine(c.year);
            Car c1 = new Car("Maruti", 1997, "red");
            Console.WriteLine(c1.model+ " "+ c1.year+ " "+c1.color);
            
        }
    }

    class Car
    {
        public string model;
        public int year;
        public string color;
        public Car()
        {
            model = "fiat";
            year = 1987;
           
        }

        public Car(string mod, int yr, string clr)
        {
            model = mod ;
            year = yr;
            color = clr;
        }
    }
}
