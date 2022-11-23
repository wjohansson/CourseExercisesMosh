using System;

namespace BeginnerCourse
{
    public class Exercises1
    {
        public static void Exercise1()
        {
            Console.WriteLine("Enter a number between 1 and 10: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num >= 1 && num <= 10)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid number");
            }
        }

        public static void Exercise2()
        {
            Console.WriteLine("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int max = num1 > num2 ? num1 : num2;

            Console.WriteLine($"Max number is: {max}");
        }

        public static void Exercise3()
        {
            Console.WriteLine("Enter width of the image: ");
            int width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter height of the image: ");
            int height = Convert.ToInt32(Console.ReadLine());

            var orientation = width > height ? Orientation.Landscape : Orientation.Portrait;
            Console.WriteLine($"Orientation of the image is: {orientation}");
        }

        public enum Orientation
        {
            Portrait,
            Landscape,
        }

        public static void Exercise4()
        {
            Console.WriteLine("Enter the speed limit: ");
            int speedLimit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is the speed of the car?");
            int speedCar = Convert.ToInt32(Console.ReadLine());

            if (speedLimit >= speedCar)
            {
                Console.WriteLine("Ok");
                return;
            }

            var points = (speedCar - speedLimit) / 5 + 1;

            if (points > 12)
            {
                Console.WriteLine("License Suspended");
            }
            else
            {
                Console.WriteLine($"Demerit points: {points}");
            }

        }
    }
}
