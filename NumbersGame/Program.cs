// Dennis Briffa (NET23)

using System.Runtime.CompilerServices;

namespace NumbersGame
{
    internal class Program
    {
        public static int SetRandomNumbersEasy()
        {
            return new Random().Next(1, 30);
        }

        public static int SetRandomNumbersNormal()
        {
            return new Random().Next(1, 50);
        }

        public static int SetRandomNumbersHard()
        {
            return new Random().Next(1, 100);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><>");
            Console.WriteLine("\n   Välkommen till Gissa Numret-spelet!\n");
            Console.WriteLine("<><><><><><><><><><><><><><><><><><><><><>\n");
            Console.WriteLine("Välj en svårighetsgrad 1, 2 eller 3. (lätt, normal eller svår)");
            Console.Write("\nVilken svårighetsgrad vill du spela på?: ");

            int maxNumberOfGuessEasy = 20;
            int maxNumberOfGuessNormal = 10;
            int maxNumberOfGuessHard = 5;

            int easySetting = SetRandomNumbersEasy();
            int normalSetting = SetRandomNumbersNormal();
            int hardSetting = SetRandomNumbersHard();

            int playerChoice = int.Parse(Console.ReadLine());

            if (playerChoice == 1)
            {
                Console.WriteLine("\nDu valde Svårighetsgrad: Lätt!");
                Console.WriteLine("Jag tänker på en siffra mellan 1 och 30...");
                Console.WriteLine("Du har hela 20 gissningar på dig!");
                Console.WriteLine("Vilken siffra tänker jag på?\n");

                for (int numberOfGuesses = 0; numberOfGuesses < maxNumberOfGuessEasy; numberOfGuesses++)
                {
                    Console.Write("\n\nAntal försök: ");
                    Console.Write(numberOfGuesses + "/20 ");
                    Console.Write("\nDin gissning: ");
                    int playerGuess = int.Parse(Console.ReadLine());

                    if (playerGuess == easySetting)
                    {
                        Console.WriteLine("\nDu gissade rätt!\n");
                        Console.WriteLine("Tack för att du spelade!\n");
                        Console.ReadKey();
                        break;
                    }
                    else
                    {
                        if (playerGuess < easySetting)
                        {
                            Console.Write("För lågt... ");
                        }
                        else
                        {
                            Console.Write("För högt... ");
                        }

                    }
                }
                Console.WriteLine("\n\nVälkommen åter!");               
            }

            if (playerChoice == 2)
            {
                Console.WriteLine("\nOhh, intressant! Du valde graden normal.");
                Console.WriteLine("Jag tänker på en siffra mellan 1 och 50...");
                Console.WriteLine("Du har 10 försök på dig.");
                Console.WriteLine("Vilken siffra tänker jag på?\n");

                for (int numberOfGuesses = 0; numberOfGuesses < maxNumberOfGuessNormal; numberOfGuesses++)
                {
                    Console.Write("\n\nAntal försök: ");
                    Console.Write(numberOfGuesses + "/10 ");
                    Console.Write("\nDin gissning: ");
                    int playerGuess = int.Parse(Console.ReadLine());

                    if (playerGuess == normalSetting)
                    {
                        Console.WriteLine("\nWow vilken bedrift, du gissade korrekt!\n");
                        Console.WriteLine("Tack ska du ha för att ha spelat på normalnivå!\n");
                        Console.ReadKey();
                        break;
                    }
                    else
                    {
                        if (playerGuess < normalSetting)
                        {
                            Console.Write("För lågt... ");
                        }
                        else
                        {
                            Console.Write("För högt... ");
                        }

                    }
                }
                Console.WriteLine("\n\nSpela gärna igen!");
            }

            if (playerChoice == 3)
            {
                Console.WriteLine("\nWow du är verkligen modig. Detta kommer bli en redig utmaning!");
                Console.WriteLine("Jag tänker på en siffra mellan 1 och 100...");
                Console.WriteLine("Tyvärr så har du bara 5 försök på dig.");
                Console.WriteLine("Vilken siffra kan det vara? Lycka till.\n");

                for (int numberOfGuesses = 0; numberOfGuesses < maxNumberOfGuessHard; numberOfGuesses++)
                {
                    Console.Write("\n\nAntal desperata försök: ");
                    Console.Write(numberOfGuesses + "/5 ");
                    Console.Write("\nDin obetydliga gissning: ");
                    int playerGuess = int.Parse(Console.ReadLine());

                    if (playerGuess == hardSetting)
                    {
                        Console.WriteLine("\nEhhh what? Helt otroligt, du klarade det!\n");
                        Console.WriteLine("Va roligt att du testade svåra nivån! Stort tack!\n");
                        Console.ReadKey();
                        break;
                    }
                    else
                    {
                        if (playerGuess < hardSetting)
                        {
                            Console.Write("För lågt... ");
                        }
                        else
                        {
                            Console.Write("För högt... ");
                        }

                    }
                }
                Console.WriteLine("\n\nKul att du testade den svåra!");
            }
        }
    }
}