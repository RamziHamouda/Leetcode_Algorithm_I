using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Algorithm_I.Easy
{
    internal class SearchInsertPosition
    {
        public int SearchInsert(int[] nums, int target)
        {
            //int insertIndex = -1;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target || nums[i] > target) return i;
            }

            return nums.Length;

            // Had the mistake of thinking I had to construct the array 
            // with the value inserted, why ? IDK, lack of concentration on the 
            // problem specifics
            //for(int i= nums.Length ; i > nums.Length; i--)
            //{
            //    nums[i] = nums[i - 1];
            //}

            //nums[insertIndex] = target;
        }

        // Solution that is dependent on already existing C# methods
        // stupid because it consumes a lot of memory and computation that
        // are unecessary
        public int SearchInsert_Easy(int[] nums, int target)
        {

            int index = nums.ToList().IndexOf(target);
            if (index != -1) return index;
            else
            {
                List<int> L = nums.ToList();
                L.Add(target);
                L.Sort();
                return L.IndexOf(target);
            }
        }
    }
}
