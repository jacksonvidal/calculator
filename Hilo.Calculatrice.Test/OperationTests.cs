using Hilo.Calculatrice.Domain.Model;
using Xunit;

namespace Hilo.Calculatrice.Test
{
    public class OperationTests
    {
        [Fact]
        public void EnsureThatOperationDivisionRuns()
        {
            var divison = new DivOperation();

            Assert.Equal(2, divison.ExecuteOperation(10, 5));
        }

        [Fact]
        public void EnsureThatOperationSubstractionRuns()
        {
            var divison = new SubOperation();

            Assert.Equal(5, divison.ExecuteOperation(10, 5));
        }


    }
}
