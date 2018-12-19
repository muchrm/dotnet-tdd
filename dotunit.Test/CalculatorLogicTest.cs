using System.Collections.Generic;
using Xunit;

namespace dotunit.Test
{
    public class CalculatorLogicTest
    {
        CalculatorLogic _calculatorLogic;
        public CalculatorLogicTest()
        {
            _calculatorLogic = new CalculatorLogic();
        }

        [Fact]
        public void TestAdd()
        {
            int a = 1;
            int b = 2;
            int expected = 3;
            Assert.Equal(expected, _calculatorLogic.Add(a, b));
        }

        [Theory]
        [MemberData(nameof(MultiplyTestSet))]
        public void MultiplyTest(int a,int b,int expected)
        {
            Assert.Equal(expected, _calculatorLogic.Multiply(a, b));
        }

        public static List<object[]> MultiplyTestSet()
        {
            return new List<object[]>
            {
                new object[]
                {
                    2,
                    1,
                    2
                },
                new object[]
                {
                    2,
                    2,
                    4
                }
            };
        }
    }
}
