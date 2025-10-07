namespace exercici3;

/* Defineix quatre variables per al nom d’un producte, el seu preu 
i si està en estoc o no. Imprimeix la informació de forma clara. */
class Program
{
    static void Main(string[] args)
    {
        // Declarem les variables
        string nomProducte = "Portàtil Lenovo IdeaPad";
        double preu = 749.99;
        bool enEstoc = true;
        int quantitat = 15;

        // Imprimim la informació de forma clara
        Console.WriteLine("=== Informació del producte ===");
        Console.WriteLine($"Nom: {nomProducte}");
        Console.WriteLine($"Preu: {preu} €");
        Console.WriteLine($"Quantitat disponible: {quantitat}");
        Console.WriteLine($"Està en estoc: {(enEstoc ? "Sí" : "No")}");
    }
}

