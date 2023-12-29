using Spectre.Console;

namespace EducationalApp.StringsInfo
{
    public class StringsInfoMain
    {
        public void ShowGeneralInfo()
        {
            Console.WriteLine("In C#, a string is a sequence of characters.\nFor example, \"hello\" is a string containing a sequence of characters 'h', 'e', 'l', 'l', and 'o'.\n");
            Console.WriteLine("Note:\nA string variable in C# is not of primitive types\nlike int, char, etc. Instead, it is an object of the String class.\n");
        }

        public void ShowStringOperator()
        {
            Console.WriteLine("\n1. Get the Length of a string\n");
            Console.WriteLine("To find the length of a string, we use the Length property. For example:\n");
            Console.WriteLine("// create string\nstring str = \"C# Programming\";\nConsole.WriteLine(\"string: \" + str);\n// get length of str\nint length = str.Length;\nConsole.WriteLine(\"Length: \"+ length);\n");
           
            Console.WriteLine("Output");

            string str = "C# Programming";
            Console.WriteLine("string: " + str);
            // get length of str
            int length = str.Length;
            Console.WriteLine("Length: " + length);


            Console.WriteLine("\n2. Join two strings in C#\n");
            Console.WriteLine("We can join two strings in C# using the Concat() method. For example:\n");
            Console.WriteLine("// create string\nstring str1 = \"C# \";\nConsole.WriteLine(\"string str1: \" + str1);\n// create string\nstring str2 = \"Programming\";\nConsole.WriteLine(\"string str2: \" + str2);\n// join two strings\nstring joinedString = string.Concat(str1, str2);\nConsole.WriteLine(\"Joined string: \" + joinedString);\n");

            Console.WriteLine("Output");

            string str1 = "C# ";
            Console.WriteLine("string str1: " + str1);
            // create string
            string str2 = "Programming";
            Console.WriteLine("string str2: " + str2);
            // join two strings
            string joinedString = string.Concat(str1, str2);
            Console.WriteLine("Joined string: " + joinedString);

            Console.WriteLine("\n3. C# compare two strings\n");
            Console.WriteLine("In C#, we can make comparisons between two strings using the Equals() method.\nThe Equals() method checks if two strings are equal or not. For example:\n");
            Console.WriteLine("// create string\nstring str1 = \"C# Programming\";\nstring str2 = \"C# Programming\";\nstring str3 = \"Programiz\";\n// compare str1 and str2\nBoolean result1 = str1.Equals(str2);\nConsole.WriteLine(\"string str1 and str2 are equal: \" + result1);\n//compare str1 and str3\nBoolean result2 = str1.Equals(str3);\nConsole.WriteLine(\"string str1 and str3 are equal: \" + result2);\n");

            Console.WriteLine("Output");

            // create string
            string str4 = "C# Programming";
            string str5 = "C# Programming";
            string str6 = "Programiz";

            // compare str1 and str2
            Boolean result1 = str4.Equals(str5);
            Console.WriteLine("string str1 and str2 are equal: " + result1);

            //compare str1 and str3
            Boolean result2 = str4.Equals(str6);
            Console.WriteLine("string str1 and str3 are equal: " + result2);
        }

        public void ShowStringImmutability()
        {
            Console.WriteLine("In C#, strings are immutable. This means, once we create a string, we cannot change that string.\n\nTo understand it, consider an example:\n");
            Console.WriteLine("// create string\nstring str = \"Hello \";\n");
            Console.WriteLine("Here, we have created a string variable named str. The variable holds the string \"Hello \".\nNow suppose we want to change the string str.\\n");
            Console.WriteLine("// add another string \"World\"\n// to the previous string example\r\nstr = string.Concat(str, \"World\");\n");
            Console.WriteLine("Here, we are using the Concat() method to add the string \"World\" to the previous string str.\nBut how are we able to modify the string when they are immutable?\nLet's see what has happened here:\n");
            Console.WriteLine("1. C# takes the value of the string \"Hello \".\n2. Creates a new string by adding \"World\" to the string \"Hello \".\n3. Creates a new string object, gives it a value \"Hello World\", and stores it in str.\n4. The original string, \"Hello \", that was assigned to str is released for garbage collection because no other variable holds a reference to it.\n");

            // create string
            string str = "Hello ";
            // add another string "World"
            // to the previous string example
            str = string.Concat(str, "World");
            Console.WriteLine("Output: " + str);
        }

        public void ShowEscapeSequences()
        {
            Console.WriteLine("The escape character is used to escape some of the characters present inside a string.\nIn other words, we use escape sequences to insert special characters inside the string.\n");
            Console.WriteLine("Suppose we need to include double quotes inside a string.\n");
            Console.WriteLine("// use the escape character\nstring str = \"This is the \\\"String\\\" class.\";\n");

            var table = new Table();
            table.AddColumn("Escape Sequence");
            table.AddColumn("Character Name");

            table.AddRow(new Markup("[yellow]\\'[/]"), new Markup("[yellow]single quote[/]"));
            table.AddRow(new Markup("[yellow]\"[/]"), new Markup("[yellow]double quote[/]"));
            table.AddRow(new Markup("[yellow]\\\\[/]"), new Markup("[yellow]backslash[/]"));
            table.AddRow(new Markup("[yellow]\\0[/]"), new Markup("[yellow]null[/]"));
            table.AddRow(new Markup("[yellow]\\n[/]"), new Markup("[yellow]new line[/]"));
            table.AddRow(new Markup("[yellow]\\t[/]"), new Markup("[yellow]horizontal tab[/]"));


            AnsiConsole.Render(table);
        }

        public void ShowStringMethods()
        {
            var table = new Table();

            table.AddColumn("Methods");
            table.AddColumn("Description");

            table.AddRow("Format()", "returns a formatted string");
            table.AddRow("Split()", "splits the string into substring");
            table.AddRow("Substring()", "returns substring of a string");
            table.AddRow("Compare()", "compares string objects");
            table.AddRow("Replace()", "replaces the specified old character with the specified new character");
            table.AddRow("Contains()", "checks whether the string contains a substring");
            table.AddRow("Join()", "joins the given strings using the specified separator");
            table.AddRow("Trim()", "removes any leading and trailing whitespaces");
            table.AddRow("EndsWith()", "checks if the string ends with the given string");
            table.AddRow("IndexOf()", "returns the position of the specified character in the string");
            table.AddRow("Remove()", "returns characters from a string");
            table.AddRow("ToUpper()", "converts the string to uppercase");
            table.AddRow("ToLower()", "converts the string to lowercase");
            table.AddRow("PadLeft()", "returns string padded with spaces or with a specified Unicode character on the left");
            table.AddRow("PadRight()", "returns string padded with spaces or with a specified Unicode character on the right");
            table.AddRow("StartsWith()", "checks if the string begins with the given string");
            table.AddRow("ToCharArray()", "converts the string to a char array");
            table.AddRow("LastIndexOf()", "returns index of the last occurrence of a specified string");

            AnsiConsole.Render(table);
        }
    }
}
