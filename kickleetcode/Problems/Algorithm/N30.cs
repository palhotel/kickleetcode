using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kickleetcode.Problems.Algorithm
{
    /// <summary>
    /// Substring with Concatenation of All Words
    /// </summary>
    class N30
    {
        public IList<int> FindSubstring(string s, string[] words) {
            List<int> list = new List<int>();
            if (words.Length > 0 && s.Length > 0) {
                int nLen = words[0].Length;
                int nMax = words.Length;

                Dictionary<string, int> dic = new Dictionary<string, int>();
                Dictionary<string, int> iterDic = new Dictionary<string, int>();
                for (int i = 0; i < words.Length; i++) {
                    if (dic.ContainsKey(words[i])) {
                        dic[words[i]] = dic[words[i]] + 1;
                    } else {
                        dic[words[i]] = 1;
                        iterDic[words[i]] = i;
                    }
                }

                int[] array = new int[nMax];
                int iter = 0;
                for (int i = 0; i <= s.Length - nLen * nMax; ) {
                    while (iter + nLen <= s.Length) {
                        string strTemp = s.Substring(iter, nLen);
                        if (!dic.ContainsKey(s.Substring(iter, nLen))) {
                            break;
                        }
                        if (array[iterDic[strTemp]] < dic[strTemp]) {
                            array[iterDic[strTemp]] = 1 + array[iterDic[strTemp]];
                        } else {
                            break;
                        }
                        iter += nLen;
                    }
                    if (array.Sum() == nMax) {
                        list.Add(i);
                        
                        int j = 1;
                        while (j < nLen && i + j + nLen <= s.Length)
                        {
                            if (!dic.ContainsKey(s.Substring(i + j, nLen)))
                            {
                                j ++;
                            }
                            else
                            {
                                break;
                            }
                        }
                        if (j == nLen)
                        {
                            array[iterDic[s.Substring(i, nLen)]] = array[iterDic[s.Substring(i, nLen)]] - 1;
                            iter = i + nLen*nMax;
                            i += nLen;
                        }
                        else
                        {
                            Array.Clear(array, 0, array.Length);
                            i += j;
                            iter = i;
                        }
                        
                    } else {
                        Array.Clear(array, 0, array.Length);
                        i++;
                        iter = i;
                    }
                }
            }
            return list;
        }
    }
}
