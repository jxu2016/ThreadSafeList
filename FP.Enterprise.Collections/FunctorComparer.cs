using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FP.Enterprise.Collections
{
    public sealed class FunctorComparer<T> : IComparer<T>
    {
        Comparison<T> comparison;

        public FunctorComparer(Comparison<T> comparison)
        {
            this.comparison = comparison;
        }

        public int Compare(T x, T y)
        {
            return comparison(x, y);
        }
    }

}
