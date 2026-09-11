using System;
using System.IO;

namespace CybersecurityAwarenessBot.Services
{
    public class AsciiArt
    {
        public void DisplayLogo()
        {
            string filePath = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "Assets",
                "ascii-logo.txt"
            );

            if (File.Exists(filePath))
            {
                string logo = File.ReadAllText(filePath);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(logo);
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.WriteLine("ASCII logo file could not be found.");
            }
        }
    }
}