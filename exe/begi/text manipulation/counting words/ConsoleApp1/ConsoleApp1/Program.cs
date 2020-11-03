
using System;
using System.IO;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            var directory = DirectoryInfo.GetFiles(@"c:\Users\styczyniaki\Documents", "*.txt", SearchOption.AllDirectories);
            foreach (var derectory in directory)
            {
                Console.WriteLine(derectory);
            }


        }
    }
}
