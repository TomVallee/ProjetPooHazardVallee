using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetPooHazardVallee
{
    class CreationMaps
    {
        public static Map Test()
        {

            int longueur = 41;
            int hauteur = 41;
            Map test = new Map(2, longueur);
            test.AjouterCase(7);
            for (int k = 0; k < longueur; k++)
            {
                test.AjouterCase(8);
            }
            test.AjouterCase(9);
            for (int k = 0; k < hauteur; k++)
            {
                test.AjouterCase(4);
                for (int j = 0; j < longueur; j++)
                {
                    test.AjouterCase(1000);
                }
                test.AjouterCase(6);
            }
            test.AjouterCase(1);
            for (int k = 0; k < longueur; k++)
            {
                test.AjouterCase(2);
            }
            test.AjouterCase(3);
            test.AfficherMap();
            Console.ReadLine();
            test.AjouterMaison(50);
            test.AfficherMap();
            return test;
        }
    }
}
