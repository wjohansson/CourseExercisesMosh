using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace BeginnerCourse
{
    public class Exercises4
    {
        public static void Exercise1()
        {
            Console.WriteLine("Enter a sequence of numbers separated by a hyphen:");
            var input = Console.ReadLine();

            var numbers = input.Split('-');
            var numbersList = new List<int>();

            foreach (var number in numbers)
            {
                numbersList.Add(Convert.ToInt32(number));
            }

            if (IsConsecutive(numbersList))
            {
                Console.WriteLine("Consecutive");
                return;
            }

            Console.WriteLine("Numbers are not consecutive");
        }

        public static bool IsConsecutive(List<int> numbersList)
        {
            numbersList.Sort();

            for (var i = 0; i < numbersList.Count - 1; i++)
            {
                if (Math.Abs(numbersList[i + 1] - numbersList[i]) != 1)
                {
                    return false;
                }
            }

            return true;
        }

        public static void Exercise2()
        {
            Console.WriteLine("Enter a sequence of numbers separated by a hyphen:");
            var input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))
            {
                return;
            }

            var numbers = input.Split('-');

            var numbersList = new List<int>();

            if (CheckDuplicate(numbers, numbersList))
            {
                Console.WriteLine("Contains Duplicate");
                return;
            }

            Console.WriteLine("Does not contain duplicate");
        }

        public static bool CheckDuplicate(string[] numbers, List<int> numbersList)
        {
            foreach (var number in numbers)
            {
                var intNumber = Convert.ToInt32(number);

                if (numbersList.Contains(intNumber))
                {
                    return true;
                }

                numbersList.Add(Convert.ToInt32(intNumber));
            }

            return false;
        }

        public static void Exercise3()
        {
            Console.WriteLine("Write a time (ex: 19:20):");
            var time = Console.ReadLine().Split(':');

            if (CheckTimeFormat(time))
            {
                Console.WriteLine("Valid time");

                return;
            }

            Console.WriteLine("Invalid time");
        }

        public static bool CheckTimeFormat(string[] time)
        {
            var hours = Convert.ToInt32(time[0]);
            var minutes = Convert.ToInt32(time[1]);

            if (hours >= 0 && hours < 24 && minutes >= 0 && minutes < 60)
            {
                return true;
            }

            return false;
        }

        public static void Exercise4()
        {
            Console.WriteLine("Enter a sentence: ");
            var sentence = Console.ReadLine().Split(' ');

            Console.WriteLine(ConvertToPascal(sentence));
        }

        public static string ConvertToPascal(string[] sentence)
        {
            var variableName = "";

            foreach (var word in sentence)
            {
                if (!String.IsNullOrWhiteSpace(word))
                {
                    variableName += char.ToUpper(word[0]) + word.ToLower().Substring(1);
                }
            }

            return variableName;
        }

        public static void Exercise5()
        {
            Console.WriteLine("Write an english word:");
            var word = Console.ReadLine().ToLower();

            Console.WriteLine(VowelsCount(word));
        }

        public static int VowelsCount(string word)
        {
            var vowelsCount = 0;
            var vowels = new List<char>(new char[] { 'a', 'e', 'o', 'u', 'i' });

            foreach (var letter in word)
            {
                if (vowels.Contains(letter))
                {
                    vowelsCount++;
                }
            }

            return vowelsCount;
        }
    }
}
