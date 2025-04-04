using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;
namespace CyberBot2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            PlayGreeting();//Playing the voice message that i recorded,
            DisplayAsciiLogo();//Displaying the ArtLogo that i coded.
            GreetUser();
        }

        static void PlayGreeting()
        {
            try
            {
                SoundPlayer player = new SoundPlayer(@"Greeting.wav");
                player.PlaySync(); // Play synchronously to wait for completion.
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error playing greeting: {ex.Message}");
            }
        }

        static void DisplayAsciiLogo()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(@"

   ______      __                _________ __     
  / ____/_  __/ /_  ___  _____  / ____/ (_) /____ 
 / /   / / / / __ \/ _ \/ ___/ / __/ / / / __/ _ \
/ /___/ /_/ / /_/ /  __/ /    / /___/ / / /_/  __/
\____/\__, /_.___/\___/_/____/_____/_/_/\__/\___/ 
     /____/            /_____/                    

");
            Console.ResetColor();
            Console.WriteLine(new string('-', 40)); // Decorative divider
        }

        static void GreetUser()
        {
            Console.Write("Please enter your name: ");// Asking the user to add their name.
            string userName = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(userName))
            {
                userName = "User"; // Default name if input is empty
            }

            Console.WriteLine($"\nHello, {userName}! I'm here to help you stay safe online.");
            Console.WriteLine("Ask me anything about myself as a chatbox, password safety, phishing, safe browsing, and more.\n");
            Console.WriteLine(new string('-', 40)); // Decorative divider
        }
    }
}
