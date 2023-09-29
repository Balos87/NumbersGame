// Dennis Briffa (NET23)

using System.Runtime.CompilerServices;

namespace NumbersGame
{
    internal class Program
    {
        public static int SetRandomNumbers()
        {
            return new Random().Next(1, 3);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><>");
            Console.WriteLine("\nVälkommen till Gissa Numret-spelet!");
            Console.WriteLine("Jag tänker på ett nummer mellan 1-3..");
            Console.WriteLine("Du har 5 gissningar på dig!    \n");
            Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><>");
            Console.Write("\nGissa vilket nummer jag tänker på: ");

            int maxNumberOfGuess = 5;

            int myOwnMethod = SetRandomNumbers();

            for (int i = 0; i < maxNumberOfGuess; i++)
            {
                int playerGuess = int.Parse(Console.ReadLine());


                if (playerGuess == myOwnMethod)
                {
                    Console.WriteLine("Rätt gissning!");
                    Console.WriteLine("\nTack för att du spelade!");
                    Console.ReadKey();
                    break;
                }
                else
                {
                    Console.WriteLine("Det var fel! \n");

                    if (i != playerGuess)
                    {
                        Console.Write("Försök igen: ");
                    }

                }
            }
            Console.WriteLine("\nVälkommen åter!\n\n");
        }
    }
}