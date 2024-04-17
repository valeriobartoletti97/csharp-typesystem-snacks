namespace csharp_typesystem_snacks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Snack 1
            //L’utente inserisce due numeri in successione.
            //Il software stampa il maggiore.
            Console.WriteLine("Inserisci un numero");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Inserisci un secondo numero");
            int num2 = Convert.ToInt32(Console.ReadLine());
            if(num1 != num2) 
            {
                if(num1 > num2)
                {
                    Console.WriteLine($"Il numero maggiore è {num1}");
                } else
                {
                    Console.WriteLine($"Il numero maggiore è {num2}");
                }
            }
            else
            {
                Console.WriteLine("I numeri sono uguali");
            }
        }
    }
}
