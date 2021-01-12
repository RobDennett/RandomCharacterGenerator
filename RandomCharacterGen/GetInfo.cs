using System;
using System.Collections.Generic;

namespace RandomCharacterGen
{
    public class GetInfo
    {
        public static void CharacterInfo(string requestInfo, List<string> list)
        {
            string addAnother = "";
            do
            {
                Console.Write(requestInfo);
                string userInput = Console.ReadLine();

                if (userInput != "")
                {
                    list.Add(userInput);
                    Console.Write("Add another? y/n: ");
                    addAnother = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("That was an invalid. Please try again.");
                    addAnother = "y";
                    Console.WriteLine();
                }

            } while (addAnother.ToLower() == "y");

            Console.Clear();
        }
    }
}
