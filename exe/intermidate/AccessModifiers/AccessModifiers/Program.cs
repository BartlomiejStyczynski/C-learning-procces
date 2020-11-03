using System;
namespace AccessModifiers
{
    partial class Program
    {

        static void Main(string[] args)
        {
            // encapsulation - information hiding

            var person = new Person();

            person.SetBirthdate(new DateTime(1982, 1, 1));
            System.Console.WriteLine(person.GetBirthdate());

        }
    }
}
