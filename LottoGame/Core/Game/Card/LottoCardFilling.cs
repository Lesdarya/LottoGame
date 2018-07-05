using Core.Model.Game.Session;
using System;

namespace Core.Lotto
{
    public class LottoCardFilling : ICardFilling
    {
        private int[,] _numbers;

        public int[,] Numbers
        {
            get { return _numbers; }
            set { _numbers = value; }
        }

        public LottoCardFilling(ICardInfo cardInfo)
        {
            Numbers = new int[cardInfo.RowsNumber, cardInfo.ColumnsNumber];
            GenerateFilling(cardInfo);
        }

        public void GenerateFilling(ICardInfo cardInfo)
        {
            // Random number from 1 to 90. If this number is correct (there is no other same number and
            // after replacement in the card the card is correct) repeat as many times, as max numbers can be in card
            int totalNumbersCount = 0;

            var rnd = new Random();
            var valueGenearator = new BarrelValueGenerator();
            while (totalNumbersCount < cardInfo.MaxInCard)
            {
                //var randomNumber = rnd.Next(1, 90);
                var randomNumber = valueGenearator.GetNext();
                // Finding column
                var tmpColumn = randomNumber / 10;
                // Checking if there no other same number and checkin max number in column
                if (CheckInsertIntoColumn(cardInfo, tmpColumn, randomNumber))
                {
                    //Getting row, where filled not max number in row
                    var tmpRow = GetNotFullFilledRow(cardInfo, tmpColumn);
                    if (tmpRow != -1)
                    { 
                        Numbers[tmpRow, tmpColumn] = randomNumber;
                        totalNumbersCount++;
                    }
                }
            }
        }

        /// <summary>
        /// Checking if we can insert number in choosed column
        /// </summary>
        /// <param name="cardInfo">Info about card</param>
        /// <param name="columnNumber">Column, where we want insert number</param>
        /// <param name="number">Inserting number</param>
        /// <returns>True, if we can insert</returns>
        private bool CheckInsertIntoColumn(ICardInfo cardInfo, int columnNumber, int number)
        {
            if (columnNumber >= cardInfo.ColumnsNumber)
                columnNumber = cardInfo.ColumnsNumber-1;
            var countFilledNumbers = 0;
            for (int i = 0; i < cardInfo.RowsNumber; i++)
            {
                if (Numbers[i, columnNumber] == number) return false;
                if (Numbers[i, columnNumber] != 0) countFilledNumbers++;
            }
            if (countFilledNumbers < cardInfo.MaxInColumn) return true;
            return false;
        }

        /// <summary>
        /// Getting a number of row, where we can insert number
        /// </summary>
        /// <param name="cardInfo">Info about card</param>
        /// <param name="columnNumber">Column, where we want insert number</param>
        /// <returns>Number of row</returns>
        private int GetNotFullFilledRow(ICardInfo cardInfo, int columnNumber)
        {
            for (int i = 0; i < cardInfo.RowsNumber; i++)
            {
                var countFilledNumbers = 0;
                for (int j = 0; j < cardInfo.ColumnsNumber; j++)
                {
                    if (Numbers[i, j] != 0) countFilledNumbers++;
                }

                if (countFilledNumbers < cardInfo.MaxInRow &&
                    Numbers[i, columnNumber] == 0) return i;
                countFilledNumbers = 0;
            }
            return -1;
        }
    }
}
