namespace Hilo.Calculatrice.Domain.Model
{
    public interface IOperation
    {
        decimal ExecuteOperation(decimal operand1, decimal operand2);
    }
}
