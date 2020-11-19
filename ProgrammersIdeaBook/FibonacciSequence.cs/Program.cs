using System;

namespace FibonacciSequence
{ 
    public class Program
    {
        static void Main(string[] args)
        {
            ConsoleHelper.DefaultColor = ConsoleColor.Red;
            ConsoleHelper.ColorWriteLine("Fibonacci Sequence: ");
            ConsoleHelper.ColorWriteLine(ConsoleColor.Yellow, "1. Recursive");
            ConsoleHelper.ColorWriteLine(ConsoleColor.Yellow, "2. Loop");
            Console.WriteLine();

            int method = ConsoleHelper.GetValidInt("Choose calculation method: ", 1, 2, ConsoleColor.Green);
            int term = ConsoleHelper.GetValidInt("Enter Nth term: ", ConsoleColor.Green);

            long[] result = FibonacciSequenceHelper.FibonacciSequence(0, 1, term, method == 1 ? true : false);


            Console.WriteLine();
            foreach (var number in result)
            {
                ConsoleHelper.ColorWriteLine(ConsoleColor.Cyan, number.ToString());
            }

            Console.WriteLine();
            ConsoleHelper.ColorWrite(ConsoleColor.Green, "Again? y/N: ");
            string again = Console.ReadLine();

            if(Char.ToUpper(again[0]) == 'Y')
            {
                Main(null);
            }

        }
    }
}
