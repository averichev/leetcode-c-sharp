using System;
using LeetCode.TwoSum.Solutions._1;
using Xunit;

namespace Test.TwoSum
{
    public class Solution1Test
    {
        [Fact]
        public void TwoSumTest()
        {
            var solution = new Solution();
            var result = solution.TwoSum(new[] {2, 7, 11, 15}, 9);
            Array.Sort(result);
            Assert.True(result.Length == 2);
            Assert.True(result[0] == 0);
            Assert.True(result[1] == 1);
        }

        [Fact]
        public void TwoSumTest2()
        {
            var solution = new Solution();
            var result = solution.TwoSum(new[] {3, 2, 4}, 6);
            Array.Sort(result);
            Assert.True(result.Length == 2);
            Assert.True(result[0] == 1);
            Assert.True(result[1] == 2);
        }

        [Fact]
        public void TwoSumTest3()
        {
            var solution = new Solution();
            var result = solution.TwoSum(new[] {3, 3}, 6);
            Array.Sort(result);
            Assert.True(result.Length == 2);
            Assert.True(result[0] == 0);
            Assert.True(result[1] == 1);
        }

        [Fact]
        public void TwoSumTest4()
        {
            var solution = new Solution();
            var result = solution.TwoSum(new[] {2, 5, 5, 11}, 10);
            Array.Sort(result);
            Assert.True(result.Length == 2);
            Assert.True(result[0] == 1);
            Assert.True(result[1] == 2);
        }
    }
}