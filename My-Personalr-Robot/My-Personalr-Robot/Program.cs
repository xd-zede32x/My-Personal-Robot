using System;

namespace MyPersonalRobot
{
    public class Program
    {
        private static string _userName;
        private static int _userInputOperations;

        private static void Main(string[] _)
        {
            UserGreeting();
            PrintUserOperation();
            InputUserOperation();
            Operations();

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

        private static void ChangeConsoleColor(ConsoleColor color) => Console.ForegroundColor = color;

        private static void EnteringUserName()
        {
            _userName = Console.ReadLine();
            Console.WriteLine($"\nХорошо я буду вас называть {_userName} если вы не против (-- --)");
        }

        private static void PrintUserOperation()
        {
            Console.WriteLine($"\nВсе возможные операции:\n\n1 - (Калькулятор (-- --)\n2 - (Обмен Валют (-- --)\n3 - (Рассказать шутку (-- --)\n4 - (Покрасить консоль в другой цвет (-- --)");
        }

        private static void InputUserOperation()
        {
            Console.Write($"\n{_userName} выберете операцию которую хотите использовать: ");

            _userInputOperations = Convert.ToInt32(Console.ReadLine());
        }

        private static void Operations()
        {
            switch (_userInputOperations)
            {
                case 1:
                    Console.WriteLine();

                    Calculator calculator = new Calculator();
                    break;

                case 2:

                    break;

                case 3:

                    break;

                case 4:

                    break;

                default:
                    Console.WriteLine("\nДанной операции не существует (--╳--) Выйдите из программы!!!");
                    break;
            }
        }
    }
}