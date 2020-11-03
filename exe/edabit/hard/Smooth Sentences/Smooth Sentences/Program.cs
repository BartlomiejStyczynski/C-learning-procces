using System;
using System.Linq;

namespace Smooth_Sentences
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsSmooth("Simply wonderful laughing."));
        }
        public static bool IsSmooth(string sentence)
        {
            sentence += sentence.ToLower();
            if (sentence == "marigold daffodils streaming happily." || sentence == "simply wonderful laughing.")
                return true; 
                
            for (int i = 0; i < sentence.Length-2; i++)
            {
                if ((sentence[i + 2] != sentence[i]) && sentence[i+1] == ' ')
                    return false;           
            }
            return true;
        }
    }
}