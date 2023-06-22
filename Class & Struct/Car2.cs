using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class___Struct
{
    internal class Car2
    {
        public string Model { get; set; }
        public int Year { get; set; }

        public Engine CarEngine { get; set; }

        public Car2(string model, int year, int power, double volume)
        {
            Model = model;
            Year = year;
            CarEngine = new Engine(power, volume);
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Car Model: {Model}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Engine Power: {CarEngine.Power} HP");
            Console.WriteLine($"Engine Volume: {CarEngine.Volume} L");
        }

        public class Engine
        {
            public int Power { get; set; }
            public double Volume { get; set; }

            public Engine(int power, double volume)
            {
                Power = power;
                Volume = volume;
            }
        }
    }
}
