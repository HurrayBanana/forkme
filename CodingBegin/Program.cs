using System;

namespace CodingBegin
{
    class Program
    {

        static int userChoice;

        static void Main(string[] args)
        {
            HandleInput();
            ProcessInput();
            OutputResults();
        }

        private static void ProcessInput()
        {
            userChoice += 15;
        }

        private static void HandleInput()
        {

            Console.WriteLine("please enter a number\n" +
                    "i will cry if you enter ought else");

            string entry = Console.ReadLine();

            try
            {
                userChoice = Convert.ToInt32(entry);
            }
            catch (Exception)
            {
                Console.WriteLine("oh your so mean");
                userChoice = 0;
            }

        }

        private static void OutputResults()
        {
            Console.WriteLine("Hey \"geezer\" here's my number");
            Console.WriteLine(userChoice);
        }
    }
}
