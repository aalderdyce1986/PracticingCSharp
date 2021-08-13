using System;

namespace WhileIteration
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            While / Do loops are great for unknown amount of
            Iterations needed. Remember these two things:

            1) WHILE loops are used, and may not meet conditions during
            the entire running of the program.

            2) DO loops are used, and WILL ITERATE AT LEAST ONE TIME during
            the running of the program.

            That is the biggest difference between those different types of iterations.
            */
            bool displayMenu = true;
            while (displayMenu)
            {
                displayMenu = MainMenu();
            }          
            
        }
        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose an option: ");
            Console.WriteLine("1) Print Numbers!");
            Console.WriteLine("2) Guessing Game!");
            Console.WriteLine("3) Exit");

            string result = Console.ReadLine();
            if (result == "1")
            {
                PrintNumbers();
                return true;
            }
            else if (result == "2")
            {
                GuessingGame();
                return true;
            }
            else if (result == "3")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private static void PrintNumbers()
        {
            Console.Clear();
            Console.WriteLine("Print Numbers!");
            Console.Write("Type a number: ");
            int result = int.Parse(Console.ReadLine());
            int counter = 1;

            while (counter < result + 1)
            {
                Console.Write(counter);
                Console.Write("-");
                counter++;
            }
            Console.ReadLine();
        }
        private static void GuessingGame()
        {
            Console.Clear();
            Console.WriteLine("Guessing Game!");

            Random myRandom = new Random();
            int randomNumber = myRandom.Next(1, 11);

            int guesses = 0;
            bool incorrect = true;

            do
            {
                Console.WriteLine("Guess a number between 1 and 10: ");
                string result = Console.ReadLine();
                guesses++;
                if (result == randomNumber.ToString())
                    incorrect = false;
                else
                    Console.WriteLine("Wrong. Please guess again!");

                
            } while (incorrect);
            Console.WriteLine("Congratulations. You took {0} guesses to " +
                "get the number. Great job!", guesses);


            Console.ReadLine();
        }
    }
}
