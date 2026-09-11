using System;
using CybersecurityAwarenessBot.Services;

namespace CybersecurityAwarenessBot.Services
{

    public class CybersecurityChatbot
    {
        private VoiceGreeting voiceGreeting = new VoiceGreeting();
        private AsciiArt asciiArt = new AsciiArt();

        private ResponseService responseService = new ResponseService();

        public void Start()
        {
            voiceGreeting.PlayGreeting();

            asciiArt.DisplayLogo();

            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine();
            Console.WriteLine("==============================================");
            Console.WriteLine("       CYBERSECURITY AWARENESS ASSISTANT");
            Console.WriteLine("==============================================");

            Console.WriteLine();
            Console.Write("Please enter your name: ");

            string name = Console.ReadLine() ?? "";

            UserProfile user = new UserProfile(name);

            while (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Name cannot be empty.");
                Console.Write("Please enter your name: ");
                name = Console.ReadLine() ?? "";
            }

            Console.WriteLine();
            Console.WriteLine("==============================================");
            Console.WriteLine($"       WELCOME, {name.ToUpper()}!");
            Console.WriteLine("==============================================");
            Console.WriteLine();
            Console.WriteLine("I am your Cybersecurity Awareness Assistant.");
            Console.WriteLine("I can help you stay safe while using the internet.");
            Console.WriteLine("Ask me about passwords, phishing, suspicious links,");
            Console.WriteLine("or safe browsing.");
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("You can now ask me a cybersecurity question.");
            Console.WriteLine("Type 'exit' whenever you want to leave the chatbot.");
            Console.WriteLine();

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("You: ");

                string userInput = Console.ReadLine() ?? "";

                Console.ForegroundColor = ConsoleColor.White;

                if (string.IsNullOrWhiteSpace(userInput))
                {
                    Console.WriteLine("Assistant: Please type a question so I can help you.");
                    Console.WriteLine();
                    continue;
                }

                if (userInput.ToLower() == "exit" || userInput.ToLower() == "quit")
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Assistant: Goodbye! Stay safe online.");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                }

                string response = responseService.GetResponse(userInput);

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"Assistant: {response}");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();
            }
        }
    }
}