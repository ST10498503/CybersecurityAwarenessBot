using System;
using System.IO;
using System.Media;

namespace CybersecurityAwarenessBot.Services
{
    public class VoiceGreeting
    {
        public void PlayGreeting()
        {
            string audioPath = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "Audio",
                "greeting.wav"
            );

            if (File.Exists(audioPath))
            {
                using (SoundPlayer player = new SoundPlayer(audioPath))
                {
                    player.PlaySync();
                }
            }
            else
            {
                Console.WriteLine("Voice greeting file could not be found.");
            }
        }
    }
}