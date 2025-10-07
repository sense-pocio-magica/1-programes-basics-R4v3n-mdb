﻿namespace exercici14;

// Declara una paraula i fes que el programa imprimeixi només la primera lletra, l'última lletra i la lletra del mig 
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Escriu una paraula: ");
        string paraula = Console.ReadLine();

        char primera = paraula[0];
        char ultima = paraula[paraula.Length - 1];
        char mig = paraula[paraula.Length / 2];

        Console.WriteLine("Primera lletra: " + primera);
        Console.WriteLine("Lletra del mig: " + mig);
        Console.WriteLine("Última lletra: " + ultima);
    }
}

