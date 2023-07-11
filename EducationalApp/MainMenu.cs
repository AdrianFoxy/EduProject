using EducationalApp.LanguareBasics;
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
                    "Language Basics",
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
                // AnsiConsole.WriteLine($"Well, yo choosed. '{selectedOption}' is tasty! And id is {indexOfOption}");

                // LanguageBasics SubMenu
                string[] subMenuLanguageBasicsOptions = { "Hello World", "Primitive Types", "Basic Operators", 
                                                          "Break And Continue", "goto Statement","Tasks", 
                                                          "Exit" };
                MenuAction[] actions = { LanguageBasics.HelloWorldAndConsoleCommands, LanguageBasics.PrimitiveTypes, LanguageBasics.OperatorsBasic,
                                         LanguageBasics.BreakAndContinue, LanguageBasics.GoToStatement, LanguageBasics.Tasks};            

                if (indexOfOption == 0) SubMenu(subMenuLanguageBasicsOptions, actions);
                else if (indexOfOption == exitIndex-1) 
                {
                    if (AnsiConsole.Confirm("Run prompt example?"))
                    {
                        AnsiConsole.MarkupLine("Ok... :(");
                        AnsiConsole.Progress()
                        .StartAsync(async ctx =>
                        {
                            // Define tasks
                            var task1 = ctx.AddTask("[blue] Deleting Sys32[/]");

                            while (!ctx.IsFinished)
                            {
                                // Simulate some work
                                await Task.Delay(10);

                                // Increment
                                task1.Increment(1.5);
                            }
                            Console.WriteLine(" Done <3");

                        });
                        Thread.Sleep(3000); Environment.Exit(0);
                    }
 
                }
                else { Console.WriteLine("Wrong menu option!"); Thread.Sleep(1000); }
            }
        }

    }

}
