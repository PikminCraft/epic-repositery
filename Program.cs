using System;

namespace Carre
{
    class Program
    {
	static int CalculeCarre(int val)
	{
	    return val * val;
	}

        static void Main(string[] args)
        {
	    val test=4;
	    Console.WriteLine($"ca marche ou pas {CalculeCarre(test)}");
        }

    }
}
