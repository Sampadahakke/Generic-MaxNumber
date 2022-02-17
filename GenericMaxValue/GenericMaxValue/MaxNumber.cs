using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMaxValue
{
    internal class MaxNumber
    {
        //Method Used To Find Integer Max Number
        public static void FindMaxNum( int num1, int num2, int num3)
        {
            if (num1.CompareTo(num2) >= 0 && num1.CompareTo(num2) >= 0)
                Console.WriteLine("Max Value is {0}", num1);
            else if (num2.CompareTo(num3) >= 0)
                Console.WriteLine("Max Value is {0}", num2);
            else
                Console.WriteLine("Max Value is {0}", num3);
        }
    }
}
