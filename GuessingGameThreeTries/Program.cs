using System;

namespace GuessingGameThreeTries
{
    class Program
    {
        static void Main(string[] args)
        {
            // programm genereerib juhuslikku numbri 1 kuni 10
            //kasutaja peab seda numbrit ära arvama
            //kui kasutaja suutis seda numbrit ära arvata,siis ta on mängu võitnud
            //kasutajal on kolm katset, kui kasutaja ei ole suutnud kolme katsega numbrit ära arvata
            // siis võidab arvuti
            //programm genereerib juhuslikke numbrid ühte korda

            Random rnd = new Random();
            int cpuRandom = rnd.Next(1, 11); //numbrid 1kuni 10
            int i = 0;

            while (i < 3)
            {
                Console.WriteLine("Vali number 1-10");
                int userNumber = Convert.ToInt32(Console.ReadLine());

                if (cpuRandom == userNumber)
                {
                    Console.WriteLine("Palju õnne! Oled võitnud");
                    //break;
                    i = 3;

                }
                else
                {
                    i = i + 1;
                    Console.WriteLine($"Proovi uuesti. {3 - i} katset on jäänud");
                }
                
                
            }
                      Console.WriteLine("Kena päeva");
                
        }
    }
}
