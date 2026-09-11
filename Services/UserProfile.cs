namespace CybersecurityAwarenessBot.Services
{
    public class UserProfile
    {
        public string Name { get; set; }

        public UserProfile(string name)
        {
            Name = name;
        }
    }
}