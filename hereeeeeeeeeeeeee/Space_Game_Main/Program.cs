using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using ClassLibrary;
using static ClassLibrary.HelperMethods;

namespace Space_Game_Main
{
    public class Program
    {
        static void Main(string[] args)
        {
            ChangeColor();

            Player player = new Player();
            Planets planets = new Planets();
            Stars stars = new Stars();
            Challenges challenges = new Challenges();

            planets.Earth(player, challenges);
            stars.StarOne(player);
            planets.PlanetOne(player, challenges);
            stars.StarTwo(player);
            planets.PlanetTwo(player, challenges);
            stars.StarThree(player);
            planets.PlanetThree(player, challenges);
            stars.StarFour(player);
            planets.PlanetFour(player, challenges);
        }
    }
}
