using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initiatilize variables
            string theMatrix,
            neo,
            system,
            enemy,
            inside,
            people,
            unplugged,
            fight;

            string[] profession = new string[4], adj = new string[2];

            // Get input from user
            Console.WriteLine("Welcome, user!");
            Console.WriteLine("Let's play a game of MadLibs!");
            Console.WriteLine("Please tell me your name: ");
            neo = Console.ReadLine();

            Console.WriteLine($"Hello {neo}! Are you ready? What is something you want to know more" +
                $"about?");
            theMatrix = Console.ReadLine();
                        
            Console.WriteLine($"OOooh! You wanna learn more about {theMatrix}, eh?");
            Console.WriteLine($"Okay, well first tell me what you already know about {theMatrix}");
            Console.WriteLine($"What noun would you classify {theMatrix} as?");
            system = Console.ReadLine();

            Console.WriteLine($"Give me an opposing noun to {system}");
            enemy = Console.ReadLine();

            Console.WriteLine($"Now give me any relaxing noun (present tense)");
            inside = Console.ReadLine();

            Console.WriteLine($"Now I need four professions relating to {system}");
            for (int i = 0; i < profession.Length; i++)
            {
                Console.WriteLine($"Profession (plural) {i + 1} / {profession.Length}");
                profession[i] = Console.ReadLine();
            }







            // Initiatilize story
            string madLibStory =
            $"{theMatrix} is a {system}, {neo}. That system is our {enemy}. " +
            $"But when you're {inside}, you look around, what do you see? " +
            $"{profession[0]}, {profession[1]}, {profession[2]}, {profession[3]}. The very minds " +
            $"of the {people} we are trying to save. But until we do, " +
            $"these people are still a part of that system and that makes " +
            $"them our enemy. You have to understand, most of these people " +
            $"are not ready to be {unplugged}. And many of them are so {adj[0]}, " +
            $"so hopelessly {adj[1]} on the system, that they will {fight} to protect it.";

            // Print Story
            Console.WriteLine(madLibStory);
            Console.ReadKey();

        }
    }
}
