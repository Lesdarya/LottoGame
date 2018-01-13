using Core;
using Core.Lotto;
using System;

namespace LotoGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var card = new LottoCard();
            var filling = card.GetFilling();
            ViewCard.DrawCardInConsole(card);

            //blablalba
            Console.ReadKey();
        }
    }
}
