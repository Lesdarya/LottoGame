using Core;
using Core.Lotto;
using System;

namespace GamingForm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");

            var enteredKey = ConsoleKey.Escape;
            do
            {
                Console.WriteLine();
                var card = new LottoCard();
                var filling = card.GetFilling();
                ViewCard.DrawCardInConsole(card);
                
                Console.WriteLine("Press ENTER to generate new card");
                enteredKey = Console.ReadKey().Key;
            }
            while (enteredKey == ConsoleKey.Enter);

            //blablalba
            Console.ReadKey();
        }
    }
}
