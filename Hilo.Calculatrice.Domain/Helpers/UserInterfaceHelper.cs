using Hilo.Calculatrice.Domain.Model;
using System;

namespace Hilo.Calculatrice.Domain.Helpers
{
    public static class UserInterfaceHelper
    {
        /// <summary>
        /// threats the possible inputs for the operations accepting description or symbol
        /// </summary>
        /// <param name="operationInput">input operation</param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static OperationEnum SelectOperation(string operationInput)
        {
            OperationEnum selectedOperation;

            if (Enum.TryParse(operationInput.ToUpper(), out selectedOperation) || Enum.IsDefined(typeof(OperationEnum), operationInput))
                return selectedOperation;
            else
            {
                switch (operationInput)
                {
                    case "/":
                        selectedOperation = OperationEnum.DIVISION;
                        break;
                    case "-":
                        selectedOperation = OperationEnum.SUBTRACTION;
                        break;
                    default:
                        throw new ArgumentException("Operation provided is not valid");
                }
            }

            return selectedOperation;
        }
    }
}
