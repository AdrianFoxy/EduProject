using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationalApp
{
    public class MainMenu
    {
        public static void WriteLogo()
        {

            Console.ForegroundColor = ConsoleColor.Blue;

            string logo = "\r\n___________    .___       _____                 " +
                          "\r\n\\_   _____/  __| _/_ __  /  _  \\ ______ ______  " +
                          "\r\n |    __)_  / __ |  |  \\/  /_\\  \\\\____ \\\\____ \\ " +
                          "\r\n |        \\/ /_/ |  |  /    |    \\  |_> >  |_> >" +
                          "\r\n/_______  /\\____ |____/\\____|__  /   __/|   __/ " +
                          "\r\n        \\/      \\/             \\/|__|   |__|    \r\n";

            Console.WriteLine($"{logo} \n");

            Console.ResetColor();
        }

        public static void MenuOption(string prefix, string message)
        {
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(prefix);
            Console.ResetColor();
            Console.WriteLine($"] {message}");
        }

        public static void SubMenu()
        {
            while(true)
            {
                MenuOption("1", "Return to menu");

                string option = Console.ReadLine()!;

                if (option == "1") break;
                else
                {
                    Console.WriteLine("Wrong menu option!");
                    Thread.Sleep(1000);
                }
            }
        }

        public static void Menu()
        {
            while (true)
            {
                Console.Clear();
                WriteLogo();
                MenuOption("1", "Hello World");
                MenuOption("2", "Primitive Types");
                MenuOption("3", "Basic Operators");
                MenuOption("exit", "Exit the program");
                MenuOption("exit", "Exit the program");


                string option = Console.ReadLine()!;

                if (option == "1") LanguageBasics.HelloWorldAndConsoleCommands();
                else if (option == "2") LanguageBasics.PrimitiveTypes();
                else if (option == "3") LanguageBasics.OperatorsBasic();
                else if (option == "exit") { Console.WriteLine("Bye~"); Thread.Sleep(1000); Environment.Exit(0); }
                else { Console.WriteLine("Wrong menu option!"); Thread.Sleep(1000); }
            }
        }

    }

}
