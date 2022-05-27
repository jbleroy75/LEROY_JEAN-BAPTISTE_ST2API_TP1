using System;

namespace TP1
{
    public class Exercice3
    {
        public static void Lunch()
        {
            try
            {
                for (int i = -3; i <= 3; i++)
                    Console.WriteLine(10 / PowerFunction(i));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        private static int PowerFunction(int x)
        {
            return (int)(Math.Pow(x, 2) - 4);
        }
    }
}
