using System;
namespace TP1
{
    public class Exercice1
    {
        public static void Lunch(int i)
        {
            Console.WriteLine("Table of {0}", i);
            for (int j = 1; j <= 10; j++)
                if ((i * j) % 2 == 1)
                    Console.WriteLine("{0}*{1}={2}", i, j, i * j);
            Console.WriteLine(Environment.NewLine);
        }
    }
}
