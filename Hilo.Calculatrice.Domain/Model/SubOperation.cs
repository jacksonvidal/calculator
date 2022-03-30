namespace Hilo.Calculatrice.Domain.Model
{
    public class SubOperation : IOperation
    {
        public decimal ExecuteOperation(decimal operand1, decimal operand2)
        {
            return operand1 - operand2;
        }
    }
}