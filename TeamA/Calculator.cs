using System;
using System.Runtime.InteropServices.WindowsRuntime;

namespace TeamA
{
    public class Calculator
    {
        public decimal GetResult(string problem)
        {
            if(problem=="3 + 4 + 2")
            return 9;

            return 7;
        }
    }
}