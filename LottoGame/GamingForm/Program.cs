using Core;
using Core.Lotto;
using System;

namespace GamingForm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var card = new LottoCard();
            var filling = card.GetFilling();
            ViewCard.DrawCardInConsole(card);

            //blablalba
            Console.ReadKey();
        }
    }
}
