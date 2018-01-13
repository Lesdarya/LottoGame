using Core.Lotto;


namespace Core
{
    public class LottoCard
    {
        private LottoCardInfo _cardInfo;

        private LottoCardFilling _cardFilling;

        /// <summary>
        /// Массив номеров на карточке
        /// </summary>
        public LottoCardInfo CardInfo
        {
            get
            {
                if (_cardInfo == null)
                    _cardInfo = new LottoCardInfo(3, 9, 5, 2, 15);
                return _cardInfo;
            }
            set { _cardInfo = value; }
        }

        public LottoCardFilling CardFilling
        {
            get
            {
                if (_cardFilling == null)
                    _cardFilling = new LottoCardFilling(CardInfo);
                return _cardFilling;
            }
            set { _cardFilling = value; }
        }

        public ICardFilling GetFilling()
        {
            return CardFilling;
        }

    }
}
