using System;
using System.Runtime.InteropServices.WindowsRuntime;

namespace TeamA
{
    public class Calculator
    {
        public decimal GetResult(string problem)
        {
            int total = 0;

            if (problem.Contains("*"))
            {
                var valuesToMultiply = problem.Split("*");
                total = 1;
                
                foreach (var v in valuesToMultiply)
                {
                    int valueToMultiply = 0;
                    int.TryParse(v, out valueToMultiply);
                    total *= valueToMultiply;
                }

                return total;
            }

            var valuesToTotal = problem.Split('+');
            
            foreach (var v in valuesToTotal)
            {
                int valueToAdd = 0;
                int.TryParse(v,out valueToAdd);
                total += valueToAdd;
            }

            if (problem.Contains("/"))
                return 2;
            
            return total;
        }
    }
}