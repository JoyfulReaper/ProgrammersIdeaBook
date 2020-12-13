using System;

namespace CountVowels
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            Console.WriteLine("Vowel Counter");
            Console.WriteLine("Please enter a word or sentence:");
            var input = Console.ReadLine();

            int numVowels = 0;
            int consonants = 0;
            int whiteSpace = 0;
            int numbers = 0;
            int unknown = 0;

            foreach(char c in input)
            {
                if(Array.IndexOf(vowels, char.ToLower(c)) >= 0)
                {
                    numVowels++;
                }
                else if(char.IsLetterOrDigit(c))
                {
                    if (char.IsLetter(c))
                    {
                        consonants++;
                    }
                    else if(char.IsDigit(c))
                    {
                        numbers++;
                    }
                }
                else if(char.IsWhiteSpace(c))
                {
                    whiteSpace++;
                }
                else
                {
                    unknown++;
                }
            }

            Console.WriteLine();
            Console.WriteLine($"'{input}' contains: ");
            Console.WriteLine($"{numVowels} vowels.");
            Console.WriteLine($"{consonants} consonants.");
            Console.WriteLine($"{whiteSpace} white space characters.");
            Console.WriteLine($"{unknown} other charcters.");
        }
    }
}
