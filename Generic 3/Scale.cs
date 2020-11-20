using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace Generic_3
{
    class Scale<T> where T : IComparable
    {
        private T left, right;
        public Scale(T left,T right)
        {
           this.left = left;
           this.right = right;
        }
       public  T GetHeavier()
        {
            if (left.CompareTo(right) > 0)
                return left;
            else if (right.CompareTo(left) > 0)
                return right;
            else return default(T);
        }

    }
}
