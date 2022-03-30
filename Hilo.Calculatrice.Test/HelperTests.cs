using Hilo.Calculatrice.Domain.Helpers;
using Hilo.Calculatrice.Domain.Model;
using System;
using Xunit;

namespace Hilo.Calculatrice.Test
{
    public class HelperTests
    {
        [Fact]
        public void EnsureThatSymbolsOfValidOperationsAreAccepted()
        {
            Assert.Equal(OperationEnum.SUBTRACTION, UserInterfaceHelper.SelectOperation("-"));
            Assert.Equal(OperationEnum.DIVISION, UserInterfaceHelper.SelectOperation("/"));
        }

        [Fact]
        public void EnsureThatDescriptionOfValidOperationsAreAccepted()
        {
            Assert.Equal(OperationEnum.SUBTRACTION, UserInterfaceHelper.SelectOperation("subtraction"));
            Assert.Equal(OperationEnum.DIVISION, UserInterfaceHelper.SelectOperation("division"));
        }

        [Fact]
        public void ErrorWhenInvalidOperationsAreInputed()
        {
            Assert.Throws<ArgumentException>(() => UserInterfaceHelper.SelectOperation("34853485743"));
            Assert.Throws<ArgumentException>(() => UserInterfaceHelper.SelectOperation("+"));
            Assert.Throws<ArgumentException>(() => UserInterfaceHelper.SelectOperation("something"));
        }
    }
}
