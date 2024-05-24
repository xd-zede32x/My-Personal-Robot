using System;

namespace MyPersonalRobot
{
    public class BeginningProgram
    {
        private static string _userName;

        public void Start()
        {
            UserGreeting();
            PrintUserOperation();
            InputUserOperation();

            Console.ReadKey();
        }

        private void UserGreeting()
        {
            Console.Title = "Альбедо";

            ChangeConsoleColor(ConsoleColor.Yellow);

            Console.WriteLine("Приветствую вас мой господин это говорит ваша Альбедо.");
            Console.Write("\nКак я могу к вам обращаться мой повелитель (--╳--): ");

            EnteringUserName();
        }

        private void ChangeConsoleColor(ConsoleColor color) => Console.ForegroundColor = color;

        private void EnteringUserName()
        {
            _userName = Console.ReadLine();
            Console.WriteLine($"\nХорошо я буду вас называть {_userName} если вы не против (--_--)");
        }

        private void PrintUserOperation()
        {
            Console.WriteLine($"\nВсе возможные операции:\n\n1 - (Калькулятор (--_--)\n2 - (Обмен Валют (-- --)\n3 - (Рассказать шутку (-- --)\n4 - (Покрасить консоль в другой цвет (-- --)");
        }

        private void InputUserOperation()
        {
            int userInputOperations;

            Console.Write($"\n{_userName} выберете операцию которую хотите использовать: ");

            while (!int.TryParse(Console.ReadLine(), out userInputOperations) || !Enum.IsDefined(typeof(Operation), userInputOperations))
            {
                Console.WriteLine("Некорректный ввод.Пожалуйста, выберите одну из операций (--_--)");
                Console.Write("\nВаш выбор: ");
            }

            Operations((Operation)userInputOperations);
        }

        private void Operations(Operation userInputOperations)
        {
            switch (userInputOperations)
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