using System;
using Xunit;
using Xunit.Abstractions;

namespace MHSRedmindAssignment.Tests
{
    public class ATMTests
    {
        private readonly ITestOutputHelper Output;

        public ATMTests(ITestOutputHelper output)
        {
            Output = output;
        }
        [Fact]
        public void ATMDepositCheck_ShouldReturnCorrectValues()
        {
            //Arrange 
            bool expectedFirst = true;
            bool expectedSecond = true;
            bool expectedThird = false;
            bool expectedFourth = true;
            bool expectedFifth = false;
            bool expectedSixth = true;
            bool expectedSeventh = false;

            //Act
            bool actualFirst = Program.ATMDepositCheck(1500);
            bool actualSecond = Program.ATMDepositCheck(700);
            bool actualThird = Program.ATMDepositCheck(400);
            bool actualFourth = Program.ATMDepositCheck(1100);
            bool actualFifth = Program.ATMDepositCheck(1000);
            bool actualSixth = Program.ATMDepositCheck(700);
            bool actualSeventh = Program.ATMDepositCheck(300);

            //Assert
            Assert.Equal(expectedFirst, actualFirst);
            Assert.Equal(expectedSecond, actualSecond);
            Assert.Equal(expectedThird, actualThird);
            Assert.Equal(expectedFourth, actualFourth);
            Assert.Equal(expectedFifth, actualFifth);
            Assert.Equal(expectedSixth, actualSixth);
            Assert.Equal(expectedSeventh, actualSeventh);

            Output.WriteLine($"Expected: {expectedFirst} Actual: {actualFirst}");
            Output.WriteLine($"Expected: {expectedSecond} Actual: {actualSecond}");
            Output.WriteLine($"Expected: {expectedThird} Actual: {actualThird}");
            Output.WriteLine($"Expected: {expectedFourth} Actual: {actualFourth}");
            Output.WriteLine($"Expected: {expectedFifth} Actual: {actualFifth}");
            Output.WriteLine($"Expected: {expectedSixth} Actual: {actualSixth}");
            Output.WriteLine($"Expected: {expectedSeventh} Actual: {actualSeventh}");
        }
    }
}
