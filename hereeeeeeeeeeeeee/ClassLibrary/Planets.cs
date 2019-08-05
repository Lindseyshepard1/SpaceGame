using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static ClassLibrary.HelperMethods;

namespace ClassLibrary
{
    public class Planets
    {

        public void Earth(Player player, Challenges challenges)
        {
            TypeWriter("\nEarth is dying!!! Hurry up and get ready to leave quickly. We need to find a new planet!\n");
            TypeWriter($"\nyou have ${player.BankAccount} and you need to buy a ship and suit.\n\nPRESS ENTER");
            ReadLine();
            Clear();
            player.BuyShipAndSuit();
            player.BuyFuel(-100);
        }

        public void PlanetOne(Player player, Challenges challenges)
        {
            TypeWriter("\nWelcome to Planet 1! you must complete this challenge to move on\n.");
            challenges.PlanetOneChallenge(player);
            player.Market(-100);
            TypeWriter("Thats the last thing so lets get some fuel for the next planet!\n");
            player.BuyFuel(-150);
        }

        public void PlanetTwo(Player player, Challenges challenges)
        {
            TypeWriter("\nWelcome to Planet 2! you must complete this challenge to move on\n.");
            challenges.PlanetTwoChallenge(player);
            player.Market(-200);
            TypeWriter("Thats the last thing so lets get some fuel for the next planet!\n");
            player.BuyFuel(-120);
        }

        public void PlanetThree(Player player, Challenges challenges)
        {
            TypeWriter("\nWelcome to Planet 3! you must complete this challenge to move on\n.");
            challenges.PlanetThreeChallenge(player);
            player.Market(-150);
            TypeWriter("Thats the last thing so lets get some fuel for the next planet!\n");
            player.BuyFuel(-100);
        }

        public void PlanetFour(Player player, Challenges challenges)
        {
            TypeWriter("\nWelcome to the final planet! you must complete this challenge to move on\n.");
            challenges.PlanetFourChallenge(player);
            player.Market(-100);
            TypeWriter("Congrats you made it!\nBuy a house with all of the money you saved\n");
            player.BuyHouse();
        }
    }
}
