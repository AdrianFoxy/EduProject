using EducationalApp;
using Spectre.Console;

public static class Program
{
    public static void Main(string[] args)
    {

        Console.Title = "EduApp";
        MainMenu.Menu();

        Console.ReadKey(true);
    }
}