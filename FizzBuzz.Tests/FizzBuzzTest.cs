using Xunit;

namespace FizzBuzzTests 
{
    public class FizzBuzzTests
    {
        [Fact]
        public void TestFizzBuzz()
        {
            var fizzBuzz = new FizzBuzz();

            Assert.Equal("1", fizzBuzz.GetFizzBuzzResult(1));
            Assert.Equal("Fizz", fizzBuzz.GetFizzBuzzResult(3));
            Assert.Equal("Buzz", fizzBuzz.GetFizzBuzzResult(5));
            Assert.Equal("FizzBuzz", fizzBuzz.GetFizzBuzzResult(15));
        }
    }
}

