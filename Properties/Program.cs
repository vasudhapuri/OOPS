using System;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "shaina";
            Console.WriteLine("Name is "+person.Name);

            person.Age = 22;
            Console.WriteLine("Age is "+ person.Age);
        }

        class Person
        {
            private string name;
            private int age;
            public string Name
            {
                //automatic property
                get { return name; }
                set { name = value; }
            }
            public int Age
            {
                get;
                set;
            }
        }
    }
}
