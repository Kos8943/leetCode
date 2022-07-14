using leetCode;
using leetCode.easy;
using System;

namespace ConsoleApp3
{
    
    class Program
    {
        static void Main(string[] args)
        {
            _13RomanToInteger romanConvert = new _13RomanToInteger();
            int ans = romanConvert.romanToInt("III");

            Console.WriteLine(ans);
            Console.ReadLine();
        }




    }
}
