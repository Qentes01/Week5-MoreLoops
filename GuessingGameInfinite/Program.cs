using System;

namespace GuessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            // programm genereerib juhuslikku numbri 1 kuni 10
            //kasutaja peab seda numbrit ära arvama
            //kui kasutaja suutis seda numbrit ära arvata,siis ta on mängu võitnud
            //katsete arv on piiramatu
            //programm genereerib juhuslikke numbrid ühte korda


            Random rnd = new Random();
            int cpuRandom = rnd.Next(1, 11); //numbrid 1kuni 10
            bool loopActive = true;
            while (loopActive)
            {
                Console.WriteLine("Vali number 1-10");
                int userNumber = Convert.ToInt32(Console.ReadLine());
                if(cpuRandom == userNumber)
                {
                    Console.WriteLine("Palju õnne!Oled võitnud!");
                    //break 
                    loopActive = false;

                }
                else
                {
                    Console.WriteLine("Proovi uuesti.");
                }
             
            }
            Console.WriteLine("kena päeva!");
        }   
    }
}
