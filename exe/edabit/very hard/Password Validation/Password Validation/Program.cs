using System;
using System.Text.RegularExpressions;

//Length between 6 and 24 characters.
//At least one uppercase letter(A-Z).
//At least one lowercase letter(a-z).
//At least one digit(0-9).
//Maximum of 2 repeated characters.
//"aa" is OK 👍
//"aaa" is NOT OK 👎
//Supported special characters:
//! @ # $ % ^ & * ( ) + = _ - { } [ ] : ; " ' ? < > , .

namespace Password_Validation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public static bool ValidatePassword(string password)
        {

            string validPasswordPattern ="^[a-zA-Z][0-9]{6,24}$";

            Regex validatePassword = new Regex(validPasswordPattern);




        }
    }
}
