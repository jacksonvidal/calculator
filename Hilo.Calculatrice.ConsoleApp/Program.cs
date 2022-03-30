using Hilo.Calculatrice.Domain.Helpers;
using Hilo.Calculatrice.Domain.Model;
using System;

namespace Hilo.Calculatrice.ConsoleApp
{
    internal class Program
    {
        static void Main()
        {
            OperationEnum operationDsc;
            IOperation operation = null;
            string operand1;
            string operand2;

            try
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("############################## WELCOME TO YOUR CALCULATOR CONSOLE ################################################");

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"THE OPERATIONS CURRENTLY AVAILABLE ARE: { Calculator.GetAvailableOperations() }");

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write($"PLEASE, SELECT AN OPERATION: ");
                operationDsc = UserInterfaceHelper.SelectOperation(Console.ReadLine().ToUpper());

                Console.WriteLine($"\nYOU'RE ABOUT TO PERFORM A {operationDsc}\n");

                Console.Write($"PLEASE PROVIDE YOUR FIRST DECIMAL OPERAND: ");
                operand1 = Console.ReadLine();
                Console.Write($"PLEASE PROVIDE YOUR SECOND DECIMAL OPERAND: ");
                operand2 = Console.ReadLine();

                switch (operationDsc)
                {
                    case OperationEnum.SUBTRACTION:
                        operation = new SubOperation();
                        break;
                    case OperationEnum.DIVISION:
                        operation = new DivOperation();
                        break;
                }

                var calculator = new Calculator(operand1, operand2, operation);

                Console.WriteLine($"YOUR RESULT IS: {calculator.Calculate()}");

                Console.WriteLine("########################################################################################################################");
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{ex} \n\n");

                Console.ForegroundColor = ConsoleColor.White;
                Main();

            }
        }
    }
}