using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetPooHazardVallee
{
    class HerosMap
    {

        private int _typeCasePrec;
        private int _numCase;
        private Map world;

        public HerosMap(Map m, int numCase)
        {
            _typeCasePrec = 0;
            _numCase = numCase;
            world = m;
        }

        public void AfficherHeros()
        {
            _typeCasePrec = world.LireCase(_numCase);
            world.ChangerCase(_numCase, 2000);
            world.AfficherMap();
        }
        public void DeplacerHeros()
        {
            string dir = "";
            do
            {
                Console.WriteLine("Entrez direction ZQSD");
                dir = Console.ReadLine();
            }
            while (dir != "z" && dir != "q" && dir != "s" && dir != "d");
            int futureCase = 0;
            if (dir == "z")
            {
                futureCase = _numCase - world.Taille - 2;

            }
            else if (dir == "q")
            {
                futureCase = _numCase - 1;

            }
            else if (dir == "s")
            {
                futureCase = _numCase + world.Taille + 2;

            }
            else if (dir == "d")
            {
                futureCase = _numCase + 1;
            }
            if (world.LireCase(futureCase) > 999)
            {
                world.ChangerCase(_numCase, _typeCasePrec);
                _numCase = futureCase;
                AfficherHeros();
            }
            else
            {
                world.AfficherMap();
                Console.WriteLine("Vous ne pouvez pas aller par là");
            }
        }
    }
}
