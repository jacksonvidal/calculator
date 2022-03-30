using System;
using System.Linq;

namespace Hilo.Calculatrice.Domain.Model
{
    public class Calculator
    {
        private readonly string _operand1;
        private readonly string _operand2;
        private readonly IOperation _operation;

        public Calculator(string operand1, string operand2, IOperation operation)
        {
            _operand1 = operand1;
            _operand2 = operand2;
            _operation = operation;
        }

        /// <summary>
        /// Performs the calculus
        /// </summary>
        /// <returns>the calculated result</returns>
        /// <exception cref="ArgumentException"></exception>
        public decimal Calculate()
        {
            if (!decimal.TryParse(_operand1, out decimal operand1))
                throw new ArgumentException("the first operand is not valid");

            if (!decimal.TryParse(_operand2, out decimal operand2))
                throw new ArgumentException("the second operand is not valid");


            return _operation.ExecuteOperation(operand1, operand2);
        }

        // I'm not really sure if that would be the responsability from the calculator to 
        // provide the list of available operations

        /// <summary>
        /// Provides a list of available operations
        /// </summary>
        /// <returns></returns>
        public static string GetAvailableOperations()
        {
            var availabeOperations = Enum.GetValues(typeof(OperationEnum)).Cast<OperationEnum>();

            return string.Join(", ", availabeOperations);
        }
    }
}