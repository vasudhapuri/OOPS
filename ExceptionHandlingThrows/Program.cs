using System;

namespace ExceptionHandlingThrows
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass m = new MyClass();
            m.checkage(15);
        }
    }

    class MyClass
    {
        public void checkage(int age)
        {
            if (age >= 18)
            {
                Console.WriteLine("can vote");
            }
            else
                throw new ArithmeticException("age should be greater than 18");

        }
    }
}
