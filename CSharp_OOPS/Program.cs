using System;

namespace CSharp_OOPS
{
    class Car
    {

        String color = "red";
        int weight = 1500;
        static void Main(string[] args)
        {
            Car car = new Car();
            Console.WriteLine("color of car is "+car.color);
            Console.WriteLine("weight of car is "+car.weight);
            Car car1 = new Car();
            Console.WriteLine("color of car is "+ car1.color);
        }
    }
}
