using System;

namespace TP1
{
    public class Exercice4
    {
        public static void Lunch()
        {
            DisplayRectangle(Program.AskUserForParameterSecure(), Program.AskUserForParameterSecure());
        }

        static void DisplayRectangle(int n, int m)
        {
            char current;
            for (int i = 0; i < n; i++)
            {
                if (i == 0 || i == n - 1)
                {
                    current = '_';
                    Console.Write("0");
                }
                else
                {
                    current = ' ';
                    Console.Write("|");
                }

                for (int j = 1; j < m - 1; j++)
                    Console.Write(current);

                if (i == 0 || i == n - 1)
                    Console.Write("0");
                else
                    Console.Write("|");
                Console.Write(Environment.NewLine);
            }
        }
    }
}
