using System;

namespace HttpCookie
{
    class Program
    {
        static void Main(string[] args)
        {
            var cookie = new Cookie();

            cookie["name"] = "Bart";

            Console.WriteLine(cookie["name"]);
        }
    }
}
