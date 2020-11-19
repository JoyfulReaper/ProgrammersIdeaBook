using System;
using System.Collections.Generic;
using System.Text;

namespace FibonacciSequence
{
    public static class ConsoleHelper
    {
        public static ConsoleColor DefaultColor { get; set; } = Console.ForegroundColor;

        /// <summary>
        /// Output a message to the console in color.
        /// </summary>
        /// <param name="color">The color to output in</param>
        /// <param name="message">The message to output</param>
        public static void ColorWrite(ConsoleColor color, string message)
        {
            ConsoleColor old = Console.ForegroundColor;

            Console.ForegroundColor = color;
            Console.Write(message);
            Console.ForegroundColor = old;
        }

        /// <summary>
        /// Output a message to the console using the default color.
        /// </summary>
        /// <param name="message">The Message to output</param>
        public static void ColorWrite(string message)
        {
            ColorWrite(DefaultColor, message);
        }

        /// <summary>
        /// Out put a message and newline to the console in color. 
        /// </summary>
        /// <param name="color">The color to output</param>
        /// <param name="message">The Message to output</param>
        public static void ColorWriteLine(ConsoleColor color, string message)
        {
            ColorWrite(color, $"{message}{ System.Environment.NewLine }");
        }

        /// <summary>
        /// Out put a message and newline to the console in the default color. 
        /// </summary>
        /// <param name="message">The message to output</param>
        public static void ColorWriteLine(string message)
        {
            ColorWriteLine(DefaultColor, message);
        }

        public static int GetValidInt(string prompt)
        {
            return GetValidInt(prompt, Console.ForegroundColor);
        }

        public static int GetValidInt(string prompt, ConsoleColor color)
        {
            return GetValidInt(prompt, int.MinValue, int.MaxValue, color);
        }

        public static int GetValidInt(string prompt, int min, int max)
        {
            return GetValidInt(prompt, min, max, Console.ForegroundColor);
        }

        public static int GetValidInt(string prompt, int min, int max, ConsoleColor color)
        {
            int output;

            do
            {
                ColorWrite(color, prompt);
            } while (!int.TryParse(Console.ReadLine(), out output) || output < min || output > max);

            return output;
        }
    }
}
