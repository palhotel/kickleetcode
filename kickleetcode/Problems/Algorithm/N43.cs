using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kickleetcode.Problems.Algorithm
{
    /// <summary>
    /// Multiply Strings
    /// </summary>
    class N43
    {
        public string Multiply(string num1, string num2)
        {
            if (num1 == "0" || num2 == "0") {
                return "0";
            }
            string result = "";
            string str1 = num1, str2 = num2;
            if (num1.Length < num2.Length) {
                str1 = num2;
                str2 = num1;
            }
            char[] resultArr = new char[num1.Length + num2.Length];
            Array.Clear(resultArr, 0, resultArr.Length);
            int k = resultArr.Length;
            int kIter = -1;
            int nPro = 0;
            for (int i = str2.Length - 1; i >= 0; i--) {
                int mult = str2[i] - '0';
                nPro = 0;
                kIter = 0;
                k--;
                if (mult == 0) {
                    continue;
                }
                for (int j = str1.Length - 1; j >= 0; j--) {
                    int cur = mult * (str1[j] - '0');
                    cur += nPro;
                    if (resultArr[k - kIter] == 0) {
                        resultArr[k - kIter] = '0';
                    }
                    resultArr[k - kIter] += (char)(cur % 10);
                    nPro = cur / 10 + (resultArr[k - kIter] - '0') / 10;
                    resultArr[k - kIter] = (char)((resultArr[k - kIter] - '0') % 10 + '0');
                    kIter++;
                }
                if (nPro > 0) {
                    resultArr[k - kIter] = (char)(nPro + '0');
                }
            }
            bool isOk = false;
            for (int i = 0; i < resultArr.Length; i++) {
                if (isOk) {
                    result += resultArr[i] > 0 ? resultArr[i] : '0';
                } else if (resultArr[i] > 0 && resultArr[i] != '0') {
                    isOk = true;
                    result += resultArr[i];
                }
            }
            return isOk ? result : "0";
        }
    }
}
