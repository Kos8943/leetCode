using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode.easy
{
    //找出最常公共前綴
    class _14LongestCommonPrefix
    {
        public string[] sampleStrArr = new string[] { "flower", "flow", "flight" };//範例字串陣列
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0 || strs == null) {
                return "";//如strs陣列為空值時直接回傳空字串
            } else if(strs.Length == 1)
            {
                return strs[0];//如strs陣列僅只有一個字串則直接回傳字串
            }

            string resStr = strs[0];//取得第一個字串
            int length = strs.Length;//取得陣列長度

            for(int i = 0; i < length; i++)
            {
                resStr = findCommonPrefix(resStr, strs[i]);//取得第1個字串與第i個字串的最長前綴,且將resStr改為方返回傳值

                if ("".Equals(resStr))//如與第i個字串無共用前綴,則中斷迴圈回傳空字串
                {
                    break;
                }
            }
            return resStr; //回傳resStr
        }

        //取得2字串的最長前綴
        protected string findCommonPrefix(string str1, string str2)
        {
            int length = Math.Min(str1.Length, str2.Length);//取得參數str1,str2兩者length較小的為迴圈最大數
            int index = 0;

            //當index小於length且str1,str2兩地的第index個字元相同時,繼續下個迴圈
            while (index < length && str1[index] == str2[index])
            {
                index++;
            }
            return str1.Substring(0, index);//回傳str1第0個~第index個的字元字串
        }
    }
}
