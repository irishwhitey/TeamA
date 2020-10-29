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
                int.Parse(problem);

            }
            catch (Exception e)
            {

            }
            return -99;
        }
    }
}