using System;
using System.Text;

namespace LetterLooper
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a random string of characters:");
            var input = Console.ReadLine();

            var output = new StringBuilder();

            foreach (var letter in input)
            {
                var theEqualizer = char.ToLower(letter);
                var timesToRepeat = input.IndexOf(letter) + 1;
                var repeatsCreated = System.Linq.Enumerable.Repeat(theEqualizer, timesToRepeat);
                var combinedLetters = string.Join("", repeatsCreated);
                var result = char.ToUpper(combinedLetters[0]) + combinedLetters.Substring(1);

                if (letter == input[0])
                {
                    output.Append(result);
                }
                else
                {
                    output.Append($"-{result}");
                }
            }

            Console.WriteLine(output);
        }
    }
}
