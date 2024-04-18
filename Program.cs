using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Runtime.ConstrainedExecution;
using System;
using System.Xml.Linq;
using System.Diagnostics.CodeAnalysis;

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

            /*int[] numbers = { 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int sum = 0;
            foreach(int i in numbers)
            {
                sum += i;
            }
            Console.WriteLine($"La somma dei numeri da 2 a 10 è : {sum}");
            float numAverage = (decimal)sum / numbers.Length;
            Console.WriteLine($"La media aritmetica dei numeri da 2 a 10 è : {numAverage}");*/


            //SNACK 5 
            //Il software chiede all’utente di inserire un numero.Se il numero inserito è pari, stampa il numero, se è dispari, stampa il numero successivo.

            /*Console.WriteLine("Inserisci un numero:");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine($"Il numero inserito è {number}");
            } else
            {
                Console.WriteLine($"Il numero successivo al numero inserito è {number + 1}");
            }*/

            //SNACK 6
            //In un array sono contenuti i nomi degli invitati alla festa del grande Gatsby. Chiedi all’utente il suo nome e comunicagli se può partecipare o meno alla festa.

            /*string[] guests = { "Andrea", "Davide", "Valerio", "Oder", "Mirko", "Massimiliano" };
            Console.WriteLine("Inserisci il tuo nome:");
            string myName = Console.ReadLine();
            if (guests.Contains(char.ToUpper(myName[0]) + myName.Substring(1)))
            {
                Console.WriteLine("Benvenuto, lei è nella lista degli invitati! Entri pure..");
            } else
            {
                Console.WriteLine("Mi dispiace ma non sei stato invitato. Tornatene pure a casa. Grazie");
            }*/

            //SNACK 7 
            //Crea un array vuoto.
            //Chiedi per 6 volte all’utente di inserire un numero, se è dispari inseriscilo nell’array.

            /*int[] numbers = new int[6];
            for( int i = 0; i < numbers.Length; i++ )
            {
                Console.WriteLine("Inserisci un numero: ");
                int newNumber = Convert.ToInt32(Console.ReadLine());
                if(newNumber % 2 != 0)
                {
                    numbers[i] = newNumber;
                } 
            }
            Console.WriteLine("Attenzione!! I numeri pari da te inseriti sono stati valutati come 0");
            Console.WriteLine("I numeri inseriti sono:");
            foreach( int number in numbers )
            {
                Console.WriteLine(number);
            }*/

            //SNACK 8
            //Crea un array di numeri interi e fai la somma di tutti gli elementi che sono in posizione dispari.

            /*int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i % 2 != 0)
                {
                    sum += numbers[i];
                }
            }
            Console.WriteLine($"La somma dei numeri in posizione dispari del tuo array è: {sum}");*/

            //Snack 9
            //Crea un array vuoto e chiedi all’utente un numero da inserire nell’array.Continua a chiedere i numeri all’utente e a inserirli nell’array, fino a quando la somma degli elementi è minore di 50.

            /*int[] numbers = new int[10];
            int sum = 0;
            Console.WriteLine($"Inserisci un massimo di {numbers.Length} numeri affinchè la somma di essi superi 50");
            for (int i = 0; i < numbers.Length; i++)
            {
                if (sum < 50) 
                {
                    int newNumber = Convert.ToInt32(Console.ReadLine());
                    numbers[i] = newNumber;
                    sum += numbers[i];
                }
                else
                {
                    break;
                }
            }
            if( sum < 50)
            {
                Console.WriteLine($"Oh no mi dispiace! La somma dei tuoi numeri è {sum}. Non sei stato abbastanza bravo da raggiungere 50 :(");
            }
            else
            {
                Console.WriteLine($"Complimenti ce l'hai fatta! La somma dei tuoi numeri è {sum}");
            }*/


            //Snack 10
            //Fai inserire un numero, che chiameremo N, all’utente.
            //Genera N array, ognuno formato da 10 numeri casuali tra 1 e 100.
            //Ogni volta che ne crei uno, stampalo a schermo.

            Console.WriteLine("Inserisci un numero:");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int[] newArray = new int[10];
                Random rnd = new Random();
                for(int j= 0; j < newArray.Length; j++)
                {
                    newArray[j] = rnd.Next(1,101);
                }
                Console.WriteLine($"Array numero {i + 1}:");
                for(int z= 0; z < newArray.Length; z++)
                {
                    Console.WriteLine($"{z+ 1}) {newArray[z]}" );
                }
            }
        }
    }
}
