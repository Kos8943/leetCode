using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class TowSum
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int length = nums.Length;
            int offset = 0;

            for (int i = 0; i < length; i++)
            {
                offset = target - nums[i];
                for (int j = i + 1; j < length; j++)
                {
                    if (nums[j] == offset)
                    {
                        return new int[] { i, j };
                    }
                }
            }

            return new int[] { 0, 0 };
        }
    }
}
