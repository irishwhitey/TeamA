using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;

namespace TeamA
{
    public class Calculator
    {
        public decimal GetResult(string problem)
        {
            try
            {
                string[] splitProblem = problem.Split(new char[] { ' ' });

                var numbers = GetNumberComponents(splitProblem);
                var calcOperator = GetOperator(splitProblem)[0];

                switch (calcOperator)
                {
                    case "+":
                        return AddNumbers(numbers);
                    case "-":
                        return SubtractNumbers(numbers);
                    case "*":
                        return MultiplyNumbers(numbers);
                    case "/":
                        return DivideNumbers(numbers);
                }

                var result = AddNumbers(numbers);

                return result;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        private string[] GetOperator(string[] problemComponents)
        {
            IList<string> operators = new List<string>();

            foreach (var component in problemComponents)
            {
                decimal parseResult = 0;

                if (!decimal.TryParse(component, out parseResult))
                {
                    operators.Add(component);
                }
            }

            return operators.ToArray();
        }

        private decimal AddNumbers(decimal[] numbers)
        {
            return numbers.Select(num => num).Sum();
        }

        private decimal MultiplyNumbers(decimal[] numbers)
        {
            if (numbers.Length < 3)
            {
               return numbers[0] * numbers[1];
            }

            return 0;
        }

        private decimal DivideNumbers(decimal[] numbers)
        {
            if (numbers.Length < 3)
            {
                return numbers[0] / numbers[1];
            }

            return 0;
        }

        private decimal SubtractNumbers(decimal[] numbers)
        {
            var total = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                total -= numbers[i];
            }

            return total;
        }

        private decimal[] GetNumberComponents(string[] problemComponents)
        {
            IList<decimal> numbers = new List<decimal>();

            foreach (var component in problemComponents)
            {
                decimal parseResult = 0;

                if (decimal.TryParse(component, out parseResult))
                {
                    numbers.Add(parseResult);
                }
            }

            return numbers.ToArray();
        }


    }
}