using Spectre.Console;

namespace EducationalApp.LogicalOperators
{
    public class LogicalOperatorsInfo
    {
        public void ShowInfo(string menuObjeName)
        {
            if (menuObjeName == "AND &")
            {
                Console.WriteLine("The & operator computes the logical AND of its operands.\nThe result of x & y is true if both x and y evaluate to true. Otherwise, the result is false.");
                Console.WriteLine("\nint x = 5;\nConsole.WriteLine(x > 3 && x < 10); // returns True because 5 is greater than 3 AND 5 is less than 10");
            }
            else if (menuObjeName == "OR |")
            {
                Console.WriteLine("Returns True if one of the statements is true");
                Console.WriteLine("\nint x = 5;\nConsole.WriteLine(x > 3 || x < 4); // returns True because one of the conditions are True (5 is greater than 3, but 5 is not less than 4)");

            }
            else if (menuObjeName == "XOR ^")
            {
                Console.WriteLine("Logical exclusive OR returns true only if one of the values being compared is true, but not both.\nIf both are false or both are true, the result will be false.");
                Console.WriteLine("\nbool a = true; \nbool b = false; \nbool result = a ^ b; \nConsole.WriteLine(result); // Will be True, bcs a = true and b = false");
            }
            else if (menuObjeName == "NOT !")
            {
                Console.WriteLine("Reverse the result, returns False if the result is true");
                Console.WriteLine("\nint x = 5;\nConsole.WriteLine(!(x > 3 && x < 10)); // returns False because ! (not) is used to reverse the result");
            }
            else
            {
                Console.WriteLine("Info about this logical operator doesn't exist");
            }
        }
  

        public void ShowExamples(string menuObjeName)
        {
            if (menuObjeName == "AND &")
            {
                var table = new Table();
                table.AddColumn("a");
                table.AddColumn("b");
                table.AddColumn("result");

                table.AddRow(new Markup("[yellow]False[/]"), new Markup("[yellow]False[/]"), new Markup("[red]False[/]"));
                table.AddRow(new Markup("[yellow]False[/]"), new Markup("[yellow]True[/]"), new Markup("[green]False[/]"));
                table.AddRow(new Markup("[yellow]True[/]"), new Markup("[yellow]False[/]"), new Markup("[red]False[/]"));
                table.AddRow(new Markup("[yellow]True[/]"), new Markup("[yellow]True[/]"), new Markup("[red]True[/]"));

                AnsiConsole.Render(table);
            }
            else if (menuObjeName == "OR |")
            {
                var table = new Table();
                table.AddColumn("a");
                table.AddColumn("b");
                table.AddColumn("result");

                table.AddRow(new Markup("[yellow]False[/]"), new Markup("[yellow]False[/]"), new Markup("[red]False[/]"));
                table.AddRow(new Markup("[yellow]False[/]"), new Markup("[yellow]True[/]"), new Markup("[green]True[/]"));
                table.AddRow(new Markup("[yellow]True[/]"), new Markup("[yellow]False[/]"), new Markup("[red]True[/]"));
                table.AddRow(new Markup("[yellow]True[/]"), new Markup("[yellow]True[/]"), new Markup("[red]True[/]"));

                AnsiConsole.Render(table);
            }
            else if(menuObjeName == "XOR ^")
            {
                var table = new Table();
                table.AddColumn("a");
                table.AddColumn("b");
                table.AddColumn("result");

                table.AddRow(new Markup("[yellow]True[/]"), new Markup("[yellow]True[/]"), new Markup("[red]False[/]"));
                table.AddRow(new Markup("[yellow]True[/]"), new Markup("[yellow]False[/]"), new Markup("[green]True[/]"));
                table.AddRow(new Markup("[yellow]False[/]"), new Markup("[yellow]True[/]"), new Markup("[red]False[/]"));
                table.AddRow(new Markup("[yellow]False[/]"), new Markup("[yellow]False[/]"), new Markup("[red]False[/]"));

                AnsiConsole.Render(table);
            }
            else if (menuObjeName == "NOT !")
            {
                var table = new Table();
                table.AddColumn("!a");
                table.AddColumn("result");

                table.AddRow(new Markup("[yellow]True[/]"), new Markup("[yellow]False[/]"));
                table.AddRow(new Markup("[yellow]False[/]"), new Markup("[yellow]True[/]"));

                AnsiConsole.Render(table);
            }
            else
            {
                Console.WriteLine("Info about examples of this logical operator doesn't exist");
            }
        }
    }
}
