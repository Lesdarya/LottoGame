using System;
using System.Collections.Generic;
using System.Linq;
using Core.Game.Session.Interfaces;

namespace Core.Model.Game.Session
{
    //TODO: fabric
    public class BarrelValueGenerator : IBarrelGenerator
    {
        private List<int> _actualValues;
        private List<int> _historyValues;
        private Random _randomizer;

        public BarrelValueGenerator()
        {
            Init();
        }

        /// <summary>
        ///  Prepare class to work
        /// </summary>
        private void Init()
        {
            _actualValues = Enumerable.Range(1, 90).ToList();
            _historyValues = new List<int>();
            _randomizer = new Random();
        }

        public int GetNext() {
            if (!IsHasNext())
                return 0;
                //throw new GameExcepion("Barrel generator values is over");

            var index = _randomizer.Next(0, _actualValues.Count);
            var result = _actualValues[index];
            _actualValues.RemoveAt(index);
            _historyValues.Add(result);
            return result;
        }

        /// <summary>
        /// Check is we can get next barrel value
        /// </summary>
        /// <returns></returns>
        private bool IsHasNext() {
            return _actualValues.Count > 0;
        }

    }
}
