using System;
using System.Collections.Generic;

namespace LR20_lms_4._3_animals_IEnumerable_IComparable
{
    public class Animal : IComparable<Animal>
    {
        public Animal(string genus, int weight)
        {
            this.Genus = genus;
            this.Weight = weight;
        }

        public string Genus { get; set; }
        public int Weight { get; set; }

        public int CompareTo(Animal other)
        {
            return this.Genus.CompareTo(other.Genus);
        }

        public static IComparer<Animal> SortWeightAscending
        {
            get
            {
                return (IComparer<Animal>) new SortWeightAscendingHelper();
            }
        }

        public static IComparer<Animal> SortGenusDescending
        {
            get
            {
                return (IComparer<Animal>) new SortGenusDescendingHelper();
            }
        }

        public override string ToString()
        {
            return $"{Genus}, weight: {Weight}";
        }

        class SortWeightAscendingHelper : IComparer<Animal>
        {
            public int Compare(Animal x, Animal y)
            {
                return x.Weight.CompareTo(y.Weight);
            }
        }

        class SortGenusDescendingHelper : IComparer<Animal>
        {
            public int Compare(Animal x, Animal y)
            {
                return y.Genus.CompareTo(x.Genus);
            }
        }
    }
}
