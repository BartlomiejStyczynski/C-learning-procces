using System;

namespace Constructor_Inheritance
{
    public class Vehicle
    {
        private readonly string _registrationNumber;

        public Vehicle()
        {
            Console.WriteLine("!");
        }

        public Vehicle(string registrationNumber)
        {
            _registrationNumber = registrationNumber;
        }
    }
}
