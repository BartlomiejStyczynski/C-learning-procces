﻿using System;
using System.Collections.Generic;

namespace exe1
{
    class Program
    {
        static void Main(string[] args)
        {
            //            1 - When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.

            //If no one likes your post, it doesn't display anything.
            //If only one person likes your post, it displays: [Friend's Name] likes your post.
            //If two people like your post, it displays: [Friend 1] and[Friend 2] like your post.
            //If more than two people like your post, it displays: [Friend 1], [Friend 2] and[Number of Other People] others like your post.
            //Write a program and continuously ask the user to enter different names, until the user presses Enter (without supplying a name). Depending on the number of names provided, display a message based on the above pattern.

            var names = new List<string>();


            while(true)
            {
                var input = Console.ReadLine();
                    if (String.IsNullOrWhiteSpace(input))
                    break;



                names.Add(input);

            }

            if (names.Count > 2 && names.Count - 2 > 1)
                Console.WriteLine("{0}, {1} and {2} others liked this post", names[0], names[1], names.Count - 2);
           
            else if (names.Count > 2 && names.Count - 2 == 1)
                Console.WriteLine("{0}, {1} and {2} other liked this post", names[0], names[1], names.Count - 2);
            
            else if (names.Count == 2)
                Console.WriteLine("{0} and {1} liked this post", names[0], names[1]);
            
            else 
                Console.WriteLine("{0} liked this post", names[0]);






        }

    }
}
