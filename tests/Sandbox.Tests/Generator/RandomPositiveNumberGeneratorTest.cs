using Sandbox.WebAPI.Generator;
using Xunit;

namespace Sandbox.Tests.Generator
{
    public class RandomPositiveNumberGeneratorTest
    {
        private readonly RandomPositiveNumberGenerator _generator;

        public RandomPositiveNumberGeneratorTest()
        {
            _generator = new RandomPositiveNumberGenerator();
        }

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(2)]
        public void ShouldReturnTheSameQuantityRequestedToBeGenerated(int quantity)
        {
            var numbers = _generator.Generate(quantity);
            Assert.Equal(quantity, numbers.Count);
        }

        [Fact]
        public void ShouldReturnOnlyPositiveNumbers()
        {
            var numbers = _generator.Generate(10);

            Assert.All(numbers, n => Assert.True(n >= 0));
        }
    }
}