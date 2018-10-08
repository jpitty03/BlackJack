using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerScore = 0, dealerScore = 0;
            bool isPlaying, playerWin;

            Console.WriteLine("You wanna play some BJ? Y/N");
            isPlaying = Console.ReadLine().ToString().Trim().ToLower() == "y";

            while(isPlaying)
            {
                playerWin = PlayHand();
                if(playerWin)
                {
                    playerScore++;
                }
                else
                {
                    dealerScore++;
                }
                isPlaying = WantsToPlay();

            }


        }



        private static bool WantsToPlay()
        {
            Console.WriteLine("Wanna play? Y/N");
            bool isPlaying = Console.ReadLine().ToString().Trim().ToLower() == "y";
            Console.Clear();

            return isPlaying;
        }

        private static bool PlayHand()
        {
            Random rng = new Random();
            bool busted = false, beatDealer = false;
            int playerHandValue = 0, dealerHandValue = 0, cardValue = 0;

            do
            {
                playerHandValue = rng.Next(1, 11);




                Console.WriteLine("you have hand of ");

            } while (!busted || !beatDealer);

            Console.WriteLine("yo playing hand");
            Console.ReadLine();
            return false;


            throw new NotImplementedException();
        }
    }

}
