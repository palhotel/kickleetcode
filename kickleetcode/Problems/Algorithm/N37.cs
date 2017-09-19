using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kickleetcode.Problems.Algorithm
{
    /// <summary>
    /// Sudoku Solver
    /// </summary>
    class N37
    {
        public void SolveSudoku(char[,] board) {
            if (board == null || board.Length == 0)
                return;
            Solve(board);
        }

        public bool Solve(char[,] board) {
            for (int i = 0; i < 9; i++) {
                for (int j = 0; j < 9; j++) {
                    if (board[i,j] == '.') {
                        for (char c = '1'; c <= '9'; c++) {
                            if (IsValid(board, i, j, c)) {
                                board[i,j] = c;

                                if (Solve(board))
                                {
                                    return true;
                                }
                                else
                                {
                                    board[i, j] = '.';
                                }   
                            }
                        }
                        return false;
                    }
                }
            }
            return true;
        }

        private bool IsValid(char[,] board, int row, int col, char c) {

            for (int i = 0; i < 9; i++) {
                if (board[i,col] == c) {
                    return false; //check row
                }
                else if (board[row,i] == c) {
                    return false; //check column
                }
                else if (board[3*(row/3) + i/3, 3*(col/3) + i%3] == c)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
