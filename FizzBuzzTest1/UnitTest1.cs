using FizzBuzzChallenge;

namespace FizzBuzzTest1
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(15, "fizzbuzz")]
        [InlineData(3, "fizz")]
        [InlineData(5, "buzz")]
        [InlineData(20, "buzz")]
        

        public void FizzBuzzTest(int number, string expected)
        {
            var fizzBuzz = new FizzBuzz();

            var actual = fizzBuzz.FizzBuzzChallenge(number);

            Assert.Equal(expected, actual);
            //throw new NotImplementedException();
        }
    }
}