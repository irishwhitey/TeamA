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
                if (problem.Contains("^"))
                {
                    var splited = problem.Split("^");
                    var res2 = Math.Pow(double.Parse(splited[0]), double.Parse(splited[1]));
                    return Convert.ToDecimal(res2);
                }
                if (problem.Contains("+"))
                {
                    var splited = problem.Split("+");
                    return decimal.Parse(splited[0]) + decimal.Parse(splited[1]);
                }



            }
            catch (Exception e)
            {

            }
            return -99;

        }
    }
}
