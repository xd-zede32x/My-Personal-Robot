using System;

namespace MyPersonalRobot
{
    public class Calculator
    {
        private double _firstUserInputNumber;
        private double _secondUserInputNumber;

        public void Start()
        {
            UserGreeting();
            UserInputNumbers();
        }

        private void UserGreeting()
        {
            Console.Title = "Калькулятор";
            Console.Clear();

            Console.WriteLine("Приветствую вас в программе под номером 1 калькулятор. (--_--)");
            Console.WriteLine("Здесь вы можете делать простые математические вычисления.");
        }

        private void UserInputNumbers()
        {
            Console.Write($"\n(==_==) Введите пожалуйста Первое число: ");
            _firstUserInputNumber = Convert.ToDouble(Console.ReadLine());

            Console.Write("\n(==_==) Введите пожалуйста Второе число: ");
            _secondUserInputNumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"\nТеперь я предложу вам выбрать операцию над числами: {_firstUserInputNumber} И {_secondUserInputNumber}");

            PrintOperationNumbers();
        }

        private void PrintOperationNumbers()
        {
            Console.WriteLine("Список возможных операций (--_--)");

            Console.WriteLine("\n\n\t+ | - | * | /");


        }
    }
}