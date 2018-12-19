using Moq;
using System.Collections.Generic;
using Xunit;

namespace dotunit.Test
{
    public class AdvanceCalculatorLogicTest
    {
        [Fact]
        public void AddTwiceTest()
        {
            int a = 1;
            int b = 2;
            int logicExpectedA = 1;
            int logicExpectedB = 2;
            int result = 3;
            int expected = 6;
            var _calculatorLogic = new Mock<ICalculatorLogic>();
            _calculatorLogic.Setup(f => f.Add(It.Is<int>(numa => numa == logicExpectedA), It.Is<int>(numb => numb == logicExpectedB)))
                            .Returns(result);

            AdvanceCalculatorLogic _advanceCalculatorLogic = new AdvanceCalculatorLogic(_calculatorLogic.Object);


            Assert.Equal(expected, _advanceCalculatorLogic.AddTwice(a, b));
        }

        [Theory]
        [MemberData(nameof(MultiplyTwiceTestSet))]
        public void MultiplyTwiceTest(int a, int b, int logicExpectedA, int logicExpectedB, int result, int expected)
        {
            var _calculatorLogic = new Mock<ICalculatorLogic>();
            _calculatorLogic.Setup(f => f.Multiply(It.Is<int>(numa => numa == logicExpectedA), It.Is<int>(numb => numb == logicExpectedB)))
                            .Returns(result);

            AdvanceCalculatorLogic _advanceCalculatorLogic = new AdvanceCalculatorLogic(_calculatorLogic.Object);
            Assert.Equal(expected, _advanceCalculatorLogic.MultiplyTwice(a, b));
        }

        public static List<object[]> MultiplyTwiceTestSet()
        {
            return new List<object[]>
            {
                new object[]
                {
                    2,
                    1,
                    2,
                    1,
                    2,
                    4
                },
                new object[]
                {
                    2,
                    2,
                    2,
                    2,
                    4,
                    8
                },
            };
        }

    }
}
