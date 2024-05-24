using System;

namespace MyPersonalRobot
{
    public class Program
    {
        private static void Main(string[] _) => Initialize();

        private static void Initialize()
        {
            BeginningProgram beginningProgram = new BeginningProgram();
            beginningProgram.Start();
        }
    }
}