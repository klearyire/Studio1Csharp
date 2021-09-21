using System;

namespace Studio1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // User input
            Console.WriteLine("Enter a radius:");
            string userRadius = Console.ReadLine();

            // Convert to double
            double radius = double.Parse(userRadius);

            // Calculate area
            double area = Math.PI * Math.Pow(radius, 2);
            // Console.WriteLine("The area of a circle with radius " + userRadius + " is: " + area);

            // Calculate circumference
            double circumference = 2 * Math.PI * radius;

            // Calculate diameter
            double diameter = 2 * radius;
            Console.WriteLine("The area of a circle with radius " + userRadius + " is: " + area + ", the circumference is " + circumference + ", and the diameter is " + diameter + ".");

            // Road Trip
            Console.WriteLine("How many miles per gallon does your car get?");
            string userMpg = Console.ReadLine();
            double mpg = double.Parse(userMpg);
            double circlePerGal = radius / mpg;
            Console.WriteLine("You will use " + circlePerGal + " gallons driving around the circle.");


        }
    }
}


