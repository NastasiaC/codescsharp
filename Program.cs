using System;
namespace Recherche1
{
    class Program
    {
            //static void Main(string[] args)//Signature de méthode spécifique en C# qui permet d'initier une application console elle comprend plusieurs fonctions :
            //definition de static : indique les informations des élèves faisant partie de la classe 
            //définition de void : indique qu'il y aura aucune valeur de retour, elle va permettre juste d'afficher les informations
            //définition de Main : indique le commencement des informations des élèves 
            //définition string[]:la chaine de valeurs dans ce cas le nom des élèves et les notes
            //définition args : les noms des élèves et leurs notes comme des arguments
            static void Main(string[] args)
        {
            // Déclaration des variables nécessaires pour exécuter les recherches des élèves et leurs notes
            //définition de int : définition des nombres entiers
            //définition i : nom de la variable
            //définition = : attribution de la variable i à une valeur
            //défintion 0 : résultat de la variable i
            int i = 0;

            //identifier si la valeur est vraie ou fausse
            bool trouvé = false;

            //permet de stocker du texte
            string Test = "";
            
            //Déclaration et initialisation des tableaux avec les chaines de caractère définissant les noms et les notes des élèves
            string[] Noms = new string[] { "Marc", "Martine", "François", "Charlotte", "Daniel", "Patricia", "Gregory", "Yves", "Louise", "Carl" };
            int[] Moyennes = new int[] { 95, 78, 65, 88, 90, 85, 66, 86, 90, 75 };
           
            //Exécution de l'instruction demandé
            Console.Write(" Donnez-moi le nom de l’étudiant recherché : ");
            
            //test de l'instruction demandé le texte sera retranscrit en minuscule
            Test = Console.ReadLine().ToLower();

            //attente action avant de fermer
            Console.ReadKey();
        }
    }
}