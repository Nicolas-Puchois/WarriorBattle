using WarriorBattle.Classes;


Guerrier Joueur = new Guerrier("Joueur du Guerrier", 100, 3);
Guerrier Enemie = new Guerrier("Maichan pa bo", 100, 1);

void Combats()
{
    Console.WriteLine("--- Debut Du Combat ---");
    while (Joueur.PointsdeVie > 0 && Enemie.PointsdeVie > 0)
    {
            ProcessusJoueur();
            ProcessusAdversaire();
    }
    Joueur.CheckVie(0);
    Enemie.CheckVie(0);
    Winner();
}
void Winner()
{
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
void ProcessusJoueur()
{
    Joueur.JoueurMessage();
    Enemie.CheckVie(Joueur.Fight());
}
void ProcessusAdversaire()
{
    Enemie.ContreAttaque();
    Joueur.CheckVie(Enemie.Fight());

}

void CreationPersonnage()
{
    List<Guerrier> listeGuerrier = new List<Guerrier>();
    string nomPersonnage = "Boby";
    int pointsDeVie = 0;
    int nombreLancer = 0;
    int bouclierPosseder = 0;
    int choixRace = 0;

    switch (choixRace)
    {
        case 1:
            Guerrier Nom = new Guerrier(nomPersonnage, pointsDeVie, nombreLancer);
            break;
        case 2:
            Nain Nom1 = new Nain(nomPersonnage, pointsDeVie, nombreLancer, bouclierPosseder);
            listeGuerrier.Add(Nom1);
            break;
        case 3:
            Elfe Nom2 = new Elfe(nomPersonnage, pointsDeVie, nombreLancer);
            break;
        case 0:
            break;
        default:
            Guerrier Boby = new Guerrier("Boby", 100, 3);
            break;
    }

}

Combats();