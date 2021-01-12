using System;
using RandomCharacterGenLibrary;

namespace RandomCharacterGen
{
    class Program
    {

        static void Main(string[] args)
        {
            MessagesToUser.Title();
            GetInfo.CharacterInfo("Add an occupation: ", CharacterDataLists.occupations);
            GetInfo.CharacterInfo("Add a location: ", CharacterDataLists.locations);
            GetInfo.CharacterInfo("Add an item: ", CharacterDataLists.items);
            GetInfo.CharacterInfo("Add a motive: ", CharacterDataLists.motives);
            MessagesToUser.Result();
            MessagesToUser.TryAgain();

            Console.ReadLine();
        }


      
    }
}
