using System;

namespace CybersecurityAwarenessBot.Services
{
    public class ResponseService
    {
        public string GetResponse(string userInput)
        {
            string input = userInput.Trim().ToLower();

            if (input.Contains("how are you"))
            {
                return "I'm doing well! I'm ready to help you learn about cybersecurity.";
            }

            if (input.Contains("purpose") || input.Contains("what do you do"))
            {
                return "My purpose is to help South African citizens understand basic cybersecurity and stay safer online.";
            }

            if (input.Contains("what can i ask") ||
                input.Contains("help") ||
                input.Contains("topics") ||
                input.Contains("what can you help me with?"))
            {
                return "I can help you with four main cybersecurity topics: passwords safety, phishing, suspicious links, and safe browsing. You can ask me a question about any type of these topics.";
            }

            if (input.Contains("password") ||
                input.Contains("passwords") ||
                input.Contains("strong password"))
            {
                return "For better password safety, use a long and unique password for each account. Avoid using your name, birthday, or other easy-to-guess information. Consider using a password and enable multi-factor authentication when available.";
            }

            if (input.Contains("phishing") ||
                input.Contains("phishing scam") ||
                input.Contains("fake email") ||
                input.Contains("fake message"))

            {
                return "Phishing is when criminals use fake emails, messages, or websites to trick you into giving away information such as passwords or banking details. Always check who sent the message before clicking links.";
            }

            if (input.Contains("suspicious message") ||
               input.Contains("suspicious email") ||
               input.Contains("scam message"))
            {
                return "If you receive a suspicious message, do not click its links or open unexpected attachments. Check the sender carefully and verify the request using an official contact method.";
            }

            if (input.Contains("link") ||
                input.Contains("url") ||
                input.Contains("website") ||
                input.Contains("suspicious link") ||
                input.Contains("strange link"))
            {
                return "Be careful with suspicious links. Check the website address before clicking, avoid shortened or unexpected links, and never enter sensitive information on a website you do not trust.";
            }

            if (input.Contains("safe browsing") ||
                input.Contains("browse") ||
                input.Contains("browsing"))
            {
                return "For safer browsing, keep your browser updated, use trusted websites, avoid suspicious downloads, and look for HTTPS before entering sensitive information.";
            }

            if (input.Contains("hello") ||
                input.Contains("hi") ||
                input.Contains("hey") ||
                input.Contains("good morning") ||
                input.Contains("good aftenoon") ||
                input.Contains("good evening"))

            {
                return "Hello! I'm ready to help you with cybersecurity questions.";
            }

            return "I didn't quite understand that. Could you rephrase your question?";
        }
    }
}