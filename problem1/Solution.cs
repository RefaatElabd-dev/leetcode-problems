using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem1
{
    public class Solution
    {
        public static IList<IList<int>> GroupThePeople(int[] groupSizes)
        {
            var dic = new Dictionary<int, List<int>>();
            var result = new List<IList<int>>();
            for (int i = 0; i < groupSizes.Length; i++)
            {
                if (!dic.ContainsKey(groupSizes[i]))
                {
                    dic.Add(groupSizes[i], new List<int>(groupSizes[i]));
                }
                dic[groupSizes[i]].Add(i);

                if(dic[groupSizes[i]].Count == groupSizes[i])
                {
                    result.Add(dic[groupSizes[i]]);
                    dic.Remove(groupSizes[i]);
                }
            }

            return result;
        }
    }
}
