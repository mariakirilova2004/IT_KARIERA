using System;

namespace Zero_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 8;
            int[] nums = null;
            nums = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };

            R(nums, n, 1, "", 0);          
        }

        static void R(int[] nums, int n, int i, string sequence, int sum)
        {
            int flag = 1;
            if (i == n)
            {
                sum += nums[i - 1];
                if(sum == 0) Console.WriteLine(sequence + " " + nums[i - 1].ToString() + " " + sum);
                sum -= nums[i - 1];
                sum += -nums[i - 1];
                if (sum == 0) Console.WriteLine(sequence + " " + (-nums[i - 1]).ToString() + " " + sum);
                sum -= -nums[i - 1];
                return;
            }
            if (flag == 1)
            {
                flag = 2;
                sum += nums[i - 1];
                R(nums, n, i + 1, sequence + " " + (nums[i - 1]).ToString(), sum);
                sum -= nums[i - 1];
            }
            if (flag == 2)
            {
                flag = 1;
                sum += -nums[i - 1];
                R(nums, n, i + 1, sequence + " " + (-nums[i - 1]).ToString(), sum);
                sum -= -nums[i - 1];
            }
        }
    }
}