﻿namespace exercici10;

/* Declara dues variables: una per al nom i una altra per l’any de naixement. 
Combina-les per crear una contrasenya bàsica (per exemple, Pere i 1982 -> Pere1982). 
Imprimeix la contrasenya generada (i sobretot no la facis servir mai que és molt dolenta) */

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Introdueix el teu nom: ");
        string nom = Console.ReadLine();
        Console.Write("Introdueix el teu any de naixement: ");
        string anyNaixement = Console.ReadLine();
        string contrasenya = nom + anyNaixement;
        Console.WriteLine("La teva contrasenya és: " + contrasenya);
    }
}
