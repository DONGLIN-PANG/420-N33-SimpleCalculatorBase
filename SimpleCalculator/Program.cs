using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using calculatorEnging.Dll

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Class to convert user input
                InputConverter inputConverter = new InputConverter();

                //Class to perform actual calculations
                CalculatorEngine calculatorEngine = new CalculatorEngine();
         

                double firstNumber = inputConverter.ConvertInputToNumeric(Console.ReadLine());
                double secondNumber = inputConverter.ConvertInputToNumeric(Console.ReadLine());
                string operation = Console.ReadLine();

                static double CheckNum(string num)
                try
                {
                    double firstNumber = double.Parse(num);
                    return firstNumber;
                    double secondNumber = double.Parse(num);
                    return secondNumber;
                }
                catch (Exception e)
                {
                    Console.WriteLine("You should enter a number, not a symbol, words or letters：");
                    string operation = Console.ReadLine();
                    return CheckNum(str);
                }
                Console.WriteLine("enter '+' or 'plus' to indicate your operation, such as: "+firstNumber+operation+secondNumber) ;
                double result = calculatorEngine.Calculate(operation, firstNumber, secondNumber);

                Console.WriteLine(myResult);
                
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
