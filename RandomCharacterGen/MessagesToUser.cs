using System;
using RandomCharacterGenLibrary;

namespace RandomCharacterGen
{
    public class MessagesToUser
    {
        public static void Title()
        {
            Console.WriteLine("************************************");
            Console.WriteLine("*****RANDOM CHARACTER GENERATOR*****");
            Console.WriteLine("************************************\n");
        }

        public static void Result()
        {
            Console.WriteLine($"Your Character is a {GenerateRandom.Random(CharacterDataLists.occupations)}." +
                $"\nThey are located in {GenerateRandom.Random(CharacterDataLists.locations)}." +
                $"\nTheir item of interest is a {GenerateRandom.Random(CharacterDataLists.items)}." +
                $"\nThey are motivated by {GenerateRandom.Random(CharacterDataLists.motives)}");
        }

        public static void TryAgain()
        {
            string answer;

            do
            {
                Console.Write("\nWould you like to re-generate the Character? y/n: ");
                answer = Console.ReadLine();
                Console.WriteLine();

                if (answer.ToLower() == "y")
                {
                    Result();
                }

            } while (answer.ToLower() == "y");

            Console.WriteLine("\nHappy Writing");
        }
    }
}
