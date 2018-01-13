
namespace Core.Lotto
{
    public class LottoCardInfo : ICardInfo
    {
        private int _rowsNumber;
        private int _columnsNumber;
        private int _maxInRow;
        private int _maxInColumn;
        private int _maxInCard;

        /// <summary>
        /// Число строк 
        /// </summary>
        public int RowsNumber
        {
            get { return _rowsNumber; }
            set { _rowsNumber = value; }
        }

        /// <summary>
        /// Число столбцов 
        /// </summary>
        public int ColumnsNumber
        {
            get { return _columnsNumber; }
            set { _columnsNumber = value; }
        }

        /// <summary>
        /// Максимум в строке
        /// </summary>
        public int MaxInRow
        {
            get { return _maxInRow; }
            set { _maxInRow = value; }
        }

        /// <summary>
        /// Максимум в столбце
        /// </summary>
        public int MaxInColumn
        {
            get { return _maxInColumn; }
            set { _maxInColumn = value; }
        }

        /// <summary>
        /// Максимум в карточке
        /// </summary>
        public int MaxInCard
        {
            get { return _maxInCard; }
            set { _maxInCard = value; }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="rowsNumber">Max rows in card</param>
        /// <param name="columnsNumber">Max columns in card</param>
        /// <param name="maxInRow">Max numbers in row</param>
        /// <param name="maxInColumn">Max numbers in column</param>
        /// <param name="maxInCard">Max numbers in card</param>
        public LottoCardInfo(int rowsNumber, int columnsNumber, int maxInRow, int maxInColumn, int maxInCard)
        {
            _rowsNumber = rowsNumber;
            _columnsNumber = columnsNumber;
            _maxInRow = maxInRow;
            _maxInColumn = maxInColumn;
            _maxInCard = maxInCard;
        }
    }
}
