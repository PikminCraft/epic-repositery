using System;

namespace Carre
{
    class Program
    {
	// Sous-Programme CalculeCarre: calcule le carré de l'entier
	// passe en parametre
	// Parametre :
	// - val : entier dont on souhaite le carre (en entree) :
	// Valeur de retour : le carre de val

	int CalculeCarre(int val)
	{
	    return val * val;
	}

        static void Main(string[] args)
        {
	    int i;

	    Console.WriteLine($"saisir un entier");
	    i = Convert.ToInt32(Console.ReadLine())

	    Console.WriteLine(CalculeCarre(i));
        }

    }
}
