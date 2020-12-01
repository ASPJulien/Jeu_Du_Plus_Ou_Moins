using System;

namespace TP_Le_jeu_du_plus_ou_du_moins
{

    static class GameSystem
    {
        private static int valeurATrouver = new Random().Next(0, 100);
        private static int _countPlays = 0;
        
        public static void Bienvenue()
        {
            Console.WriteLine("Bienvenue " + Environment.UserName + ", dans le jeu du plus ou moins.");
            Console.WriteLine("Je vais chosir un nombre entre 1 et 99,");
        }

        public static void Game()
        {
            Console.WriteLine("\nDonnez moi un nombre.");
            int numberChoosed;
            bool nomberCorrect = int.TryParse(Console.ReadLine(), out numberChoosed);
            if (nomberCorrect)
            {
                if(numberChoosed == valeurATrouver)
                {
                    _countPlays++;
                    Win();
                }
                else if (numberChoosed > valeurATrouver)
                {
                    _countPlays++;
                    Console.WriteLine("Plus petit");
                    Game();
                }
                else if (numberChoosed < valeurATrouver)
                {
                    _countPlays++;
                    Console.WriteLine("Plus grand");
                    Game();
                }
            }
            else if (!nomberCorrect)
            {
                Console.WriteLine("Le nombre donné n'est pas correct, merci de recommencer");
                Game();
            }
        }

        private static void Win()
        {
            Console.WriteLine("\nBravo !");
            Console.WriteLine("Tu as gagné en " + _countPlays + " coup" + Pluriel.pluriel(_countPlays) + " !");
            Console.ReadKey();
        }
    }
}