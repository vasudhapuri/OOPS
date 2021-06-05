using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr= new int[5] { 1, 2, 3, 4, 5 };

            try
            {
                Console.WriteLine(arr[5]);
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            finally
            {
                Console.WriteLine("finally block");
            }
        }
    }
}
