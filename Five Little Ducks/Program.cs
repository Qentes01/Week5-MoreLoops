using System;

namespace Five_Little_Ducks
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string ducks;

            for(int i = 5; i > 0 ; i--)
            {
                if (i > 2)
                {
                    ducks = "ducks";
                }
                else
                {
                    ducks = "duck";
                }
                Console.WriteLine($"{i} little {ducks} went out one day");
                Console.WriteLine("Over the hill and for away");
                Console.WriteLine("Mother duck said, \"quack,quack,quack,quack \"");

                if (i == 2)
                {
                    ducks = "duck";
                }

                if (i > 1)
                {
                    Console.WriteLine($"But only {i - 1} little {ducks} come back.");
                }
                
                else
                {
                    Console.WriteLine($"But none of the {i+4}little ducks come back");
                }
                

                Console.WriteLine();
            }

        }
    }
}
