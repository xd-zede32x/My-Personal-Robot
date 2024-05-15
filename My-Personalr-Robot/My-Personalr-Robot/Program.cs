using System;

namespace MyPersonalRobot
{
    public class Program
    {
        private static string _userName;

        private static void Main(string[] _) => Start();

        private static void Start()
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

        private static void ChangeConsoleColor(ConsoleColor color) => Console.ForegroundColor = color;

        private static void EnteringUserName()
        {
            _userName = Console.ReadLine();
            Console.WriteLine($"\nХорошо я буду вас называть {_userName} если вы не против (--_--)");
        }

        private static void PrintUserOperation()
        {
            Console.WriteLine($"\nВсе возможные операции:\n\n1 - (Калькулятор (--_--)\n2 - (Обмен Валют (-- --)\n3 - (Рассказать шутку (-- --)\n4 - (Покрасить консоль в другой цвет (-- --)");
        }

        private static void InputUserOperation()
        {
            int userInputOperations;

            Console.Write($"\n{_userName} выберете операцию которую хотите использовать: ");

            while (!int.TryParse(Console.ReadLine(), out userInputOperations) || !Enum.IsDefined(typeof(Operation), userInputOperations))
            {
                Console.WriteLine("\nНекорректный ввод.Пожалуйста, выберите одну из операций (--_--)");
                Console.Write("\nВаш выбор: ");
            }

            switch ((Operation)userInputOperations)
            {
                case Operation.Calculator:
                    Calculator calculator = new Calculator();
                    calculator.Start();
                    break;

                case Operation.CurrencyExchange:
                    break;

                case Operation.TellJoke:
                    break;

                case Operation.ChangeConsoleColor:
                    break;

                default:
                    Console.WriteLine("\nДанной операции не существует (--╳--) Выйдите из программы!!!");
                    break;
            }
        }
    }
}