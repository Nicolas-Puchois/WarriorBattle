using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarriorBattle.Classes
{
    internal class Elfe : Guerrier
    {
        private int _attassure = 2;

        public int AttaqueAssure { 
            get { return _attassure; } 
        }

        public Elfe(string nom, int pointsDeVie, int nbAttaques) : base (nom, pointsDeVie, nbAttaques)
        {
        
        }
            
            
     }
}
