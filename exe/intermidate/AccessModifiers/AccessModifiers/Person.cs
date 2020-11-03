using System;

namespace AccessModifiers
{
    partial class Program
    {
        public class Person
        {
            private DateTime _birthdate;

            public DateTime Birthdate
            {
                get { return _birthdate}
                set { _birthdate = value}
            }


        }
    }
}
