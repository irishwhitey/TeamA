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
            if (problem.Contains("^"))
            {
                var result = problem.Split("^");
                var pow = Math.Pow(double.Parse(result[0]), double.Parse(result[1]));
                return Convert.ToDecimal(pow);
            }
            return -1;
        }
    }
}