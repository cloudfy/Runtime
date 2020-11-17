using System;
using System.Collections.Generic;
using System.Text;

namespace Runtime
{
    /// <summary>
    /// Represents input and output to a console.
    /// </summary>
    public static class ColorConsole
    {
        #region === writeline method ===
        /// <summary>
        /// Writes the specified string value followed by a line terminator.
        /// </summary>
        /// <param name="color">Foreground color.</param>
        /// <param name="text">String value.</param>
        public static void WriteLine(ConsoleColor color, string text)
        {
            var setColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ForegroundColor = setColor;
        }
        /// <summary>
        /// Writes the specified string value followed by a line terminator.
        /// </summary>
        /// <param name="color">Foreground color.</param>
        /// <param name="text">Formatted string value.</param>
        /// <param name="args">Arguments to pass into the text.</param>
        public static void WriteLine(ConsoleColor color, string text, params object[] args)
        {
            var setColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.WriteLine(text, args);
            Console.ForegroundColor = setColor;
        } 
        #endregion
    }
}
