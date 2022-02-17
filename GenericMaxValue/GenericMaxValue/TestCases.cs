using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMaxValue
{
    internal class TestCases
    {
        public static readonly int[] IntCase1;
        public static readonly int[] IntCase2;
        public static readonly int[] IntCase3;

        
        static TestCases()
        {
            IntCase1 = new int[] { 8, 10, 2 };
            IntCase2 = new int[] { 2, 40, 50 };
            IntCase3 = new int[] { 50, 30, 20 };
        }

        public static string GetString<T>(T[] testCase)
        {
            return $"[{testCase[0]}, {testCase[1]}, {testCase[2]}]";
        }
    }
}
