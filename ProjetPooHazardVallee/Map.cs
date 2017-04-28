using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetPooHazardVallee
{
    class Map
    {

        private int _id;
        private string _nom;
        private List<Case> _cases = new List<Case>();
        private int _taille;

        public int Taille
        {
            get
            {
                return _taille;
            }

            set
            {
                _taille = value;
            }
        }



        //constructeurs
        public Map()
        {
            _id = 1;
            _nom = "test";
            for (int k = 1; k < 10; k++)
            { _cases.Add(new Case(k)); }
        }
        public Map(int num, int taille)
        {
            _id = num;
            _nom = "test";
            Taille = taille;

        }


        //accesseur
        public void AjouterCase(int type)
        {
            _cases.Add(new Case(type));
        }
        public void ChangerCase(int numCase, int type)
        {
            _cases[numCase].changerType(type);
        }
        public int LireCase(int numCase)
        {
            return _cases[numCase].AfficherType();
        }


        //ajouter éléments (attention à la taille)
        public void AjouterMaison(int numCase)
        {
            for (int k = 0; k < 3; k++)
            {
                ChangerCase(numCase + k, 107 + k);
            }
            for (int k = 0; k < 3; k++)
            {
                ChangerCase(numCase + Taille + 2 + k, 104 + k);
            }
            for (int k = 0; k < 3; k++)
            {
                ChangerCase(numCase + (Taille + 2) * 2 + k, 101 + k);
            }

        }


        //afficher la map
        public void AfficherMap()
        {
            Console.Clear();
            foreach (Case c in _cases)
            {
                c.afficherCase();
            }
        }
    }

}
