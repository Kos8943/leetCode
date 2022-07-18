using leetCode;
using leetCode.easy;
using System;

namespace ConsoleApp3
{
    
    class Program
    {
        static void Main(string[] args)
        {
            _14LongestCommonPrefix longestStr = new _14LongestCommonPrefix();

            string ans = longestStr.LongestCommonPrefix(longestStr.sampleStrArr);

            Console.WriteLine(ans);
            Console.ReadLine();
        }
    }
}
