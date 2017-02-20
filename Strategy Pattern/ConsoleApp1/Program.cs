using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsoleApp1.Repository;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double[] valuesArray = { 1,2,3,4,5,6,7,8,9 };
            List<double> valuesList = valuesArray.ToList();
            Console.WriteLine("Welcome to the Stategy Design Pattern!");
            Calculator Calculator = new Calculator();
            Console.WriteLine(Calculator.CalculateAverageFor(valuesList, new AverageByMean()));
            Console.WriteLine(Calculator.CalculateAverageFor(valuesList, new AverageByMedian()));
            Console.ReadKey();
        }
    }
}
