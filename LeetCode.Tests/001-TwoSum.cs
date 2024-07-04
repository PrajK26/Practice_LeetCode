using Xunit;

namespace LeetCode.Tests;

public class TwoSumTest
{
    [Theory]
    [InlineData(new[] { 2, 7, 11, 15 }, 9, new[] { 0, 1})]
    [InlineData(new[] { 3, 2, 4}, 6, new[] { 1, 2 })]
    [InlineData(new[] { 3, 3}, 9, new[] { 0, 1})]
    public void TwoSum_Ordered(int[] nums, int target, int[] output)
    {
        //act
        var obj = new TwoSum();
        var result = obj.GetResult(nums, target);

        //assert
        Assert.Equal(output.Length, result.Count());
        Assert.Equal(output[0], result[0]);
        Assert.Equal(output[1], result[1]);
    }
}

