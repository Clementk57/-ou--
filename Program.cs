using System;

namespace PlusOuMoins
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenue dans le jeu Plus ou Moins !");
            Console.WriteLine("Voulez-vous jouer contre un bot (1) ou contre un joueur (2) ?");
            string choix = Console.ReadLine();

            switch (choix)
            {
                case "1":
                    JouerContreBot();
                    break;
                case "2":
                    JouerContreJoueur();
                    break;
                default:
                    Console.WriteLine("Choix non valide. Veuillez sélectionner 1 pour le bot ou 2 pour un joueur.");
                    break;
            }

            Console.WriteLine("Appuyez sur une touche pour quitter.");
            Console.ReadKey();
        }

        static void JouerContreBot()
        {
            Random random = new Random();
            int nombreADeviner = random.Next(1, 101);

            Console.WriteLine("Devinez le nombre entre 1 et 100.");

            int nombreDeTentatives = 0;
            bool estDeviné = false;

            while (!estDeviné)
            {
                Console.Write("Entrez votre proposition : ");
                string input = Console.ReadLine();
                int proposition;

                if (int.TryParse(input, out proposition))
                {
                    nombreDeTentatives++;

                    if (proposition < nombreADeviner)
                    {
                        Console.WriteLine("Plus !");
                    }
                    else if (proposition > nombreADeviner)
                    {
                        Console.WriteLine("Moins !");
                    }
                    else
                    {
                        estDeviné = true;
                        Console.WriteLine("Bravo ! Vous avez trouvé le nombre en " + nombreDeTentatives + " tentatives.");
                    }
                }
                else
                {
                    Console.WriteLine("Veuillez entrer un nombre valide.");
                }
            }
        }

        static void JouerContreJoueur()
        {
            Console.Write("Joueur 1, entrez un nombre pour que le joueur 2 le devine (ne laissez pas le joueur 2 voir) : ");
            int nombreADeviner;
            while (!int.TryParse(Console.ReadLine(), out nombreADeviner) || nombreADeviner < 1 || nombreADeviner > 100)
            {
                Console.WriteLine("Veuillez entrer un nombre valide entre 1 et 100.");
            }

            Console.Clear(); // Effacer la console pour que le Joueur 2 ne voie pas le nombre

            Console.WriteLine("Joueur 2, devinez le nombre entre 1 et 100.");
            int nombreDeTentatives = 0;
            bool estDeviné = false;

            while (!estDeviné)
            {
                Console.Write("Entrez votre proposition : ");
                string input = Console.ReadLine();
                int proposition;

                if (int.TryParse(input, out proposition))
                {
                    nombreDeTentatives++;

                    if (proposition < nombreADeviner)
                    {
                        Console.WriteLine("Plus !");
                    }
                    else if (proposition > nombreADeviner)
                    {
                        Console.WriteLine("Moins !");
                    }
                    else
                    {
                        estDeviné = true;
                        Console.WriteLine("Bravo Joueur 2 ! Vous avez trouvé le nombre en " + nombreDeTentatives + " tentatives.");
                    }
                }
                else
                {
                    Console.WriteLine("Veuillez entrer un nombre valide.");
                }
            }
        }
    }
}
