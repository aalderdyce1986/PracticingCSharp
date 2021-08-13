using System;

namespace UsedCarDetermineMarketValue
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();            
            Car.MyMethod();

        }


        class Car
        {
            public string Make { get; set; }
            public string Model { get; set; }
            public int Year { get; set; }
            public string Color { get; set; }

            public Car()
            {
                // Just an overloaded method of Car.
            }
            public Car(
                string make,
                string model,
                int year,
                string color)
            {
                Make = make;
                Model = model;
                Year = year;
                Color = color;
            }


            public static void MyMethod()
            {
                Console.WriteLine("Called the Static MyMethod");
                
            }

            public static void myMethod()
            {
                Console.WriteLine("Please, enter your car's make: ");
                string make = Console.ReadLine();

            }

        }

    }
}