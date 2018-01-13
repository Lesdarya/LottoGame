using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Lotto
{
    public interface ICardInfo
    {
        /// <summary>
        /// Max rows in card
        /// </summary>
        int RowsNumber { get; set; }

        /// <summary>
        /// Max columns in card
        /// </summary>
        int ColumnsNumber { get; set; }

        /// <summary>
        /// Max numbers in row
        /// </summary>
        int MaxInRow { get; set; }

        /// <summary>
        /// Max numbers in column
        /// </summary>
        int MaxInColumn { get; set; }

        /// <summary>
        /// Max numbers in card
        /// </summary>
        int MaxInCard { get; set; }
    }
}
