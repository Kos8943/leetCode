using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode.easy
{
    class _13RomanToInteger
    {
        Dictionary<char, int> romanInt = new Dictionary<char, int> 
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 },
        };

        /// <summary>
        ///  羅馬數字轉成阿拉伯數字
        ///  <para>回傳:int</para>
        /// </summary>
        public int romanToInt(string s)
        {
            string romanStr = s.ToUpper();//轉成大寫
            int ans = 0;
            int length = romanStr.Length;

            try//用try catch處理不在Dictionary裡的例外
            {
                for (int i = 0; i < length; i++)
                {
                    
                    int value = romanInt[romanStr[i]];//取得第i個羅馬字對應到Dictionary的值

                    //當romanStr長度-1小於i成立時代表romanStr只有一個字
                    //當第i個romanStr的值小於第i+1個romanStr的值時,代表為減法
                    if (i < length - 1 && value < romanInt[romanStr[i + 1]])
                    {
                        ans -= value;
                    }
                    else
                    {
                        ans += value;
                    }
                }
            }
            catch
            {
                ans = 0;
            }
            
            return ans;
        }
    }
}
