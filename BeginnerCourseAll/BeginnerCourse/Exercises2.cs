using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BeginnerCourse
{
    public class Exercises2
    {
        public static void Exercise1()
        {
            int count = 0;

            for (var i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    count++;
                }
            }

            Console.WriteLine($"Between 1 and 100, the count of numbers divisible by 3 are: {count}");

        }

        public static void Exercise2()
        {
            int total = 0;

            Console.WriteLine($"Total is: {total}");

            while (true)
            {
                Console.WriteLine("Enter a number to calculate total or 'OK' to exit: ");
                var input = Console.ReadLine();

                if (input.ToUpper() == "OK" || String.IsNullOrWhiteSpace(input))
                {
                    break;
                }

                total += Convert.ToInt32(input);
                Console.Clear();
                Console.WriteLine($"Total is: {total}");
            }
        }

        public static void Exercise3()
        {
            Console.WriteLine("Enter a number to calculate the factorial: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int factorial = 1;

            for (int i = number; i > 0; i--)
            {
                factorial *= i;
            }

            Console.WriteLine($"{number}! = {factorial}");
        }

        public static void Exercise4()
        {
            var number = new Random().Next(1, 11);
            var guesses = new List<int>();
            //Console.WriteLine(number);

            Console.WriteLine("Guess a number between 1 and 10: ");

            for (var i = 0; i < 4; i++)
            {
                int guess = Convert.ToInt32(Console.ReadLine());

                if (guess == number)
                {
                    Console.Clear();
                    Console.WriteLine("You Win! The correct number was: " + guess);
                    return;
                }
                else if (guess != number)
                {
                    guesses.Add(guess);

                    Console.Clear();
                    Console.WriteLine("Incorrect, guess another number between 1 and 10 (guesses left: " + (4 - guesses.Count()) + ")");

                    Console.Write("Numbers already guessed: ");

                    foreach (var incorrect in guesses)
                    {
                        Console.Write(incorrect);

                        if (guesses[guesses.Count - 1] != incorrect)
                        {
                            Console.Write(", ");
                        }
                    }

                    Console.WriteLine();
                }
            }

            Console.WriteLine("You Loose!");

        }

        public static void Exercise5()
        {
            Console.WriteLine("Enter a series of numbers separated by a comma: ");
            var input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Incorrect input, try again");
                input = Console.ReadLine();
            }

            var numbers = input.Split(',');
            var max = Convert.ToInt32(numbers[0]);

            foreach (var str in numbers)
            {
                if(!String.IsNullOrWhiteSpace(str))
                {
                    var number = Convert.ToInt32(str);
                    if (number > max)
                    {
                        max = number;
                    }
                }
            }

            Console.WriteLine($"Max number is: {max}");
        }
    }
}
