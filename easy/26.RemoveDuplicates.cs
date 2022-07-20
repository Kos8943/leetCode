using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode.easy
{
    //刪除數字陣列中重複的數,並回傳修改後的陣列長度
    class _26RemoveDuplicates
    {
        int[] nums = new int[] { 1, 1, 2 };//範例陣列
        public int RemoveDuplicates(int[] nums)
        {
            int length = nums.Length;//取得陣列長度      
            if(length == 0)//陣列長度文0回傳0並中斷含式
            {
                return 0;
            }
            int i = 1;//用來判斷第i個與第i-1個得值是否相同
            int j = 1;//用來記下可替換不一樣值的陣列位置
            while(i < length)//當i小於陣列長度時進行迴圈
            {
                if(nums[i] != nums[i - 1])//當陣列第i個與第i-1不一樣時
                {
                    nums[j] = nums[i];//第nums[j]個改為nums[i]
                    ++j;
                }
                ++i;
            }
            return j;
        }
    }
}
