using System;
using System.Collections.Generic;

namespace RandomCharacterGen
{
    public class GetInfo
    {
        public static void CharacterInfo(string requestInfo, List<string> list)
        {
            string addAnother;
            do
            {
                Console.Write(requestInfo);
                list.Add(Console.ReadLine());
                Console.Write("Add another? y/n: ");
                addAnother = Console.ReadLine();

            } while (addAnother.ToLower() == "y");

            Console.Clear();
        }
    }
}
