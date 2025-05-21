using System;
using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("amma", true)]
        [InlineData("bob", true)]
        [InlineData("tat", true)]
        [InlineData("mummy", false)]
        [InlineData("fluff", false)]
        [InlineData("omma", false)]
        [InlineData("suspicious", false)]
        public void IsPalindromeTest(string input, bool expected)
        {
            //Arrange
            var wordsmith = new PalindromeChecker();
            
            //Act
            var actual = wordsmith.CheckPalindrome(input);
            // Console.WriteLine($"Running test for: {input}");
            // Console.WriteLine($"Input: {input}, Expected: {expected}, Actual: {actual}");

            //Assert    
            Assert.Equal(expected, actual);

        }
    }
}
