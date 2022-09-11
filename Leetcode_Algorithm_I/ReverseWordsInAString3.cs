using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Algorithm_I
{
    internal class ReverseWordsInAString3
    {
        public string ReverseWords(string s)
        {
            string sb = "";
            string word = "";
            foreach (char c in s)
            {
                if (char.IsWhiteSpace(c))
                {
                    var charArry = word.ToCharArray();
                    Array.Reverse(charArry);
                    sb += new string(charArry);
                    sb += c;
                    word = "";
                }
                else
                {
                    word += c;
                }
            }

            if (!string.IsNullOrEmpty(word))
            {
                var charArry = word.ToCharArray();
                Array.Reverse(charArry);
                sb += new string(charArry);
            }
            return sb;

        }
    }
}
