using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_Week_4
{
    public class ParameterDemo
    {
        public int Increase(ref int number)
        {
             return number += 10;
        }

        public string GetFullName(out string fullName)
        {
            return fullName = "Suman Tamang";
        }

        public int SumAll(params int[] numbers)
        {
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            return sum;
        }
    }
}
