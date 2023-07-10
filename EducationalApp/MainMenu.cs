using Spectre.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationalApp
{
    public class MainMenu
    {
        public static void MenuOption(string prefix, string message)
        {
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(prefix);
            Console.ResetColor();
            Console.WriteLine($"] {message}");
        }

        public delegate void MenuAction();

        public static void SubMenu(string[] subMenuValue, MenuAction[] actions)
        {
            while (true)
            {
                int exitIndex = subMenuValue.Length;

                var selectedOption = AnsiConsole.Prompt(
                    new SelectionPrompt<string>()
                        .Title("Select your [blue]menu option[/]?")
                        .PageSize(10)
                        .MoreChoicesText("[grey](Move up and down to reveal more options)[/]")
                        .AddChoices(subMenuValue)
                );
                int indexOfOption = Array.IndexOf(subMenuValue, selectedOption);

                if (indexOfOption >= 0 && indexOfOption < actions.Length)
                {              
                    MenuAction selectedAction = actions[indexOfOption];
                    selectedAction();
                }
                else if (indexOfOption == exitIndex-1) Menu();            
                else { Console.WriteLine("Wrong menu option!"); Thread.Sleep(1000); }
            }
        }

        public static void Menu()
        {
            while (true)
            {
                Console.Clear();

                AnsiConsole.Write(
                    new FigletText("EduApp \\o/")
                        .LeftJustified()
                        .Color(Color.Aqua));

                var menu_options = new[] {
                    "Hello World", "Primitive Types", "Basic Operators",
                    "Exit the program"
                };

                int exitIndex = menu_options.Length;
                Console.WriteLine();

                var selectedOption = AnsiConsole.Prompt(
                    new SelectionPrompt<string>()
                        .Title("Select your [blue]menu option[/]?")
                        .PageSize(10)
                        .MoreChoicesText("[grey](Move up and down to reveal more options)[/]")
                        .AddChoices(menu_options)
                );

                int indexOfOption = Array.IndexOf(menu_options, selectedOption);

                // Echo the selected option back to the terminal
                AnsiConsole.WriteLine($"Well, yo choosed. '{selectedOption}' is tasty! And id is {indexOfOption}");

                if (indexOfOption == 0) LanguageBasics.HelloWorldAndConsoleCommands();
                else if (indexOfOption == 1) LanguageBasics.PrimitiveTypes();
                else if (indexOfOption == 2) LanguageBasics.OperatorsBasic();
                else if (indexOfOption == exitIndex-1) { Console.WriteLine("Bye~"); Thread.Sleep(1000); Environment.Exit(0); }
                else { Console.WriteLine("Wrong menu option!"); Thread.Sleep(1000); }
            }
        }

    }

}
