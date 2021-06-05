using System;

namespace AccessModifiers_Private_Public
{
    class Program
    {

        private string car_name;
        static void Main(string[] args)
        {
            Program p = new Program();
            p.car_name = "Tata"; //private attribute accessible within same class

            Car c = new Car();
            // c.car_color  //private member of another class (Car) is not accessible
            c.car_model = "Tiago";//car_model field is accessible from Program class since it is public
            //c.year //year is not accessible since default access modifier for fields is private
            Console.WriteLine(p.car_name+ " "+c.car_model);
           
        }
    }

    class Car
    {
        private string car_color;
        public string car_model;
        int year;
    }
}
