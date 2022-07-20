using leetCode;
using leetCode.easy;
using System;

namespace ConsoleApp3
{
    
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 1, 2 };
            _26RemoveDuplicates removeDuplicates = new _26RemoveDuplicates();

            int ans = removeDuplicates.RemoveDuplicates(nums);

            Console.WriteLine(ans);
            Console.ReadLine();
        }
    }
}
