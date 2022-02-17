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
        public static readonly float[] FloatCase1;
        public static readonly float[] FloatCase2;
        public static readonly float[] FloatCase3;
        public static readonly string[] StringCase1;
        public static readonly string[] StringCase2;
        public static readonly string[] StringCase3;

        //Initialization
        static TestCases()
        {
            IntCase1 = new int[] { 8, 10, 2 };
            IntCase2 = new int[] { 2, 40, 50 };
            IntCase3 = new int[] { 50, 30, 20 };
            FloatCase1 = new float[] { 2.5f, 3.8f, 4.5f };
            FloatCase2 = new float[] { 9.6f, 5.5f, 2.8f };
            FloatCase3 = new float[] { 5.6f, 10.5f, 2.6f };
            StringCase1 = new string[] { "Sampada", "Shubhada", "Venkatesh" };
            StringCase2 = new string[] { "Pen", "Scale", "Eraser" };
            StringCase3 = new string[] { "Rose", "Lotus", "Jasmine" };
        }

        public static string GetString<T>(T[] testCase)
        {
            return $"[{testCase[0]}, {testCase[1]}, {testCase[2]}]";
        }
    }
}
