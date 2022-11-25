using System;
using System.Collections.Generic;

namespace BeginnerCourse
{
    public class Exercises3
    {
        public static void Exercise1() //Display likes on a post
        {
            var namesList = new List<string>();

            while (true)
            {
                Console.Clear();

                Console.WriteLine("Enter a name or press Enter to exit: ");

                if (namesList.Count > 0)
                {
                    Console.Write("Current names in list: ");

                    foreach (string name in namesList)
                    {
                        if (namesList[namesList.Count - 1] == name)
                        {
                            Console.WriteLine(name);
                            continue;
                        }
                        Console.Write(name + ", ");
                    }

                    Console.Clear();
                    
                    Console.WriteLine();
                }

                var names = Console.ReadLine();

                if (names == "")
                {
                    break;
                }

                namesList.Add(names);
            }

            if (namesList.Count == 1)
            {
                Console.Write($"{namesList[0]} likes your post");
            }
            else if (namesList.Count == 2)
            {
                Console.WriteLine($"{namesList[0]} and {namesList[1]} likes your post");
            }
            else
            {
                Console.WriteLine($"{namesList[0]}, {namesList[1]} and {namesList.Count - 2} others likes your post");
            }
        }

        public static void Exercise2() //Reverse name
        {
            Console.WriteLine("Enter your name: ");
            var name = Console.ReadLine();

            char[] charArray = name.ToCharArray();

            Array.Reverse(charArray);
            Console.Clear();
            Console.WriteLine($"Your name reversed is: {new String(charArray)}");
        }

        public static void Exercise3() //Creates a list of unique numbers
        {
            var numberList = new List<int>();

            while (numberList.Count < 5)
            {
                Console.WriteLine("Enter a unique number: ");
                
                Console.WriteLine("Current list is: ");

                foreach (var currentNumber in numberList)
                {
                    Console.WriteLine(currentNumber);
                }

                var number = Convert.ToInt32(Console.ReadLine());

                Console.Clear();

                if (numberList.Contains(number))
                {
                    Console.WriteLine("Number must be unique! Try again");
                    continue;
                }

                numberList.Add(number);
            }

            Console.WriteLine("Your complete list of numbers is: ");

            foreach (var number in numberList)
            {
                Console.WriteLine(number);
            }
        }

        public static void Exercise4() //Displays each number in an input list once
        {
            var numberList = new List<int>();

            while (true)
            {
                Console.Clear();

                Console.WriteLine("Enter a number or type 'Quit' to exit and view unique numbers:");
                var input = Console.ReadLine();

                if (input.ToUpper() == "QUIT")
                {
                    break;
                }

                if (!numberList.Contains(Convert.ToInt32(input)))
                {
                    numberList.Add(Convert.ToInt32(input));
                }
            }

            Console.WriteLine("The unique numbers are: ");

            foreach (var number in numberList)
            {
                Console.WriteLine(number);
            }
        }

        public static void Exercise5() //Gets 3 smallest numbers of a list of a minimum 5 numbers
        {
            var numbersList = new List<int>();
            Console.WriteLine("Enter a list of at least 5 comma separated numbers:");

            while (true)
            {
                var input = Console.ReadLine();
                var numbers = input.Split(',');

                if (numbers.Length < 5)
                {
                    Console.Clear();

                    Console.WriteLine("Invalid List. Try again:");
                    continue;
                }

                foreach (var number in numbers)
                {
                    numbersList.Add(Convert.ToInt32(number));
                }

                break;
            }

            numbersList.Sort();

            Console.WriteLine("The 3 smallest numbers are: ");
            for (var i = 0; i < 3; i++)
            {
                Console.WriteLine(numbersList[i]);
            }
        }
    }
}
