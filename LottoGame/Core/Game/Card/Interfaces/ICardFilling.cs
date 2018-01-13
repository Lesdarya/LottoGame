using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Lotto
{
    public interface ICardFilling
    {
        /// <summary>
        /// CardInfo in card
        /// </summary>
        int[,] Numbers { get; set; }

        /// <summary>
        /// Generates card filling (with number or etc)
        /// </summary>
        /// <param name="cardInfo">Info about card</param>       
        void GenerateFilling(ICardInfo cardInfo);
    }
}
