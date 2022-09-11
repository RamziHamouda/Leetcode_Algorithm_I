using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Algorithm_I
{
    internal class MoveZereos
    {
        public void MoveZeroes(int[] nums)
        {

            for (int i = 0; i < nums.Length; i++)
            {

                if (nums[i] != 0)
                {
                    if (i > 0 && nums[i - 1] == 0)
                    {
                        int j = i;
                        while (j > 0 && nums[j - 1] == 0)
                        {
                            var x = nums[j - 1];
                            nums[j - 1] = nums[j];
                            nums[j] = x;
                            j -= 1;
                        }
                    }
                }
            }

            Console.WriteLine(nums);

        }
    }
}
