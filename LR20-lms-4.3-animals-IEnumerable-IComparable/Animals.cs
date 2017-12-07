using System;
using System.Collections;
using System.Collections.Generic;

namespace LR20_lms_4._3_animals_IEnumerable_IComparable
{
    public class Animals : IEnumerable<Animal>
    {
        private Animal[] _animals;

        public Animals(Animal[] animals)
        {
            this._animals = animals;
        }

        public void Sort(IComparer<Animal> comparer = null)
        {
            if (comparer == null)
            {
                Array.Sort(this._animals);
            }
            else
            {
                Array.Sort(this._animals, comparer);
            }
        }

        public IEnumerator<Animal> GetEnumerator()
        {
            foreach (var item in _animals)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _animals.GetEnumerator();
        }
    }
}
