using System;

namespace TP1
{
    public class Exercice2
    {
        public static void Lunch()
        {
            Prime(Program.AskUserForParameterSecure());
            DisplayFibonnaci(Program.AskUserForParameterSecure());
            DisplayFactorial();
        }

        private static void DisplayFactorial()
        {
            int number = Program.AskUserForParameterSecure();
            if (number > 1000)
                Console.WriteLine("Number need to be < 1000");
            else
                Console.WriteLine(Factorial(number));
        }

        private static int Factorial(int N)
        {
            return (N == 1) ? N : N * Factorial(N - 1);
        }

        private static void DisplayFibonnaci(int N)
        {
            int a = 0;
            int b = 1;
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(a);
                b = a + b;
                a = b - a;
            }
        }

        static void Prime(int bound)
        {
            if (bound > 1000)
                bound = 1000;
            for (int i = 1; i <= bound; i++)
                if (IsPrimary(i))
                    Console.WriteLine(i);
        }

        static bool IsPrimary(int number)
        {
            if (number < 0)
                return false;
            if (number <= 2)
                return true;

            for (int i = 2; i < number; i++)
                if (number % i == 0)
                    return false;

            return true;
        }
    }
}
