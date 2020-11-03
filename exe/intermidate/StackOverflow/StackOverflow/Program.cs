using System;
using System.ComponentModel;

namespace StackOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var post = new Post();

            while (true)
            {

                Console.WriteLine("Enter a title");
                post.ArticTitle(Console.ReadLine().ToUpper());
                Console.WriteLine("Are you sure?");
                var titleConfirmation = Console.ReadLine();

                if (titleConfirmation.Normalize() == "Yes")
                    break;
                else
                {
                    break;
                }


            }

            while (true)
            {
                Console.WriteLine("Enter a describtion");
                post.Describtion(Console.ReadLine());
                Console.WriteLine("Are you sure?");
                var describtionCofirmation = Console.ReadLine();

                if (describtionCofirmation.Normalize() == "Yes")
                    break;

                else
                {
                    break;
                }




            }
            Console.Clear();
            Console.WriteLine("Would you like to (display) post or (make) a new one?");
            var afterPosting = Console.ReadLine().Normalize();
            if(afterPosting == "display")
            {
                Console.WriteLine(post.Title);
                Console.Wrinteline("Added: " + _addTime )
                Console.WriteLine()
            }

           

            









        }
    }
}
