using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Algorithm_I.Easy
{
    public class SingleNumberClass
    {
        public static int SingleNumber(int[] nums)
        {
            int i = 0;
            int j = 0;
            int result = nums[i];
            bool found;

            for (; i < nums.Length; i++)
            {
                result = nums[i];
                found = false;
                for (j =0; j < nums.Length; j++)
                {
                    if (i == j) continue;
                    if (result == nums[j])
                    {
                        found = true;
                        break;
                    }
                }

                if (!found) return result;
            }

            return result;
        }
    }
}
