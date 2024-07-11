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
        private bool _isAlive;

        //Propriété
        public string Nom { get => _nom; set => _nom = value; }
        public int PointsdeVie { get => _pointDeVie; set => _pointDeVie = value; }

        public bool IsAlive { get => _isAlive; set => _isAlive = value;}
        public int NbdeDesAttaque { get => _nbAttaques; set => _nbAttaques = value; }



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
            int damage;
            damage = 0;
            for(int i = 0; i < NbdeDesAttaque; i++)
            {
                Random rng = new Random();
                damage = rng.Next(0, 7);
                damage += damage;
                
            }
            return damage;
        }

        //methode
        public void CheckVie(int degats)
        {
            
            if (PointsdeVie < 0 || PointsdeVie == 0)
            {
                PointsdeVie = 0;
                Console.WriteLine($"L'attaque a tué avec une valeur de {degats} PV à {Nom}, il lui reste donc reste {PointsdeVie}");
                return;
            }

            else if (PointsdeVie > 0)
            {
                PointsdeVie -= degats;
                Console.WriteLine($"\nL'attaque a enlevé {degats} PV à {Nom}, il reste {PointsdeVie}\n");
                return;
            }
            else
            {
                return;
            }

        }

        public void ContreAttaque()
        {
            Fight();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"L'autre guerrier a riposté");
            Console.ForegroundColor = ConsoleColor.White;
            return;
        }

        public void JoueurMessage()
        {
            Fight();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nTour du Joueur");
            Console.ForegroundColor = ConsoleColor.White;
            return;
        }


    }
}
