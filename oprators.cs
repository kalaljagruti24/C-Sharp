/* Name:- Kalal Jagruti Machhindra
   Class :- SYBCA(32) */
using System; 
namespace Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = 18, secondNumber = 5, result;
            int num1 = 20, num2 = 6, rem;
            result = firstNumber + secondNumber;
            Console.WriteLine(" Addition = {0} + {1} = {2}", firstNumber, secondNumber, result);

            result = firstNumber * secondNumber;
            Console.WriteLine(" Multiplication = {0} * {1} = {2}", firstNumber, secondNumber, result);

            result = firstNumber / secondNumber;
            Console.WriteLine(" Division = {0} / {1} = {2}", firstNumber, secondNumber, result);

            result = firstNumber - secondNumber;
            Console.WriteLine(" Subraction = {0} - {1} = {2}", firstNumber, secondNumber, result);

        }
    }
}
