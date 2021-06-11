using System;
using System.Collections.Generic;

namespace DemoApp.Concepts.Delegates
{
    public class Numbers
    {
        #region Before Delegate

        public IEnumerable<int> GetNumberLessThanFive(IEnumerable<int> numbers)
        {
            foreach (var number in numbers)
            {
                if (number < 5)
                    yield return number;
            }
        }

        public IEnumerable<int> GetNumberLessThanSeven(IEnumerable<int> numbers)
        {
            foreach (var number in numbers)
            {
                if (number < 5)
                    yield return number;
            }
        }

        public IEnumerable<int> GetNumberGreaterThanFive(IEnumerable<int> numbers)
        {
            foreach (var number in numbers)
            {
                if (number > 5)
                    yield return number;
            }
        }

        #endregion Before Delegate

        #region After Delegate

        public delegate bool ConditionDelegate(int num);

        public IEnumerable<int> GetNumbers(IEnumerable<int> numbers, ConditionDelegate condition)
        {
            foreach (var number in numbers)
            {
                if (condition(number))
                    yield return number;
            }
        }

        public IEnumerable<int> GetNumbersByPredicate(IEnumerable<int> numbers, Predicate<int> condition)
        {
            foreach (var number in numbers)
            {
                if (condition(number))
                    yield return number;
            }
        }

        #endregion After Delegate
    }
}