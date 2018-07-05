using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Lotto
{
    public static class ViewCard
    {
        public static void DrawCardInConsole(LottoCard lotoCard)
        {
            Console.WriteLine("*****GENERATED LOTO CARD*****");
            if (lotoCard != null)
            {
                for(int i = 0; i < lotoCard.CardInfo.RowsNumber; i++)
                {
                    for(int j = 0; j < lotoCard.CardInfo.ColumnsNumber; j++)
                    {
                        Console.Write((lotoCard.CardFilling.Numbers[i, j] == 0 ? "__" : lotoCard.CardFilling.Numbers[i, j].ToString()) + " ");
                    }
                    Console.WriteLine();
                }
            }
            else
                Console.WriteLine("ERROR OCCURRED");

        }
    }
}
