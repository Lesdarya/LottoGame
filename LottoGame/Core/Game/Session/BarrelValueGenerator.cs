using System;
using System.Collections.Generic;
using System.Linq;

namespace Core.Model.Game.Session
{
    class BarrelValueGenerator
    {
        private List<int> _actualValues;
        private List<int> _historyValyes;
        private Random _randomizer;

        public BarrelValueGenerator()
        {
            Init();
        }

        /// <summary>
        ///  Prepare class to work
        /// </summary>
        public void Init()
        {
            _actualValues = Enumerable.Range(1, 90).ToList();
            _historyValyes = new List<int>();
            _randomizer = new Random();
        }

        public int GetNext() {
            if (!IsHasNext())
                throw new GameExcepion("Barrel generator values is over");

            var index = _randomizer.Next(0, _actualValues.Count);
            var result = _actualValues[index];
            _actualValues.RemoveAt(index);
            _historyValyes.Add(result);
            return result;
        }

        /// <summary>
        /// Check, is we can get next barrel value
        /// </summary>
        /// <returns></returns>
        public bool IsHasNext() {
            return _actualValues.Count > 0;
        }

    }
}
