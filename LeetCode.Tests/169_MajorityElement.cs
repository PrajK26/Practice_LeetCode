using Xunit;

namespace LeetCode.Tests
{
	public class MajorityElementTest
	{
        [Theory]
        [InlineData(new[] { 3, 2, 3 }, 3)]
        [InlineData(new[] { 2, 2, 1, 1, 1, 2, 2 }, 2)]
        public void Test_MajorityElement(int[] nums, int output)
        {
            //act
            var obj = new MajorityElement();
            var result = obj.GetResult(nums);

            //assert
            Assert.Equal(output, result);
        }
    }
}

