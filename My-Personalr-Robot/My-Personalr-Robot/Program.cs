using System;

namespace MyPersonalRobot
{
    public class Program
    {
        private static string _userName;

        private static void Main(string[] _)
        {
            UserGreeting();
            PrintUserOperation();
            InputUserOperation();

            Console.ReadKey();
        }

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
            _userName = Console.ReadLine();
            Console.WriteLine($"\nХорошо я буду вас называть {_userName} если вы не против (-- --)");
        }

        private static void InputUserOperation()
        {
            Console.Write($"\n{_userName} выберете операцию которую хотите использовать: ");

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
                    Console.WriteLine("Данной операции не существует (--╳--)");
                    break;
            }
        }

        private static void PrintUserOperation()
        {
            Console.WriteLine($"\nВсе возможные операции:\n\n1 - (Калькулятор (-- --)\n2 - (Обмен Валют (-- --)\n3 - (Рассказать шутку (-- --)\n4 - (Покрасить консоль в другой цвет (-- --)");
        }

        private static void ChangeConsoleColor(ConsoleColor color) => Console.ForegroundColor = color;
    }
}