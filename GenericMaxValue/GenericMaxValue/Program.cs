using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMaxValue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("================Welcome To Generics-Max Number==================");

            Console.WriteLine("Test Case 1:" + TestCases.GetString(TestCases.IntCase1));
            MaxNumber.FindMaxNum(TestCases.IntCase1[0], TestCases.IntCase1[1], TestCases.IntCase1[2]);
            Console.WriteLine("Test Case 2:" + TestCases.GetString(TestCases.IntCase2));
            MaxNumber.FindMaxNum(TestCases.IntCase2[0], TestCases.IntCase2[1], TestCases.IntCase2[2]);
            Console.WriteLine("Test Case 3:" + TestCases.GetString(TestCases.IntCase3));
            MaxNumber.FindMaxNum(TestCases.IntCase3[0], TestCases.IntCase3[1], TestCases.IntCase3[2]);
            Console.ReadKey();
        }
    }
}
