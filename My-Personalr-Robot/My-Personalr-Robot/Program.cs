using System;

namespace My_Personal_Robot
{
    public class Program
    {
        private static void Main(string[] _) => UserGreeting();

        private static void UserGreeting()
        {
            Console.Title = "Альбедо";
            ChangeConsoleColor(ConsoleColor.Yellow);

            Console.WriteLine("Приветствую вас мой господин это говорит ваша Альбедо.");
            Console.Write("\nКак я могу к вам обращаться мой повелитель (--╳--): ");

            EnteringUserName();
        }

        private static void EnteringUserName()
        {
            string userName = Console.ReadLine();
            Console.WriteLine($"\nХорошо я буду вас называть {userName} если вы не против (-- --)");
        }

        private static void ChangeConsoleColor(ConsoleColor color) => Console.ForegroundColor = color;

        private static void InputUserOperation()
        {

        }
    }
}