using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock
{
    class Program
    {
        static void Main(string[] args)
        {

            // DateTime Curr = DateTime.Now;

            Console.WriteLine("Enter the Hours displayed on the Analog Clock:");
            int angHour = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Enter the Minutes displayed on the Analog Clock:");
            int angMinute = int.Parse(Console.ReadLine());


            double hourAngle = (angHour % 12) * 30 + (angMinute / 2.0);
            // ( 0.5  * (60 * (Curr.Hour % 12) + Curr.Minute));
            double minuteAngle = angMinute * 6;
            // double minuteAngle = 60 * Curr.Minute;


            double angDiff = Math.Abs(hourAngle - minuteAngle);
            double angLesser = Math.Min(360 - angDiff, angDiff);

            Console.WriteLine();
            Console.WriteLine(" The lesser angle in between hours & minutes is: " + angLesser + " degrees. ");
            Console.WriteLine();
            Console.WriteLine(" Press any key to Exit, Thank You.");
            Console.ReadKey();

        }
    }
}
