namespace FizzBuzzTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(15, "FizzBuzz")]
        [InlineData(3, "fizz")]
        [InlineData(5, "buzz")]
        [InlineData(20, null)]
        public void FizzBuzzTest(int number)
        {
            var fizzBuzz = new FizzBuzzChallenge();
        }
    }
}