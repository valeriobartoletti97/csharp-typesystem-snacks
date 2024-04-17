using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Runtime.ConstrainedExecution;

namespace csharp_typesystem_snacks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SNACK 1 
            //L’utente inserisce due numeri in successione.
            //Il software stampa il maggiore.

            /*Console.WriteLine("Inserisci un numero");
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
            } */

            //SNACK 2 
            //L’utente inserisce due parole in successione.
            //Il software stampa prima la parola più corta, poi la parola più lunga.

            /*Console.WriteLine("Inserisci una parola");
            string word1 = Console.ReadLine();
            Console.WriteLine("Inserisci una seconda parola");
            string word2 = Console.ReadLine();
            if (word1.Length != word2.Length)
            {
                if (word1.Length > word2.Length)
                {
                    Console.WriteLine($"La parola più lunga è {word1}");
                }
                else
                {
                    Console.WriteLine($"La parola più lunga è {word2}");
                }
            }
            else
            {
                Console.WriteLine("Le parole hanno la stessa lunghezza");
            }*/

            //SNACK 3 
            //Il software deve chiedere per 10 volte all’utente di inserire un numero.
            //Il programma stampa la somma di tutti i numeri inseriti.

            /*int[] numbers = new int[10];
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Inserisci un numero");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
                sum += numbers[i];
            }
            Console.WriteLine($"La somma dei tuoi numeri è {sum}");*/

            //SNACK 4
            //Calcola la somma e la media dei numeri da 2 a 10.

            int[] numbers = { 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int sum = 0;
            foreach(int i in numbers)
            {
                sum += i;
            }
            Console.WriteLine($"La somma dei numeri da 2 a 10 è : {sum}");
            float numAverage = sum / numbers.Length;
            Console.WriteLine($"La media aritmetica dei numeri da 2 a 10 è : {numAverage}");

        }
    }
}
