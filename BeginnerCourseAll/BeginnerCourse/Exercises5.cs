using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeginnerCourse
{
    public class Exercises5
    {
        private static string _currentDir = Environment.CurrentDirectory;
        private static string _path = Directory.GetParent(_currentDir).Parent.Parent.FullName + @"\TextFile1.txt";

        public static void Exercise1()
        {
            var text = File.ReadAllText(_path);
            var arrayText = text.Split(' ');

            var textList = new List<string>();

            foreach (var item in arrayText)
            {
                if (String.IsNullOrWhiteSpace(item))
                {
                    continue;
                }
                textList.Add(item);
            }

            Console.WriteLine("Number of words in text file: " + textList.Count());
        }

        public static void Exercise2()
        {
            var text = File.ReadAllText(_path);
            var arrayText = text.Split(' ');

            var maxWord = arrayText[0];

            foreach (var word in arrayText)
            {
                if (maxWord.Length < word.Length)
                {
                    maxWord = word;
                }
            }

            Console.WriteLine("The longest word in the file is: " + maxWord);
        }
    }
}
