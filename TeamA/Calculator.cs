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

                var result = AddNumbers(numbers);

                return result;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        private decimal AddNumbers(decimal[] numbers)
        {
            return numbers.Select(num => num).Sum();
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