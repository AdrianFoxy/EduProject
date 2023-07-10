using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace EducationalApp.LanguareBasics
{
    public class LanguaeBasicsTasks
    {
        public static void TaskConvertSecondsIntoMinutes()
        {
            Console.WriteLine("Eg:" +
                              "\nseconds = 288970" +
                              "\nThe given number of seconds is equivalent to \"3 days, 8 hours, 16 minutes, 10 seconds\"" +
                              "\nOutput: 3 days, 8 hours, 16 minutes, 10 seconds" +
                              "\nNote: Don't use any control statements such as 'if' or loops." +
                              "\nDon't use any predefined API (classes or structs).\n" +
                              "\nNote: Don't use any control statements such as 'if' or loops.\nDon't use any predefined API (classes or structs).\n");

            int seconds_per_minute = 60; //1 minute = 60 seconds
            int seconds_per_hour = 60 * 60; //1 hour = 60 minute (each minute is 60 seconds)
            int seconds_per_day = 24 * 60 * 60; //1 day = 24 hours (each hour is 60 minutes; and each minute is 60 seconds)
            int seconds_per_year = 60 * 60 * 24 * 366; // 1 normal year 366 days


            int seconds = Convert.ToInt32(Console.ReadLine());
            int remaining_seconds = seconds;

            int years = seconds / seconds_per_year;
            remaining_seconds -= years * seconds_per_year;

            int days = remaining_seconds / seconds_per_day; 
            remaining_seconds -= days * seconds_per_day; 

            int hours = remaining_seconds / seconds_per_hour;
            remaining_seconds -= hours * seconds_per_hour;

            int minutes = remaining_seconds / seconds_per_minute;
            remaining_seconds -= minutes * seconds_per_minute;


            Console.WriteLine($"There is {years} years, {days} days, " +
                              $"{hours} hours, {minutes} minutes and {remaining_seconds} seconds in {seconds} seconds \n");
        }
        public static void TaskNearestThousand()
        {
            Console.WriteLine("Write a C# program to get nearest thousand of given integer number. \nHere, let name the input value as \"number\".\n" +
                              "Instructions\n\n" +
                              "If the number's last three digits are greater than or equal to 500; it should \"round up\" the number.\n" +
                              "If the number's last three digits are less than 500; it should \"round down\" the number.\n" +
                              "If the number is less than 500; it should round up to 1000.\n" +
                              "Eg:\n\nInput: 499  Output: 1000\n" +
                              "Input: 500  Output: 1000\n" +
                              "Input: 999  Output: 1000\n" +
                              "Input: 1000 Output: 1000\n" +
                              "Input: 1499 Output: 1000\n" +
                              "Input: 1500 Output: 2000\n" +
                              "Note: Don't use any predefined math functions.\n");

            Console.WriteLine("Enter the number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Nearest Thousand is {NearestThousand(number)}\n");
        }

        public static int NearestThousand(int number)
        {
            // for example 3894
            int prev_thousand = number / 1000 * 1000; // here is 3000
            int last_three_digist = number % 1000; // here is 894
            int rouding_value = (last_three_digist >= 500) ? 1000 : 0;
            return prev_thousand + rouding_value;
        }
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
