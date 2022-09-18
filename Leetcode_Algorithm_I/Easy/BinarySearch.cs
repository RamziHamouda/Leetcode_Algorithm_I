using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Algorithm_I.Easy
{
    public class BinarySearch
    {

        public int Search_2(int target)
        {
            return 1;
        }

        public int Search(int[] nums, int target)
        {
            if (nums.Contains(target))
            {
                return Array.IndexOf(nums, target);
            }
            else
            {
                return -1;
            }
        }
    }
}
