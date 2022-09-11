using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Algorithm_I
{
    internal class SquareOfASortedArray
    {
        public int[] SortedSquares(int[] nums)
        {
            List<int> L = nums.ToList();
            L = L.Select(x =>  x * x).ToList();
            L.Sort();
            return L.ToArray();
        }
    }
}
