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
                { Console.Write("/ \\"); }
                else if (_type == 103)
                { Console.Write("__|"); }
                else if (_type == 104)
                { Console.Write("|  "); }
                else if (_type == 105)
                { Console.Write("   "); }
                else if (_type == 106)
                { Console.Write("  |"); ; }
                else if (_type == 107)
                { Console.Write("/__"); }
                else if (_type == 108)
                { Console.Write("___"); }
                else if (_type == 109)
                { Console.Write("__\\"); }


                else if (_type == 1000)//herbe
                {
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.Write("   ");
                    Console.ResetColor();
                }
                else if (_type == 2000)//heros
                {
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.Write("   ");
                    Console.ResetColor();
                }
            }
        }
    
}
