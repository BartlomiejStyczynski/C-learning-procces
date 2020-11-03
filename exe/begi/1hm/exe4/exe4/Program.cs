using System;

namespace exe4
{
    class Program
    {
        static void Main(string[] args)
        {

            //4- Your job is to write a program for a speed camera. For simplicity, ignore the details such as camera, sensors, etc and focus purely on the logic. 
            //Write a program that asks the user to enter the speed limit. Once set, the program asks for the speed of a car. If the user enters a value less than the speed limit, 
            //  program should display Ok on the console.
            //If the value is above the speed limit, the program should calculate the number of demerit points. For every 5km/hr above the speed limit,
            // 1 demerit points should be incurred and displayed on the console. If the number of demerit points is above 12, the program should display License Suspended.



            Console.WriteLine("What's the speed limit?");

            var speedLimit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What's the speed of car?");

            var speedCar = Convert.ToInt32(Console.ReadLine());
            if (speedCar > speedLimit)
            {
                var points = ((speedCar - speedLimit) / 5) ;
                if (points >= 12)
                {
                    Console.WriteLine("You are suspended from driving");
                }
                else
                {
                    Console.WriteLine("You've got {0} points", points);
                }


            }
            else
            {

                Console.WriteLine("All good");
            }



        }
    }
}
