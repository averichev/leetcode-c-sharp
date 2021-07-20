// https://leetcode.com/submissions/detail/525420222/
namespace LeetCode.TwoSum.Solutions._1
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var result = new int[] { };
            var length = nums.Length;

            for (var index1 = 0; index1 < length; index1++)
            {
                var number1 = nums[index1];
                for (var index2 = index1 + 1; index2 < length; index2++)
                {
                    var number2 = nums[index2];
                    var sum = number1 + number2;
                    if (sum == target)
                    {
                        return new[] {index1, index2};
                    }
                }
            }

            return result;
        }
    }
}