//Your job is to write a program for a speed camera. 
//For simplicity, ignore the details such as camera, sensors, etc and focus purely on the logic.
//Write a program that asks the user to enter the speed limit.Once set, the program asks for the speed of a car.
//If the user enters a value less than the speed limit, program should display Ok on the console.
//If the value is above the speed limit, the program should calculate the number of demerit points.
//For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on the console. 
//If the number of demerit points is above 12, the program should display License Suspended.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedCamera
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("S|P|E|E|D C|A|M|E|R|A");
            Console.Write("Enter the Speed: ");
            double speedLimit = Convert.ToDouble(Console.ReadLine());
            double speedPoints = speedLimit - 70;
            double demeritPoint = speedPoints * .2;
            double pointsLeft = 12 - demeritPoint;

            if (speedLimit <= 70 && speedLimit > 45)
            {
                Console.WriteLine("Your driving is OK a.k.a SAFE a.k.a Awesome!!");
                Console.WriteLine("Keep up the good work: Follow the speed limit");
            }

            else if (speedLimit > 70 && speedLimit < 130)
            {
                Console.WriteLine("The speed limit is: 70 km/hr");
                Console.WriteLine("Your speed is: " + speedLimit + " km/hr");
                Console.WriteLine("You are over speed limit of: " + speedPoints + " km/hr");
                Console.WriteLine("Your demerit point is: " + demeritPoint);
                Console.WriteLine("Your points before the license suspension is: " + pointsLeft);
                Console.WriteLine("P|L|E|A|S|E D|R|I|V|E C|A|R|E|F|U|L|L|Y");
            }

            else if (speedLimit <= 45)
            {
                Console.WriteLine("YOU ARE DRIVING VERY SLOW .... PLEASE FOLLOW THE TRAFFIC FLOW :-) ");
            }

            else
            {
                Console.WriteLine("The speed limit is: 70 km/hr");
                Console.WriteLine("You are over speed limit of: " + speedPoints + " km/hr");
                Console.WriteLine("Your demerit point is: " + demeritPoint);
                Console.WriteLine("Your License is Suspended");
            }
        }
    }
}
