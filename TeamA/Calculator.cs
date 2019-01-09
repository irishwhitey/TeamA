using System;
using System.Runtime.InteropServices.WindowsRuntime;

namespace TeamA
{
    public class Calculator
    {
        public decimal GetResult(string problem)
        {
            var toReturn = 0;
            try
            {
                if (problem.Contains("+"))
                {
                    var splitted = problem.Split("+");
                    for (int i = 0; i < problem.Length; i++)
                    {
                        toReturn = int.Parse(splitted[i]) +toReturn;
                    }
                    
                    //var first = int.Parse(splitted[0]);
                    //var second = int.Parse(splitted[1]);

                    return toReturn;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return toReturn;



        }
    }
}