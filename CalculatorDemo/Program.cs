using System;
using System.Collections.Generic;
namespace CalculateDemo
{
    class Program
    {
        /// <summary>
        /// Dictionary of the record method
        /// </summary>
        static Dictionary<string, string> cfg = new Dictionary<string, string>();
        static void Main(string[] args)
        {
            Load();
            while(true)
            {
                Console.Write("Please enter operand 1:");
                int x = int.Parse(Console.ReadLine());
                Console.Write("Please enter operand 2:");
                int y = int.Parse(Console.ReadLine());
                Console.Write("Please enter the operator:");
                string op = Console.ReadLine();
                Operator opr = OperatorFactory.Create(cfg[op]);
                opr.Left = x;
                opr.Right = y;
                int r = opr.Calc();
                Console.WriteLine($"{x}{op}{y}={r}");
            }
        }
        /// <summary>
        /// Initialization assignment
        /// </summary>
        static void Load()
        {
            cfg.Add("+", "CalculateDemo.AddOperator");
            cfg.Add("-","CalculateDemo.SubOperator");
            cfg.Add("*", "CalculateDemo.MulOperator");
            cfg.Add("/", "CalculateDemo.DivOperator");
        }
    }
}