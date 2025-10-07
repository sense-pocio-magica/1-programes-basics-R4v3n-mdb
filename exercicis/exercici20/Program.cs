namespace exercici20;

/* Ens cal un programa que quan li entrem un número de tres xifres i ens retorni 
el número amb els dígits invertits. 

Ex. 245 -> 542
Entra el número a invertir: 347
El número invertit és: 743
*/

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Entra el número a invertir: ");
        int num = Convert.ToInt32(Console.ReadLine());

        int centenes = num / 100;
        int desenes = (num / 10) % 10;
        int unitats = num % 10;

        int invertit = unitats * 100 + desenes * 10 + centenes;

        Console.WriteLine("El número invertit és: " + invertit);
    }
}
