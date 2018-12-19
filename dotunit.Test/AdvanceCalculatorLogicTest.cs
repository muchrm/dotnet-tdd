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
            var _calculatorLogic = new Mock<ICalculatorLogic>();

            _calculatorLogic.Setup(f => f.Add(1,2)).Returns(3);

            AdvanceCalculatorLogic _advanceCalculatorLogic = new AdvanceCalculatorLogic(_calculatorLogic.Object);
            
            Assert.Equal(6, _advanceCalculatorLogic.AddTwice(1, 2));
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
