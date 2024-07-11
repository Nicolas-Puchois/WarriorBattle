using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarriorBattle.Classes
{
    internal class Nain : Guerrier
    {
        private int _ptBouclier;


        public int Bouclier { get => _ptBouclier; set => _ptBouclier = value; }
        public Nain (string nom, int pointsDeVie, int nbAttaques ,int bouclier):base(nom, pointsDeVie, nbAttaques) 
        { 
            Bouclier = bouclier;
        }
    }
}
