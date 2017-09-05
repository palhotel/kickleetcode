using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kickleetcode.Problems.Algorithm
{
    /// <summary>
    /// Divide Two Integers
    /// </summary>
    class N29
    {
        public int Divide(int dividend, int divisor) {
            if (divisor == 0 || (divisor == -1 && dividend == int.MinValue))
            {
                return int.MaxValue;
            }
            bool isMinus = false;
            if (dividend > 0 && divisor < 0)
            {
                isMinus = true;
            } else if (dividend < 0 && divisor > 0)
            {
                isMinus = true;
            }
            long up = Math.Abs((long)dividend);
            long down = Math.Abs((long)divisor);
            int j = 0;

            while (up >= down)
            {
                int i = 0;
                int k = 1;
                while (down << i > 0 && down << i < up)
                {
                    k = 1 << i;
                    i ++;
                }
                j += k;
                up = i == 0 ? up - down : up - (down << (i - 1));
            }

            return isMinus ? -j : j;
        }
    }
}
