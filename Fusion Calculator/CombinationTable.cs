using System;
using System.Collections.Generic;
using System.Text;

namespace FusionCalculator
{
    public struct Pair<T1, T2>
    {
        public readonly T1 Item1;
        public readonly T2 Item2;
        public Pair(T1 item1, T2 item2) { Item1 = item1; Item2 = item2; }

        public bool Equals(Pair<T1, T2> t)
        {
            if((Item1.Equals(t.Item1) && Item2.Equals(t.Item2)) || (Item2.Equals(t.Item1) && Item1.Equals(t.Item2))) return true;
            return false;
        }
        public override int GetHashCode() => Item1.GetHashCode() ^ Item2.GetHashCode();
        public override bool Equals(object obj) => obj is Pair<T1, T2> other && this.Equals(other);
        public static bool operator ==(Pair<T1, T2> l, Pair<T1, T2> r) => l.Equals(r);
        public static bool operator !=(Pair<T1, T2> l, Pair<T1, T2> r) => !(l == r);
    }

    public class CombinationTable<T1, T2, T3> : Dictionary<Pair<T1, T2>, T3>
    {
        public void Add(T1 a, T2 b, T3 v)
        {
            base.Add(new Pair<T1, T2>(a, b), v);
        }

        public T3 this[T1 a, T2 b]
        {
            get {
                var p = new Pair<T1, T2>(a, b);
                if (!base.ContainsKey(p)) return default;
                return base[p];
            }
            set { base[new Pair<T1, T2>(a, b)] = value; }
        }

        public bool ContainsKey(T1 a, T2 b)
        {
            return base.ContainsKey(new Pair<T1, T2>(a, b));
        }
    }
}
