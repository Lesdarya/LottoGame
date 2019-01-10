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
                        var tmpNumber = lotoCard.CardFilling.Numbers[i, j];
                        Console.Write((tmpNumber == 0 ? "__" : 
                            ((tmpNumber > 9 ? "" : "0") + tmpNumber.ToString())) + " " );
                    }
                    Console.WriteLine();
                }
            }
            else
                Console.WriteLine("ERROR OCCURRED");

        }
    }
}
