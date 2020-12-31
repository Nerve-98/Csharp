using System;

namespace AutoImplementedProperty
{
    class BirthdayInfo
    {
        public string Name { get; set; } = "Unknown";
        public DateTime Birthday { get; set; } = new DateTime(); // same to new DateTime();
        public int Age { get { return new DateTime(DateTime.Now.Subtract(Birthday).Ticks).Year; } }

        class MainApp
        { 
            static void Main(string[] args)
            {
                BirthdayInfo birth = new BirthdayInfo();
                Console.WriteLine($"Name : {birth.Name}");
                Console.WriteLine($"Birthday : {birth.Birthday.ToShortDateString()}");
                Console.WriteLine($"Age : {birth.Age}");

                birth.Name = "SeoHyeon";
                birth.Birthday = new DateTime(1991, 6, 28);

                Console.WriteLine($"Name : {birth.Name}");
                Console.WriteLine($"Birthday : {birth.Birthday.ToShortDateString()}");
                Console.WriteLine($"Age : {birth.Age}");
                /*
                Name : Unknown
                Birthday : 0001-01-01
                Age : 2020
                Name : SeoHyeon
                Birthday : 1991-06-28
                Age : 30
                */

            }

        }

    }

}