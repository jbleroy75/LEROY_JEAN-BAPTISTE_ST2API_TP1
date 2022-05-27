using System;


namespace TP1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercice1.Lunch(AskUserForParameterSecure());
            //Exercice2.Lunch();
            //Exercice3.Lunch();
            //Exercice4.Lunch();
            //Exercice5.Lunch();
        }

        public static int AskUserForParameterSecure()
        {
            int result;
            do
            {
                Console.WriteLine("Please write a number < 1000 and press enter :");
                int.TryParse(Console.ReadLine(), out result);
            } while (result < 0 || 1000 < result);

            return result;
        }
    }
}
