namespace exercici2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introdueix el carrer: ");
            string carrer = Console.ReadLine();

            Console.Write("Introdueix el número: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Introdueix el codi postal: ");
            string codiPostal = Console.ReadLine();

            Console.Write("Introdueix la població: ");
            string poblacio = Console.ReadLine();

            Console.WriteLine($"{carrer}, {numero}, {codiPostal} {poblacio}");
        }
    }
}
