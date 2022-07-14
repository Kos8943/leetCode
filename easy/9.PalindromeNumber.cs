using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode
{
    public class _9PalindromeNumber
    {
        public bool IsPalindrome(int x)
        {
            char[] nums = x.ToString().ToArray();
            int left = 0, right = nums.Length - 1;
            while (left < right)
            {
                if (nums[left] != nums[right]) return false;
                left++;
                right--;
            }
            return true;
        }
    }
}
