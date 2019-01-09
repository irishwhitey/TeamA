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
                if (problem.Contains(" + ") && problem.Contains(" - "))
                {
                    var splitted = problem.Split(" ");
                    Operation _currentOperation = new Plus();
                    foreach (var item in splitted)
                    {
                        var fred = new Item(item);
                        if (fred.IsOperation())
                        {
                            _currentOperation = Factory.FromSymbol(item);
                        }
                        else
                        {
                            toReturn = _currentOperation.Calculate(toReturn, int.Parse(item));
                        }
                    }

                    return toReturn;
                }

                if (problem.Contains(" + "))
                {
                    var splitted = problem.Split("+");
                    for (int i = 0; i < problem.Length; i++)
                    {
                        toReturn = int.Parse(splitted[i]) +toReturn;
                    }

                    return toReturn;
                }

                if (problem.Contains(" - "))
                {
                    var splitted1 = problem.Split(" - ");
                    toReturn = int.Parse(splitted1[0]) - int.Parse(splitted1[1]);

                    return toReturn;
                }

                if (problem.Contains("*"))
                {
                    var splitted = problem.Split("*");
                    toReturn = int.Parse(splitted[0]) * int.Parse(splitted[1]);

                    return toReturn;
                }

                if (problem.Contains("/"))
                {
                    var splitted = problem.Split("/");
                    toReturn = int.Parse(splitted[0]) / int.Parse(splitted[1]);

                    return toReturn;
                }

                if (problem.Contains("^"))
                {
                    var splitted2 = problem.Split(" ^ ");
                    return (int) Math.Pow(int.Parse(splitted2[0]), int.Parse(splitted2[1]));
                    
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return toReturn;
        }
    }

    public interface Operation
    {
        int Calculate(int first, int second);
    }

    public class Plus :Operation
    {
        public int Calculate(int first, int second)
        {
            return first + second;
        }
    }

    public class Subtract : Operation 
    {
        public int Calculate(int first, int second)
        {
            return first - second;
        }
    }

    public class Factory
    {
        public static Operation FromSymbol(string item)
        {
            switch (item)
            {
                case "-": return new Subtract();
                    break;
                default:return new Plus();
                
            }
        }
    }

    public class Item
    {
        private readonly string _item;

        public Item(string item)
        {
            _item = item;
        }

        public bool IsOperation()
        {
            return _item == "+" || _item == "-" || _item == "*" || _item == "/";
        }
    }
}