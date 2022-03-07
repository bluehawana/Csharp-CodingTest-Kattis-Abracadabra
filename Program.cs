using System;

namespace ProblemA
{
    class Program
    {
        static void Main(string[] args)
        {

            int N = int.Parse(Console.ReadLine());
            //Get number of N from users'input

            if (N >= 1 && N <= 100)
            //Defined the scope of N(1<=N<=100);
            {
                for (int i = 0; i < N; i++)
                //Loop for printing out N lines "Abracadabra"
                {

                    Console.WriteLine((i + 1) + " " + "Abracadabra");

                }
            }
            else
            {
                Console.WriteLine("Your input is invalid, it must between 1 and 100. ");
                //Throw exception if input N is out of the scope
            }
        }
    }
}
