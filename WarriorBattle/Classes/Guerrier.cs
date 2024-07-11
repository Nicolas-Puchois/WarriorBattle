using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WarriorBattle.Classes
{
    internal class Guerrier
    {
        //Attribut
        private string _nom;
        private int _pointDeVie;
        private int _nbAttaques;
        private int _valeurAttaque;
        private int _degats;

        //Propriété
        public string Nom { get => _nom; set => _nom = value; }
        public int PointsdeVie { get => _pointDeVie; set => _pointDeVie = value; }

        public int NbdeDesAttaque { get => _nbAttaques; set => _nbAttaques = value; }

        public int ValeurAttaque { get => _valeurAttaque; set => _valeurAttaque = value; }

        public int Degats { get => _degats; set => _degats = value; }

        //constructeur
        public Guerrier(string nom, int pointsDeVie, int nbAttaques)
        {
            Nom = nom;
            PointsdeVie = pointsDeVie;
            NbdeDesAttaque = nbAttaques;
        }

        // methode

        public int Fight()
        {
            for(int i = 0; i < NbdeDesAttaque; i++)
            {
                RandomGenerator();
                Degats += ValeurAttaque;
                
            }
            return ValeurAttaque;
        }

        //methode
        public int CheckVie()
        {
            Degats = ValeurAttaque;
            PointsdeVie -= Degats;
            if (PointsdeVie < 0 || PointsdeVie == 0)
            {
                PointsdeVie = 0;
                Console.WriteLine($"L'attaque a tué avec une valeur de {ValeurAttaque} PV à {Nom}, il lui reste donc reste {PointsdeVie}");
                return PointsdeVie;
            }

            else if (PointsdeVie > 0)
            {
                Console.WriteLine($"\nL'attaque a enlevé {ValeurAttaque} PV à {Nom}, il reste {PointsdeVie}\n");
                return PointsdeVie;
            }
            else
            {
                return PointsdeVie;
            }

        }

        public void ContreAttaque()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"L'autre guerrier a riposté");
            Console.ForegroundColor = ConsoleColor.White;
            Fight();
            return;
        }

        public void JoueurMessage()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nTour du Joueur");
            Console.ForegroundColor = ConsoleColor.White;
            Fight();
            return;
        }

        public int RandomGenerator()
        {
            Random rng = new Random();
            ValeurAttaque = rng.Next(1,7);
            return ValeurAttaque;
        }
    }
}
