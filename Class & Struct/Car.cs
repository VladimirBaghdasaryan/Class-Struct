using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class___Struct
{
    internal class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public Car(string brand, string model, int year)
        {
            Brand = brand;
            Model = model;
            Year = year;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Brand:{Brand} Model:{Model} Year:{Year}");
        }
    }
}
