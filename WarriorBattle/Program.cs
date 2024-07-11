using WarriorBattle.Classes;

int valeurDesAttaque;
valeurDesAttaque = 1;


Guerrier Joueur = new Guerrier("Joueur du Guerrier", 100, 3);
Guerrier Enemie = new Guerrier("Maichan pa bo", 100, 1);
Elfe Sylvain = new Elfe("Sylvain", 75,3);
Nain PadIde = new Nain("PadIdé", 125, 50,2);

/*
Console.WriteLine(Sylvain.Nom);
Console.WriteLine(PadIde.Nom);
Console.WriteLine(Joueur.Nom);
Console.WriteLine(Enemie.Nom);
*/



void Combats()
{
    Console.WriteLine("--- Debut Du Combat ---");

    while (Joueur.PointsdeVie > 0 && Enemie.PointsdeVie > 0)
    {
        Processus();
    }
    if (Joueur.PointsdeVie == 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\n" + Enemie.Nom + " Win");
        Console.ForegroundColor = ConsoleColor.White;
    }
    else if (Enemie.PointsdeVie == 0)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\n" + Joueur.Nom + " Win");
        Console.ForegroundColor = ConsoleColor.White;
    }
}

void Processus()
{
    Joueur.JoueurMessage();
    Enemie.Degats = Joueur.ValeurAttaque;
    Enemie.CheckVie();
    Enemie.ContreAttaque();
    Joueur.Degats = Enemie.ValeurAttaque;
    Joueur.CheckVie();
    
}

Combats();