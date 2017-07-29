using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kickleetcode.Problems.Algorithm
{
    /// <summary>
    /// ZigZag Conversion
    /// </summary>
    class N6
    {
        public string Convert(string s, int numRows)
        {
            if (numRows <= 1)
            {
                return s;
            }
            int mid = Math.Max(numRows - 2, 0);
            int reserv = Math.Max(s.Length - numRows, 0);
            int cols = 1;
            if (reserv > 0)
            {
                cols += reserv/(numRows + mid) * (mid + 1);
                cols += reserv % (numRows + mid) > mid ? 1 + mid : reserv % (numRows + mid);
            }

            char[,] arr = new char[numRows, cols];


            int j = 0, k = 0, m = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (m == 0)
                {
                    arr[j, k] = s[i];
                    if (j < numRows - 1) {
                        j++;
                    } else {
                        j = 0;
                        k++;
                        if (mid > 0)
                        {
                            m++;
                        }
                    }
                }
                else
                {
                    arr[numRows -1 - m, k] = s[i];
                    m++;
                    k++;
                    if (m > mid) {
                        m = 0;
                    }
                }
            }

            string ret = "";
            for (int ii = 0; ii < arr.GetLength(0); ii ++)
            {
                for (int jj = 0; jj < arr.GetLength(1); jj++)
                {
                    if (arr[ii, jj] > 0)
                    {
                        ret += arr[ii, jj];
                    }
                }
            }

            return ret;
        }

    }
}
