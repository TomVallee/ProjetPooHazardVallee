using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetPooHazardVallee
{
    class Program
    {
        static void Main(string[] args)
        {
            Deroulement();
        }
        public static void Deroulement()
        {
            Map test= CreationMaps.Test();
            HerosMap heros = new HerosMap(test, 400);
            heros.AfficherHeros();
            while (5 < 6)
            {
                heros.DeplacerHeros();
            }

        }
        
    }
}
