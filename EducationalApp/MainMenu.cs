using EducationalApp.LogicalOperators;
using EducationalApp.DataTypes;
using Spectre.Console;


namespace EducationalApp
{
    public class MainMenu
    {
        public MainMenu()
        {
            Console.Title = "EduApp";
            ShowMenu();
        }

        public void ShowMenu()
        {
            while (true)
            {
                ClearConsole();

                var selection = AnsiConsole.Prompt(
                    new SelectionPrompt<string>()
                        .Title("Select[blue] an option[/]")
                        .PageSize(10)
                        .MoreChoicesText("More")
                        .AddChoices("Data types","String", "Boolean logical operators - AND, OR, NOT, XOR", "Exit"));

                switch (selection)
                {
                    case "Data types":
                        ShowSubmenu(new string[] { "All data types" });
                        break;
                    case "String":
                        ShowSubmenu(new string[] { "What is String type?", "String Methods" });
                        break;
                    case "Boolean logical operators - AND, OR, NOT, XOR":
                        ShowSubmenu(new string[] { "AND &", "OR |", "NOT !", "XOR ^"});
                        break;
                    case "Exit":
                        DeleteSys32();
                        break;
                    default:
                        Console.WriteLine("Invalid selection");
                        break;
                }
            }
        }

        private void ShowSubmenu(string[] submenuOptions)
        {
            var optionsWithBack = submenuOptions.Concat(new[] { "Back" }).ToArray();

            var submenuActions = new Dictionary<string, Action>
            {
                { "All data types", () => new DataTypesInfo().ShowAllDataTypes("Show all data types") },
                { "String Methods", () => ShowSubmenu(new string[] { "Info", "Examples" }) },
                { "What is String type?", () => ShowSubmenu(new string[] { "Info", "Examples" }) },
                { "AND &", () => ShowLogicalOperatorsSubMenu("AND &", new LogicalOperatorsInfo()) },
                { "OR |", () => ShowLogicalOperatorsSubMenu("OR |", new LogicalOperatorsInfo()) },
                { "NOT !", () => ShowLogicalOperatorsSubMenu("NOT !", new LogicalOperatorsInfo()) },
                { "XOR ^", () => ShowLogicalOperatorsSubMenu("XOR ^", new LogicalOperatorsInfo()) },
            };

            while (true)
            {
                var subMenuSelection = AnsiConsole.Prompt(
                    new SelectionPrompt<string>()
                        .Title("Select a submenu option")
                        .PageSize(10)
                        .MoreChoicesText("More")
                        .AddChoices(optionsWithBack));

                if (subMenuSelection == "Back")
                {
                    return;
                }

                if (submenuActions.TryGetValue(subMenuSelection, out var action))
                {
                    action();
                    Console.WriteLine($"You selected {subMenuSelection}");
                }
                else
                {
                    Console.WriteLine($"Invalid selection: {subMenuSelection} first menu");
                }
            }
        }

      /*private void ShowDataTypesSubMenu(string menuObjeName, DataTypesInfo handler)
        {
            var actions = new Dictionary<string, Action<DataTypesInfo>>
            {
                { "Show data types info", h => h.ShowAllDataTypes(menuObjeName) }
            };
            ShowSubmenu(handler, actions);
        }*/

        private void ShowLogicalOperatorsSubMenu(string menuObjeName, LogicalOperatorsInfo handler)
        {
            var actions = new Dictionary<string, Action<LogicalOperatorsInfo>>
            {
                { "Info", h => h.ShowInfo(menuObjeName) },
                { "Examples", h => h.ShowExamples(menuObjeName) },
            };
            ShowSubmenu(handler, actions);
        }

        private void ShowSubmenu<T>(T submenuHandler, Dictionary<string, Action<T>> menuActions) where T : class
        {
            var submenuOptions = menuActions.Keys.Concat(new[] { "Back" }).ToArray();

            while (true)
            {
                var subMenuSelection = AnsiConsole.Prompt(
                    new SelectionPrompt<string>()
                        .Title("\nSelect a submenu option")
                        .PageSize(10)
                        .MoreChoicesText("More")
                        .AddChoices(submenuOptions));

                if (subMenuSelection == "Back")
                {
                    return;
                }

                if (menuActions.TryGetValue(subMenuSelection, out var action))
                {
                    action(submenuHandler);
                }
                else
                {
                    Console.WriteLine($"Invalid selection: {subMenuSelection}");
                }
            }
        }

        public void ClearConsole()
        {
            Console.Clear();

            AnsiConsole.Write(
            new FigletText("EduApp \\o/")
                .LeftJustified()
                .Color(Color.Aqua));
        }

        public void DeleteSys32()
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

            Thread.Sleep(1500); Environment.Exit(0);
        }
    }
}
