using System;

namespace TP1
{
    public class Exercice5
    {
        public static void Lunch()
        {
            int spaces = 10;
            int asterix = 1;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < spaces; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < asterix; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
                asterix++;
                spaces--;
            }
            Console.WriteLine("        |   |       ");
        }
    }
}
    