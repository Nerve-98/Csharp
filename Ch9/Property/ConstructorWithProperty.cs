using System;

namespace ConstructorWithProperty
{
    class BirthdayInfo
    {
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public int Age { get { return new DateTime(DateTime.Now.Subtract(Birthday).Ticks).Year; } }

    }


    class MainApp
    {
        static void Main(string[] args)
        {
            BirthdayInfo birth = new BirthdayInfo()
            {
                Name = "SeoHyeon",
                Birthday = new DateTime(1991, 6, 28)
            };

            Console.WriteLine($"Name : {birth.Name}");
            Console.WriteLine($"Birthday : {birth.Birthday.ToShortDateString()}");
            Console.WriteLine($"Age : {birth.Age}");
            /*
            Name: SeoHyeon
            Birthday : 1991 - 06 - 28
            Age: 30
            */

        }

    }

}