namespace LeetCode.TwoSum.Solutions._2
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var result = new int[] { };
            var length = nums.Length;

            var leftCursor = 0;
            var rightCursor = length - 1;

            while (leftCursor < rightCursor)
            {
                var number1 = nums[leftCursor];
                var number2 = nums[rightCursor];
                var sum = number1 + number2;
                if (sum == target)
                {
                    return new[] {leftCursor, rightCursor};
                }

                for (int i = leftCursor + 1; i < length; i++)
                {
                    var innerNumber = nums[i];
                    sum = innerNumber + number1;
                    if (sum == target)
                    {
                        return new[] {leftCursor, i};
                    }
                    sum = innerNumber + number2;
                    if (sum == target)
                    {
                        return new[] {rightCursor, i};
                    }
                }
                leftCursor++;
                rightCursor--;
            }

            return result;
        }
    }
}