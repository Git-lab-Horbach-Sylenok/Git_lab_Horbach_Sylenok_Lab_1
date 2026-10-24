using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_Calculator
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            ICalculator calculator = new Calculator();

            Console.Write("Введіть вираз (наприклад, 1 + 5 * 8): ");
            string expression = Console.ReadLine();

            try
            {
                double result = calculator.EvaluateExpression(expression);
                Console.WriteLine($"Результат: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка: {ex.Message}");
            }
        }
    }
}
