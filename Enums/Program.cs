using System;

namespace Enums
{
  
    class Program
    {
        enum Branch
        {
            Civi,
            Mechanical,
            ECE=6,
            Computer 
        }


        static void Main(string[] args)
        {
            Branch var = Branch.Mechanical;
            Console.WriteLine(var);
            int index = (int)Branch.Mechanical;
            Console.WriteLine(index);

            int var1 = (int)Branch.Computer;
            Console.WriteLine( var1);
        }
    }
}
