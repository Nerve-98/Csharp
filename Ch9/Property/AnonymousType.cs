using System;

namespace AnonoymousType
{
    class MainApp
    {
        static void Main(string[] args)
        {
            var a = new { Name = "Nerve", Age = 123 };
            Console.WriteLine($"Name:{a.Name}, Age:{a.Age}");


            var b = new { Subject = "Math", Scores = new int[] { 1, 2, 3, 4 } };
            Console.Write($"Subject:{b.Subject}, Scores: ");
            //Console.WriteLine($"Subject:{b.Subject}, Scores:{b.Scores}");
            foreach (int score in b.Scores) // var score or int score
                Console.Write($"{score} ");
            Console.WriteLine();

            /*
            Name: Nerve, Age: 123
            Subject: Math, Scores: 1 2 3 4
            */


        }

    }


}