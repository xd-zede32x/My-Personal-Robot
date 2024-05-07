using System;

namespace MyPersonalRobot
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

            InputUserOperation(userName);
        }

        private static void InputUserOperation(string userName)
        {
            Console.Write($"\n{userName} выберете операцию которую хотите использовать: ");
            
            int userInputOperations = Convert.ToInt32(Console.ReadLine());
        }

        private static void Operations(int numberOperation)
        {
            switch (numberOperation)
            {
                case 1:
                    break;

                case 2:
                    break;

                case 3:
                    break;

                case 4:
                    break;

                default:
                    Console.WriteLine("Данной операции не существует");
                    break;
            }
        }

        private static void ChangeConsoleColor(ConsoleColor color) => Console.ForegroundColor = color;
    }
}