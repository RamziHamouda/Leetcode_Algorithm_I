using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Algorithm_I
{
    public class FirstBadVersion
    {
        private int badVersion;
        public FirstBadVersion()
        {
            
        }

        private bool IsBadVersion(int n)
        {
            if (n >= badVersion)
                return true;
            else
                return false;
        }

        public int BadVersion(int n, int badVersion)
        {
            this.badVersion = badVersion;

            List<int> arr = new();

            for (int i = 1; i < n+1; i++)
            {
                arr.Add(i);
            }

            int result = BadVersionHelp(arr);
            return result;
        }

        private int BadVersionHelp_Recursive(List<int> nums)
        {
            if (nums.Count == 0) return default;

            if (nums.Count == 1)
            {
                return nums[0];
            }

            // middle even [1,2,3,4] : 4/2 - 1 + 0 = 1
            // middle uneven [1,2,3,4,5] : 5/2 - 1 + 1= 2
            int middleIndex = nums.Count / 2 - 1 + nums.Count % 2;
            if (IsBadVersion(nums[middleIndex]))
            {
                if (middleIndex == 0 || IsBadVersion(nums[middleIndex - 1]) == false)
                    return nums[middleIndex];
                else
                {
                    // even [ 1,2,3,4 ] : Take(4/2 - 1) --) [1]
                    // uneven [1,2,3,4,5] : Take(5/2 - 1 + 1) --) [1,2]
                    return BadVersionHelp(nums.Take(nums.Count / 2 - 1 + nums.Count % 2).ToList());
                }
            }
            else
            {
                // even [ 1,2,3,4 ] : TakeLast(2) --) TakeLast(2) --) [3,4]
                // uneven [1,2,3,4,5] : TakeLast(5/2) --) TakeLast(2) --) [3,4]
                return BadVersionHelp(nums.TakeLast(nums.Count / 2).ToList());
            }
        }

        private int BadVersionHelp(List<int> nums)
        {
            while(nums.Count > 1)
            {
                // middle even [1,2,3,4] : 4/2 - 1 + 0 = 1
                // middle uneven [1,2,3,4,5] : 5/2 - 1 + 1= 2
                int middleIndex = nums.Count / 2 - 1 + nums.Count % 2;
                if (IsBadVersion(nums[middleIndex]))
                {
                    if (middleIndex == 0 || IsBadVersion(nums[middleIndex - 1]) == false)
                        nums = new List<int> { nums[middleIndex] };
                    else
                    {
                        // even [ 1,2,3,4 ] : Take(4/2 - 1) --) [1]
                        // uneven [1,2,3,4,5] : Take(5/2 - 1 + 1) --) [1,2]
                        nums = nums.Take(nums.Count / 2 - 1 + nums.Count % 2).ToList();
                    }
                }
                else
                {
                    // even [ 1,2,3,4 ] : TakeLast(2) --) TakeLast(2) --) [3,4]
                    // uneven [1,2,3,4,5] : TakeLast(5/2) --) TakeLast(2) --) [3,4]
                    nums = nums.TakeLast(nums.Count / 2).ToList();
                }
            }

            return nums[0];
        }
    }
}
