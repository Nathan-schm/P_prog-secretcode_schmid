using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secretcode_schmid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //titre du jeu
            Console.WriteLine("╔═══════════════ Nathan Schmid ══════════════╗");
            Console.WriteLine("║                                            ║");
            Console.WriteLine("║    Bienvenue dans le jeu : Secret Code     ║");
            Console.WriteLine("║                                            ║");
            Console.WriteLine("╚════════════════════════════════════════════╝\n");

            Console.WriteLine("Un code secret composé de 4 chiffres est généré.");
            Console.WriteLine("À toi de le découvrir en 10 essais maximum !\n");
            Console.WriteLine("À chaque essai, tu reçois un indice selon le niveau choisi.\n");
            Console.WriteLine("Pour les niveaux 1 et 3 avec indices visibles :");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("■");
            Console.ResetColor();
            Console.WriteLine(" : chiffre bien placé");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("■");
            Console.ResetColor();
            Console.WriteLine(" : chiffre correct mais mal placé");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("■");
            Console.ResetColor();
            Console.WriteLine(" : chiffre absent\n");
            Console.WriteLine("Exemple :\nCode secret : 1234 (caché)\nVotreessai : 1325\nIndice     :");
            Console.ForegroundColor= ConsoleColor.Blue;
            Console.Write("■");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("■");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("■");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("■");
            Console.ResetColor();
            Console.WriteLine(" (1 bien placé, 2 mal placés, 1 absent)\n");
            Console.WriteLine("Pour les niveaux 2 et 4 avec indices diescrets :\nExemple :\nCode secret : 5413 (caché)\nVotre essai : 1234\nIndice");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("→0 bien placé(s), 3 mal placé(s)\n");
            Console.ResetColor();
            Console.WriteLine("Appuie sur ENTER pour commencer...");

            Console.ReadLine();
            
            Console.Clear();
            Console.WriteLine("=== SECRET CODE ===\n");
            Console.WriteLine("Choisi un niveau :\n1. Débutant\t\t(1 à 6, sans doublons, indices visibles)\n2. Intermédiaire\t(1 à 6, sans doublons, indices discrets)");
            Console.WriteLine("3. Avancé\t\t(+ à 8, avec doublons, indices visibles)\n4. Expert\t\t(1 à 9, avec doublons, indices discrets)");

            Console.ReadLine();
        }
    }
}
