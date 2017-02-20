using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsoleApp1.Interfaces;

namespace ConsoleApp1.Repository
{
    public class AverageByMedian : IAveragingMethod
    {
        public double AverageFor(List<double> values)
        {
            // This obviously does not calculate the medium, the key thing was it produced a different number to the other method
            return values.Sum() / (values.Count + 1000);
        }
    }
}
