using System;
using CybersecurityAwarenessBot.Services;

namespace CybersecurityAwarenessBot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Cybersecurity Awareness Assistant";

            CybersecurityChatbot chatbot = new CybersecurityChatbot();

            chatbot.Start();
        }
    }
}