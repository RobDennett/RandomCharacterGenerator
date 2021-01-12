using System;
using System.Collections.Generic;

namespace RandomCharacterGenLibrary
{
    public class GenerateRandom
    {
        public static string Random(List<string> list)
        {
            Random characterInfo = new Random();

            int index = characterInfo.Next(list.Count);

            return list[index];
        }
    }
}
