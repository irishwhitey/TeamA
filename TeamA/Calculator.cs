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

                var num1 = numbers[0];
                var num2 = numbers[1];

                return num1 + num2;
            }
            catch (Exception ex)
            {
                return 0;
            }
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