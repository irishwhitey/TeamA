using System;
using System.Runtime.InteropServices.WindowsRuntime;

namespace TeamA
{
    public class Calculator
    {
        public decimal GetResult(string problem)
        {
            string[] splitProblem = problem.Split(new char[] {' '});

            int num1 = int.Parse(splitProblem[0]);
            int num2 = int.Parse(splitProblem[2]);

            return num1 + num2;
        }
    }
}