using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace EducationalApp.LanguareBasics
{
    public class LanguageBasicsTasks
    {
        public static void TaskPatternPrinting()
        {
            Console.WriteLine("Write a C# program to print the following output by using 'for' loop, 'break' and 'continue' statements\n");
            Console.WriteLine("Write a C# program to print the following output:" +
                "\n1 2 3 4 7 8 9 10" +
                "\n1 2 3 4 7 8 9 10" +
                "\n1 2 3 4 7 8 9 10" +
                "\n10 9 8 7 6 5 4 3 2 1" +
                "\n10 9 8 7 6 5 4 3 2 1" +
                "\n10 9 8 7 6 5 4 3" +
                "\n10 9 8 7 6 5 4 3 2 1" +
                "\n1 2 3 4 5 6 7 9 10" +
                "\n\nEach number should be printed by using the loop variable." +
                "\nDon't print full line at-a-time as string." +
                "\nFor example, don't write statements as:" +
                "\nSystem.Console.WriteLine(\"1 2 3 4 7 8 9 10\");" +
                "\nUse for loop, break and continue statements to bring the output.\n");
            PatternPrinting();
        }

        private static void PatternPrinting()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 1; j < 11; j++)
                {
                    if (j == 5 || j == 6)
                    {
                        continue;
                    }
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 10; j >= 1; j--)
                {
                    if (i == 4)
                    {
                        if (j == 3) continue;
                        Console.Write(11 - j + " ");

                    }
                    else
                    {
                        if (i == 2)
                        {
                            if (j == 2 || j == 1) continue;
                        }
                        Console.Write(j + " ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        public static void TaskLargestofThreeNumbersOnlyIf()
        {
            Console.Write("Enter number a:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number b:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number c:");
            int c = Convert.ToInt32(Console.ReadLine());
            LargestOfThreeNumbers(a, b, c);

        }
        private static void LargestOfThreeNumbers(int a, int b, int c)
        {
            int bigger_number = 0;
            if (a >= b)
                if (a >= c) bigger_number = a;
                else bigger_number = c;
            else
                if (b >= c) bigger_number = b;
                else bigger_number = c;

            Console.WriteLine($"Among of {a}, {b} and {c}, bigger number is {bigger_number}\n");

        }
        public static void TaskHeightCategory()
        {
            Console.WriteLine("Write a program to find out \"category of height\" based on the given height of a person (in inches), using \"if\".\n");
            Console.WriteLine("Height categories:" +
                              "\nHeight is less than 150 cm = \"Dwarf\"" +
                              "\nHeight is between 150 cm and 165 cm = \"Average height\"" +
                              "\nHeight is between 165 cm and 195 cm = \"Tall\"\r\n\r\nHeight is above 195 cm = \"Abnormal height\"" +
                              "\nNote: 1 inch = 2.54 centimeter" +
                              "\nYou need to convert the input value (inches) into centimeters." +
                              "\nEg:" +
                              "\nInput: 75" +
                              "\nOutput: Tall\n");

            Console.WriteLine("Enter your Height:");
            int height = Convert.ToInt32(Console.ReadLine());
            WidthCategory(height);
        }
        private static void WidthCategory(int height) 
        {
            if (height < 150) Console.WriteLine("Dwarf");
            else if (height >= 150 && height < 165) Console.WriteLine("Average height\n");
            else if (height > 165 && height <= 195) Console.WriteLine("Tall\n");
            else Console.WriteLine("Abnormal height\n");
        }
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

        private static int NearestThousand(int number)
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

        private static double AreaOfCircle(double radius)
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

        private static double FeetToCentimeters(double feet, double inches)
        {
            return (feet * 12 + inches)*2.54;
        }
    }
}
