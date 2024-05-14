using System;

namespace MyPersonalRobot
{
    public class Program
    {
        public static string UserName { get; set; }
        public static int UserInputOperations { get; set; }

        private static void Main(string[] _) => Start();

        private static void Start()
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
            UserName = Console.ReadLine();
            Console.WriteLine($"\nХорошо я буду вас называть {UserName} если вы не против (--_--)");
        }

        private static void PrintUserOperation()
        {
            Console.WriteLine($"\nВсе возможные операции:\n\n1 - (Калькулятор (--_--)\n2 - (Обмен Валют (-- --)\n3 - (Рассказать шутку (-- --)\n4 - (Покрасить консоль в другой цвет (-- --)");
        }

        private static void InputUserOperation()
        {
            Console.Write($"\n{UserName} выберете операцию которую хотите использовать: ");

            UserInputOperations = Convert.ToInt32(Console.ReadLine());
        }

        private static void Operations()
        {
            switch (UserInputOperations)
            {
                case 1:
                    Calculator calculator = new Calculator();
                    calculator.Start();
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