using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
  public  class Poker
    {
        public List<int> GetPoker(int count)
        {
            List<int> result = new List<int>();
            try
            {
                //新增N筆資料
                for (int i = 0; i < count; i++)
                {
                    result.Add(i);
                }

                //模擬發牌

                for (int i = count - 2; i > 0; i--)
                {
                    int lastindex = i + 1;
                    int randomindex = (new Random()).Next(i) ; //抽牌
                    //交換
                    int temp = result[lastindex];
                    result[lastindex] = result[randomindex];
                    result[randomindex] = temp;

                }


            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.ToString());
                throw;
            }
            return result;
        }
    }
}
