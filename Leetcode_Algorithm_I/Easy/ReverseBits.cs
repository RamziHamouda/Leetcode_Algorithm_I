using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Algorithm_I.Easy
{
    internal class ReverseBitsClass
    {
        public static uint reverseBits(uint n)
        {
            uint resultat = 0;

            var bits = 31;

            while(n != 0)
            {
                resultat += (n & 1) << bits;
                //only keep the first digit in n
                // move that digit to the outmost left, making it the biggest value

                n >>= 1; //the next smallest value will be the next digit on the left
                bits--; // that digit will be put behind the other already concatenated digits
            }

            Console.WriteLine("bits: "+ bits);
            Console.WriteLine("n: " + n);

            return resultat;
        }
    }
}
