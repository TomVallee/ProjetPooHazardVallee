using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetPooHazardVallee
{
    class Case
    {


        private int _type;
        private int _idEvenement;

        public int IdEvenement
        {
            get
            {
                return _idEvenement;
            }

            set
            {
                _idEvenement = value;
            }
        }

        //constructeur
        public Case(int type)
        {
            _type = type;
        }
        //accesseur
        public void changerType(int type)
        {
            _type = type;
        }
        public int AfficherType()
        {
            return _type;
        }

        //afficher la case
        public void afficherCase()
        {
            //bordures 
            //cf pavnum
            if (_type == 1)
            { Console.Write("|]-"); }
            else if (_type == 2)
            { Console.Write("---"); }
            else if (_type == 3)
            { Console.Write("-[| \n"); }
            else if (_type == 4)
            { Console.Write("|] "); }
            else if (_type == 6)
            { Console.Write(" [| \n"); }
            else if (_type == 7)
            { Console.Write("|]-"); }
            else if (_type == 8)
            { Console.Write("---"); }
            else if (_type == 9)
            { Console.Write("-[| \n"); }

            //maison
            //commence à 100
            if (_type == 101)
            { Console.Write("|__"); }
            else if (_type == 102)
            { Console.Write("| |"); }
            else if (_type == 103)
            { Console.Write("__|"); }
            else if (_type == 104)
            { Console.Write("|  "); }
            else if (_type == 105)
            { Console.Write(" _ "); }
            else if (_type == 106)
            { Console.Write("  |"); ; }
            else if (_type == 107)
            { Console.Write("/__"); }
            else if (_type == 108)
            { Console.Write("___"); }
            else if (_type == 109)
            { Console.Write("__\\"); }
            //toits
            else if (_type == 111)
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.Write(" __");
                Console.ResetColor();
            }
            else if (_type == 112)
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.Write("___");
                Console.ResetColor();
            }
            else if (_type == 113)
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.Write("__ ");
                Console.ResetColor();
            }
            else if (_type == 601)
            {
                Console.Write("/ \\");
                IdEvenement = 1;
            }





            else if (_type == 1000)//herbe
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.Write("   ");
                Console.ResetColor();
            }
            else if (_type == 2000)//heros
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.Write("^_^");
                Console.ResetColor();
            }
        }
        public static void EvenementCase(Case c,HerosMap heros)
        {
            if (c.AfficherType() < 600)//murs
            {
                Console.WriteLine("Vous ne pouvez pas aller par là");
            }
            else if (c.AfficherType() < 650)//Portes 
            {
                if (c.IdEvenement == 1)
                { 
                Map prairie = CreationMaps.Prairie(20,20);
                    heros.ChangerMap(prairie, 40);
                heros.AfficherHeros();
                    }
            }
            else if (c.AfficherType() < 1000)//objets + lignes de dialogue
            {
                //a faire
            }
        }
    }

}
