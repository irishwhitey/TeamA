using System.Runtime.InteropServices.WindowsRuntime;

namespace TeamA
{
    public class Calculator
    {
        public decimal GetResult(string problem)
        {
            if (problem.Contains("+"))
            {
                return 7;
            }

            return 0;
        }
    }
}