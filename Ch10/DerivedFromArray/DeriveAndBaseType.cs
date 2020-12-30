using System;

namespace DerivedFromArray
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine($"Type of array : {array.GetType()}");
            Console.WriteLine($"Type of array : {array.GetType().BaseType}"); 


        }

    }

}