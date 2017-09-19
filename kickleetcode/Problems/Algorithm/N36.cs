using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kickleetcode.Problems.Algorithm
{
    /// <summary>
    /// Valid Sudoku
    /// </summary>
    class N36
    {
        public bool IsValidSudoku(char[,] board)
        {
            int n = 9;
            int m = 0;
            HashSet<char> set = new HashSet<char>();
            for (int i = 0; i < n; i++)
            {
                set.Clear();
                for (int j = 0; j < n; j++)
                {
                    if (board[i, j] != '.')
                    {
                        bool isUnique = set.Add(board[i, j]);
                        if (!isUnique) {
                            return false;
                        }
                    }
                }
            }
            for (int j = 0; j < n; j++)
            {
                set.Clear();
                for (int i = 0; i < n; i++)
                {
                    if (board[i, j] != '.')
                    {
                        bool isUnique = set.Add(board[i, j]);
                        if (!isUnique) {
                            return false;
                        }
                    }
                }
            }
            for (int i = 0; i < 9; i= i + 3)
            {
                for (int j = 0; j < 9; j = j + 3)
                {
                    set.Clear();
                    
                    for (int k = i; k < i + 3; k++)
                    {
                        for (int l = j; l < j + 3; l ++)
                        {
                            if (board[k, l] != '.')
                            {
                                bool isUnique = set.Add(board[k, l]);
                                if (!isUnique) {
                                    return false;
                                }
                            }
                        }
                    }
                }
            }
            return true;
        }
    }
}
