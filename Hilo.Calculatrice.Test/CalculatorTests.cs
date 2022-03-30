using Hilo.Calculatrice.Domain.Model;
using System;
using Xunit;

namespace Hilo.Calculatrice.Test
{
    public class CalculatorTests
    {
        [Fact]
        public void EnsureThatCalculatorRunsSubstractionOperation()
        {
            Calculator calc = new Calculator("10", "5", new SubOperation());

            Assert.Equal(5, calc.Calculate());
        }


        [Fact]
        public void EnsureThatCalculatorRunsDivisonOperation()
        {
            Calculator calc = new Calculator("10", "5", new DivOperation());

            Assert.Equal(2, calc.Calculate());
        }


        [Fact]
        public void ErrorIfInputsAreNotNumbers()
        {
            Calculator calc = new Calculator("b", "s", new SubOperation());

            Assert.Throws<ArgumentException>(() => calc.Calculate());
        }

        [Fact]
        public void ErrorIfOneOfInputsAreNotNumbers()
        {
            Calculator calc = new Calculator("10", "s", new SubOperation());

            Assert.Throws<ArgumentException>(() => calc.Calculate());

            Calculator calc2 = new Calculator("b", "11", new SubOperation());

            Assert.Throws<ArgumentException>(() => calc2.Calculate());
        }

        [Fact]
        public void ErrorWhenDividedByZero()
        {
            Calculator calc = new Calculator("10", "0", new DivOperation());

            Assert.Throws<DivideByZeroException>(() => calc.Calculate());
        }

    }
}
