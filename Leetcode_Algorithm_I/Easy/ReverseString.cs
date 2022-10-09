using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Algorithm_I.Easy
{
    internal class ReverseStringClass
    {
        public void ReverseString(char[] s)
        {
            int i = 0;
            int j = s.Length - 1;
            char p = ' ';

            while (i < j)
            {
                p = s[i];
                s[i] = s[j];
                s[j] = p;

                i++;
                j--;
            }
        }
    }
}
