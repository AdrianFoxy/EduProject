using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationalApp.ExceptionClasses
{
    public class ExceptionsExamples
    {
        public void Example1()
        {
            Console.WriteLine("void Foo(int i, string? str) \r\n{ \r\n    if (i == -1 || i == 1)\r\n    {\r\n        throw new ArgumentException(\"i equals -1 or 1\", nameof(i));\r\n    }\r\n    if (i <= -10 || i >= 10)\r\n    {\r\n        throw new ArgumentOutOfRangeException(nameof(i));\r\n    }\r\n    if (str is null) \r\n    {\r\n        throw new ArgumentNullException(nameof(str));\r\n    }\r\n}\r\nvoid Bar(int i, string? str)\r\n{\r\n    try\r\n    {\r\n        Foo(i, str);\r\n    }\r\n    catch (ArgumentNullException)\r\n    {\r\n        Console.Write(\"2\");\r\n    }\r\n    catch (Exception)\r\n    {\r\n        Console.Write(\"3\");\r\n    }\r\n    finally\r\n    {\r\n        Console.Write(\"4\");\r\n    }\r\n}");

            Console.Write("\nBar(0, string.Empty); Output:");
            Bar(0, string.Empty);
            Console.Write("\nBar(1, string.Empty); Output:");
            Bar(1, string.Empty);
            Console.Write("\nBar(-10, string.Empty); Output:");
            Bar(-10, string.Empty);
            Console.Write("\nBar(-1, string.Empty); Output:");
            Bar(-1, string.Empty);
            Console.Write("\nBar(0, string.Empty); Output:");
            Bar(0, string.Empty);
            Console.WriteLine("\n");
        }

        private void Foo(int i, string? str)
        {
            if (i == -1 || i == 1)
            {
                throw new ArgumentException("i equals -1 or 1", nameof(i));
            }
            if (i <= -10 || i >= 10)
            {
                throw new ArgumentOutOfRangeException(nameof(i));
            }
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }
        }
        private void Bar(int i, string? str)
        {
            try
            {
                Foo(i, str);
            }
            catch (ArgumentNullException)
            {
                Console.Write("2");
            }
            catch (Exception)
            {
                Console.Write("3");
            }
            finally
            {
                Console.Write("4");
            }
        }

    }
}
