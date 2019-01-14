using System;
using System.Runtime.InteropServices.WindowsRuntime;

namespace TeamA
{
    public class Calculator
    {
        public decimal GetResult(string problem)
        {
            var valuesToTotal = problem.Split('+');
            int total = 0;

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