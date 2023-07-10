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
            Console.WriteLine($"Area of Circle with radius {radius} is {AreaOfCircle(radius)} \n");
        }

        static double AreaOfCircle(double radius)
        {
            return double.Pi * radius * radius;
        }

        public static void TaskFeetToCentimeters()
        {
            bool validInput = false;
            double feet = 0;
            double inches = 0;
            Console.WriteLine("Eg: \nfeet = 5\ninches = 7\noutput: 170.18 cm\nFormula:\n1 inch = 2.54 cm\n1 feet = 12 inches\n");

            while (!validInput)
            {
                Console.Write("Enter height in feet: ");
                if (double.TryParse(Console.ReadLine(), out feet) && feet > 0)
                {
                    Console.Write("Enter height in inches: ");
                    if (double.TryParse(Console.ReadLine(), out inches) && inches > 0)
                    {
                        validInput = true;
                    }
                }
                else Console.WriteLine("Invalid input. Please enter a positive numeric value for feet and inches.");
            }
            Console.WriteLine($"Here is result of Feet To Centimetes, with values of feer - {feet} and inches - {inches}, and it will be {FeetToCentimeters(feet, inches)} cm. \n");
        }

        public static double FeetToCentimeters(double feet, double inches)
        {
            return (feet * 12 + inches)*2.54;
        }
    }
}
