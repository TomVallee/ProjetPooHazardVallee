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
            _typeCasePrec = world.LireCase(_numCase).AfficherType(); ;
            world.ChangerCase(_numCase, 2000);
            world.AfficherMap();
        }
        public void CommanderHeros()
        {
            string dir = "";
            do
            {
                world.AfficherMap();
                Console.WriteLine("Entrez direction ZQSD");
                dir = Console.ReadKey().KeyChar.ToString();
            }
            while (dir != "z" && dir != "q" && dir != "s" && dir != "d");
            int numFutureCase = 0;
            if (dir == "z")
            {
                numFutureCase = _numCase - world.Taille - 2;

            }
            else if (dir == "q")
            {
                numFutureCase = _numCase - 1;

            }
            else if (dir == "s")
            {
                numFutureCase = _numCase + world.Taille + 2;

            }
            else if (dir == "d")
            {
                numFutureCase = _numCase + 1;
            }
            Case futureCase = world.LireCase(numFutureCase);
            if (futureCase.AfficherType() > 999)
            {
                world.ChangerCase(_numCase, _typeCasePrec);
                _numCase = numFutureCase;
                AfficherHeros();
            }
            else
            {
                world.AfficherMap();
                Case.EvenementCase(futureCase,this);
            }
        }
        public void ChangerMap(Map nouveauMonde, int caseDépart)
        {
            _typeCasePrec = 0;
            _numCase = caseDépart;
            world = nouveauMonde;
        }
    }
}
