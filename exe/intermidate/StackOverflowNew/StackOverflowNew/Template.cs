using Microsoft.VisualBasic;
using System;
using System.Drawing;

namespace StackOverflowNew
{
    public class Template 
    {
        

        public Template(string tittle, string describtion, DateTime creationTime, int voteCount)
        {
            Console.Clear();
            foreach(var letter in tittle)
            {
                Console.Write("--");
            }
            Console.WriteLine(tittle);
            foreach(var letter in tittle)
            {
                Console.Write("--");
            }
            Console.WriteLine("Votes: " + voteCount + " Added at: " + creationTime);
            Console.WriteLine();
            Console.WriteLine(describtion);

        }

    }
}
