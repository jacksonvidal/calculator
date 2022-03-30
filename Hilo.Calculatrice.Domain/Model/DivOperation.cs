using System;

namespace Hilo.Calculatrice.Domain.Model
{
    public class DivOperation : IOperation
    {
        public decimal ExecuteOperation(decimal operand1, decimal operand2)
        {
            if (operand2 == 0)
                throw new DivideByZeroException("Can't divide by zero");

            return operand1 / operand2;
        }
    }
}
