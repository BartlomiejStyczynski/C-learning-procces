using System;
using System.Dynamic;
using System.Security.Cryptography;

namespace StackOverflowNew
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Create a new post");
            
            Console.WriteLine("Give us a title");
            var title = Console.ReadLine().ToUpper();

            Console.WriteLine("What's the discribtion");
            var describtion = Console.ReadLine();

            var post = new Post(title, describtion);
            post.UpVote();
 
            Console.WriteLine(post.Title);


        }
    }
}
