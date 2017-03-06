using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsoleApp1.Interfaces;

namespace ConsoleApp1.Repository
{
    public class Calculator
    {
        public double CalculateAverageFor(List<double> values, IAveragingMethod averageMethod)
        {
            return averageMethod.AverageFor(values);
        }
    }
}
