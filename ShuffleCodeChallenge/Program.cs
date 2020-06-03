using System;

namespace ShuffleCodeChallenge
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                int deckSize = 0;
                string input = "";

                Console.WriteLine("Indicate deck size below and press Enter to submit: ");

                while (input == "")
                {
                    input = Console.ReadLine();
                }

                try
                {
                    deckSize = Convert.ToInt32(input);
                } catch
                {
                    Console.WriteLine("=========================================");
                    Console.WriteLine("Opps.. invalid input, please try again");
                    Console.WriteLine("=========================================");
                    Console.WriteLine("");
                    Console.WriteLine("");
                    continue;
                }

                Console.WriteLine("=========================================");
                Console.WriteLine($"No. of rounds required: {ShuffleHelper.ShuffleDeck(deckSize)}");
                Console.WriteLine("=========================================");
                Console.WriteLine("");
                Console.WriteLine("");

            }
        }
    }

}
