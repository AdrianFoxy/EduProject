using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EducationalApp.MainMenu;

namespace EducationalApp.LanguareBasics
{
    public class LanguageBasics
    {
        public static void Tasks()
        {
            Console.Clear();
            string[] subMenuOptions = { "Area of Cicle", "Feet To Centimeters", 
                                        "Nearest Thousand", "Seconds Into Minutes, " +
                                        "Hours etc", "Width Category (if statement)", "Largest of Three Numbers (if statement)",
                                        "Pattern Printing (for loop, break, continue)",
                                        "Exit" };
            MenuAction[] actions = { LanguageBasicsTasks.TaskAreaOfCircle, LanguageBasicsTasks.TaskFeetToCentimeters,
                                     LanguageBasicsTasks.TaskNearestThousand, LanguageBasicsTasks.TaskConvertSecondsIntoMinutes,
                                     LanguageBasicsTasks.TaskHeightCategory, LanguageBasicsTasks.TaskLargestofThreeNumbersOnlyIf,
                                     LanguageBasicsTasks.TaskPatternPrinting};

            SubMenu(subMenuOptions, actions);
        }

        public static void HelloWorldAndConsoleCommands()
        {
            Console.Clear();
            Console.WriteLine("Hello World");

            string studentName = "Scott";
            int studentAge = 20;

            Console.WriteLine("Sup!");
            Console.WriteLine($"{studentName} :) U know, hes age is {studentAge}. He is sooo old, pog \n");
            Console.WriteLine("So, what about u? What is your name and what is your age?");

            string userName = Console.ReadLine()!;
            int userAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Well, hi {userName}! {userAge} it`s ok) \n");

            string[] subMenuOptions = { "Exit" };
            MenuAction[] actions = { };
            SubMenu(subMenuOptions, actions);
        }

        public static void PrimitiveTypes()
        {
            Console.Clear();
            Console.WriteLine("Primite Types \\o/");

            sbyte a = sbyte.MaxValue;
            sbyte b = 100;
            sbyte c = default;

            byte d = byte.MaxValue;
            short e = short.MaxValue;
            ushort f = ushort.MaxValue;
            int g = int.MaxValue;
            uint h = uint.MaxValue;
            long i = long.MaxValue;
            ulong j = ulong.MaxValue;
            float k = float.MaxValue;
            double l = double.MaxValue;
            decimal m = decimal.MaxValue;
            char n = 'A';
            string o = "abc";
            bool p = true;

            Console.WriteLine("sbyte a: " + a);
            Console.WriteLine("sbyte b: " + b);
            Console.WriteLine("sbyte c: " + c);

            Console.WriteLine("byte d: " + d);
            Console.WriteLine("short e: " + e);
            Console.WriteLine("ushort f: " + f);
            Console.WriteLine("int g: " + g);
            Console.WriteLine("uint h: " + h);
            Console.WriteLine("long i: " + i);
            Console.WriteLine("ulong j: " + j);
            Console.WriteLine("float k: " + k);
            Console.WriteLine("double l: " + l);
            Console.WriteLine("decimal m: " + m);
            Console.WriteLine("char n: " + n);
            Console.WriteLine("string o: " + o);
            Console.WriteLine("bool p: " + p);
            Console.WriteLine();

            string[] subMenuOptions = { "Exit" };
            MenuAction[] actions = { };
            SubMenu(subMenuOptions, actions);
        }

        public static void OperatorsBasic()
        {
            Console.Clear();

            // Arithmetical Operators
            // Just math \_(| _ |)_/
            decimal a = 10M;
            decimal b = 3M;
            decimal c = a + b;
            decimal d = a - b;
            decimal e = a * b;
            decimal f = a / b;
            decimal g = a % b;

            Console.WriteLine($"Here is results of using arithmetical operators, where a = {a} and b = {b}");
            Console.WriteLine($"c = {a} + {b} = {c} \n" +
                              $"d = {a} - {b} = {d} \n" +
                              $"e = {a} * {b} = {e} \n" +
                              $"f = {a} / {b} = {f} \n" +
                              $"g = {a} % {b} = {g} \n");
            Console.ReadKey();

            // Operator procedence
            // Just math \_(| _ |)_/
            double z = 10 + 4 * 30 / 10;
            Console.WriteLine($"Here is result of using Operator procedence, z = 10 + 4 * 30 / 10 = {z} \n");
            Console.ReadKey();

            // Assugnment Operators
            // Sugar math \_(| _ |)_/
            Console.WriteLine($"Here is result of using assignment operators, when a = {a}");
            a += 20M;
            Console.WriteLine($"a+=20 is {a}");
            a -= 20M;
            Console.WriteLine($"a-=20 is {a}");
            a *= 3M;
            Console.WriteLine($"a*=3 is {a}");
            a /= 3M;
            Console.WriteLine($"a/=3 is {a} \n");
            Console.ReadKey();

            // Increment / Descrement Operators
            // n++ Post-Incrementation (First it returns value; then increments)
            // ++n Pre-Incrementation (Fisrt it increments value; then returns)
            // n-- Post-Decrementation (First it returns value; then decrements)
            // --n Pre-Descrementation (First it decrements value; then returns)
            a = 10M;
            Console.WriteLine($"Here is increment operation with a = {a} \n" +
                              $"++a is {++a}, Fisrt it increments value; then returns \n" +
                              $"a++ is {a++}, First it returns value; then increments, so if call now value of a, it will be {a}, bcs inrements after a++ operation \n" +
                              $"--a is {--a}, First it decrements value; then returns \n" +
                              $"a-- is {a--}, First it decrements value; then returns, so after calling a, it will be {a}. \n" +
                              $"Increment / Descrement Operators Magic~~ \n");
            Console.ReadKey();

            // Comparison Operators
            Console.WriteLine($"Here is result of using Comparison Operators, when a = {a}");
            bool b1 = a == 10;
            Console.WriteLine($"a == 10 is {b1}"); // Output: True
            bool b2 = a != 10;
            Console.WriteLine($"a != 10 is {b2}"); // False
            bool b3 = a < 10;
            Console.WriteLine($"a < 10 is {b3}"); // false
            bool b4 = a > 10;
            Console.WriteLine($"a > 10 is {b4}"); /// false
            bool b5 = a <= 10;
            Console.WriteLine($"a <= 10 is {b5}"); // true
            bool b6 = a >= 10;
            Console.WriteLine($"a >= 10 is {b6} \n"); // true
            Console.ReadKey();

            // Logical Operators
            // & Logical And (Both operand should be true). Evaluates both operands, even of left-hand operand return false.
            // && Conditional And (Both operands shoud be true). Does not evaluate right-hand operand, if left-land operand return false.
            // Logical OR (At least any one operand should be true). Evaluates both operands, even of left-hand operand return true.
            // Conditional IR (At leat any one operand should be true). Does not evaliate right-hand operand, if left-hand operand true;
            // ^ Logical Exclusive Or - XOR (Any one operand should be true). Evaliates both operands
            // ! Nagation (true become false; false become true)
            Console.WriteLine($"Here is result of using Logical Operators, when a = {a} and b = {b}");
            bool b7 = a == 10 & b == 10;
            Console.WriteLine($"a == 10 & b == 10 is {b7}"); // false
            bool b8 = a == 10 && b == 10;
            Console.WriteLine($"a == 10 && b == 10 is {b8}"); // false
            bool b9 = a == 10 | b == 10;
            Console.WriteLine($"a == 10 | b == 10 is {b9}"); // true
            bool b10 = a == 10 || b == 10;
            Console.WriteLine($"a == 10 || b == 10 is {b10}"); // true
            bool b11 = !(a == 10);
            Console.WriteLine($"!(a==10) is {b11}"); // false
            bool b12 = a == 10 ^ b == 10;
            Console.WriteLine($"a == 10 ^ b == 10 is {b12} \n"); // true

            Console.ReadKey();

            // Concatenation Operators
            // "string1" + "string2" returns "string1string2" (as string)
            // "string" + number returns "stringnumber" (as string)
            // number + "string" returns "numberstring" (as string)
            Console.WriteLine($"Here is result of using Concatenation operator");
            string name = "Scott";
            int age = 20;
            string message = "Hey, " + name + ", your age is " + age + ".";
            Console.WriteLine(message + "\n");
            Console.ReadKey();

            // Ternary Conditional Operator
            // It evaluates the given Boolean value;
            // Returns first expression (consequent) if true;
            // returns second expression (alternative) if false;
            // ? : (condtion)? consequent : alternative
            Console.WriteLine($"Here is result of using Ternary Operator, string title = (age < 13) ? \"Child\" : (age >= 13 && age <= 19) ? \"Teenager\" : \"Adult\":");
            string title = age < 13 ? "Child" : age >= 13 && age <= 19 ? "Teenager" : "Adult";
            Console.WriteLine(title + "\n");

            string[] subMenuOptions = { "Exit" };
            MenuAction[] actions = { };
            SubMenu(subMenuOptions, actions);
        }
        public static void BreakAndContinue()
        {
            Console.Clear();
            Console.WriteLine("Sup! Here is the difference between 'break;' and 'continue;' in practice");
            Console.WriteLine("For example, we have:\n" +
                              "for (int i = 0; i < 10; i++)\n" +
                              "{\n\tif (i == 5)\n\t{\n\t\tbreak;\n\t}\n\tConsole.Write(i);\n}\n" +
                              "The result will be:");

            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    break;
                }
                Console.Write(i + " ");
            }

            Console.WriteLine("\nAs u can see, after i == 5, using Break; we leaved from for loop. And dot have any number after 4.\n" +
                              "But if we will replace Break; to Continue; will see the result:");

            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    continue;
                }
                Console.Write(i + " ");
            }

            Console.WriteLine("\nAs u can see, after when i == 5 we skipped this step, and do not number 5 in ours colletion");

            Console.WriteLine();

            string[] subMenuOptions = { "Exit" };
            MenuAction[] actions = { };
            SubMenu(subMenuOptions, actions);
        }

        public static void GoToStatement()
        {
            Console.Clear();

            Console.WriteLine("Using goto we should write the name of the label, whick you want to jump\n" + "statement1;\n" + "statement2;\n" + "labelname\n" + "statement3;\n" + "statement4;\n" + "goto labelname\n");

            Console.WriteLine("\nFor example goto with Console.WriteLine();\n\n" + "int i = 0;\nConsole.WriteLine(one);\n" + "Console.WriteLine(two);\n" + "mylabel:\n" + "Console.WriteLine(three);\n" + "Console.WriteLine(four)\n" + "i++\nif(i == 1) {goto mylabel;}\n" + "Console.WriteLine(five)\n" + "\nWell, then we will have the result:");
            int i = 0;
            Console.WriteLine("one");
            Console.WriteLine("two");
            mylabel:
            Console.WriteLine("three");
            Console.WriteLine("four");
            i++;
            if(i == 1)
            {
                goto mylabel;
            }
            Console.WriteLine("five\n");



            string[] subMenuOptions = { "Exit" };
            MenuAction[] actions = { };
            SubMenu(subMenuOptions, actions);
        }
    }
}
