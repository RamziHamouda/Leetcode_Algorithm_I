using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Algorithm_I.Easy
{
    public class NumberOf1BitsClass
    {
        public int NumberOf1Bits(uint n)
        {

            var myBitArray = new BitArray(BitConverter.GetBytes(n));
            int result = 0;
            foreach (bool element in myBitArray)
            {
                if (element == true) result++;

            }

            return result;

        }
    }
}
