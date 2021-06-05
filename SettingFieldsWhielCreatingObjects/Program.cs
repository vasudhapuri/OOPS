using System;

namespace SettingFieldsWhielCreatingObjects
{
    class Program
    {
        String model;
        int year;
        String color;
        
        static void Main(string[] args)
        {

            Program p = new Program();
            p.model = "Merc";
            p.year = 1988;
            p.color = "black";            

            Program p2 = new Program();
            p2.model = "Volvo";
            p2.year = 1994;
            p2.color = "Silver";


            Console.WriteLine(p.model);
            Console.WriteLine(p2.model);
            Console.WriteLine(p.year);
            Console.WriteLine(p2.year);
        }
    }
}
