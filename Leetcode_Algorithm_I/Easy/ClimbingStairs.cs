namespace Leetcode_Algorithm_I.Easy
{
    internal class ClimbingStairsClass
    {
        public int ClimbingStairs(int n)
        {
            /* What is Fibonacci and why it's solution
             for this problem in this article
            https://dev.to/alisabaj/the-climbing-staircase-problem-how-to-solve-it-and-why-the-fibonacci-numbers-are-relevant-3c4o
            */

            // recursive solution: (but gave timeout in Leetcode)
            //if(n == 1 || n == 2) return n;
            //return ClimbStairs(n-1) + ClimbStairs(n-2);

            if (n == 1 || n == 2) return n;
            int[] result = new int[n];
            result[0] = 1;
            result[1] = 2;

            for (int i = 2; i < n; i++)
            {
                result[i] = result[i - 1] + result[i - 2];
            }

            return result[n - 1];
        }
    }
}
