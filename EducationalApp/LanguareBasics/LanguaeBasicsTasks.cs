using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationalApp.LanguareBasics
{
    public class LanguaeBasicsTasks
    {
        public static void TaskAreaOfCircle()
        {
            bool validInput = false;
            double radius = 0;

            Console.WriteLine("The radius value can be assigned to a variable; need not to take the value from the keyboard input." +
                "\nFormula: PI * radius * radius" +
                "\nPI is a constant value, approximately equal to 3.14159, which is equal \n" +
                "to the ratio of the circumference of any circle to its diameter.\n");

            Console.WriteLine("Enter circle radius to get value of area: ");

            while (!validInput)
            {
                if (double.TryParse(Console.ReadLine(), out radius) && radius > 0) validInput = true;
                else Console.WriteLine("Invalid input. Please enter a positive numeric value for the radius.");
            }
            Console.WriteLine($"Area of Circle with radius {radius} is {AreaOfCircle(radius)}");
        }

        static double AreaOfCircle(double radius)
        {
            return double.Pi * radius * radius;
        }
    }
}
