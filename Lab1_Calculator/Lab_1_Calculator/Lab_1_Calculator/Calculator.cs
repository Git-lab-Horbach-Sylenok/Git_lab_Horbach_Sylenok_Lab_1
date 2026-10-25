using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_Calculator
{
    public class Calculator : ICalculator
    {
        private readonly Dictionary<string, IOperation> _operations = new()
    {
        { "+", new Addition() },
        { "-", new Subtraction() },
        { "*", new Multiplication() },
        { "/", new Division() }
    };

        public double EvaluateExpression(string expression)
        {
            var tokens = expression.Split(' ');
            Stack<double> values = new Stack<double>();
            Stack<string> operators = new Stack<string>();

            foreach (var token in tokens)
            {
                if (double.TryParse(token, out double number))
                {
                    values.Push(number);
                }
                else if (_operations.ContainsKey(token))
                {
                    while (operators.Count > 0 && GetPriority(operators.Peek()) >= GetPriority(token))
                    {
                        Compute(values, operators.Pop());
                    }
                    operators.Push(token);
                }
            }

            while (operators.Count > 0)
            {
                Compute(values, operators.Pop());
            }

            return values.Pop();
        }

        private int GetPriority(string op)
        {
            return op switch
            {
                "+" or "-" => 1,
                "*" or "/" => 2,
                _ => 0
            };
        }

        private void Compute(Stack<double> values, string op)
        {
            if (values.Count < 2) throw new InvalidOperationException("Недостатньо операндів.");
            double b = values.Pop();
            double a = values.Pop();
            values.Push(_operations[op].Calculate(a, b));
        }
    }
}
