using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Algorithm_I.Medium
{
    internal class RotateArray
    {
        public static void Rotate(int[] nums, int k)
        {
            if (k == 0 || nums.Length == 1) return;

            while (k >= 1)
            {
                k--;

                int firstNumber = nums[0];
                nums[0] = nums[nums.Length - 1];

                for (var i = nums.Length - 2; i >= 1; i--)
                {
                    nums[i + 1] = nums[i];
                }

                nums[1] = firstNumber;
            }
        }

        // much much better solution (1¨% of time consumed by other solution)
        // when k is big
        public static void Rotate2(int[] nums, int k)
        {
            if (k == 0 || nums.Length == 1) return;

            int[] arr = (int[])nums.Clone();

            for (var i = 0; i < nums.Length; i++)
            {
                nums[(i + k) % arr.Length] = arr[i];
            }
        }


        /*
         var arr = new int[] {1,2,3,4,5,6,7 };
        RotateArray.Rotate2(arr, 3);
        Console.WriteLine("Result = /n");
        //arr.ForEach(x => Console.Write(x));
        Array.ForEach(arr, x => Console.Write(x));
        */
    }
}
