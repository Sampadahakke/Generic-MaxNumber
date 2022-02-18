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

        private static MaxNumber<int> maxInt;
        private static MaxNumber<float> maxFloat;
        private static MaxNumber<string> maxString;

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

        //Mrthod Used To Find Max Integer Value
        public static void IntTest()
        {
            Console.WriteLine("Test Case 1:" +GetString(IntCase1));
            maxInt.FindMaxNum(IntCase1[0],IntCase1[1],IntCase1[2]);
            Console.WriteLine("Test Case 2:" + GetString(IntCase2));
            maxInt.FindMaxNum(IntCase2[0],IntCase2[1],IntCase2[2]);
            Console.WriteLine("Test Case 3:" +GetString(IntCase3));
            maxInt.FindMaxNum(IntCase3[0],IntCase3[1],IntCase3[2]);
            Console.ReadKey();
        }

        //Method Used To Find Max Float Value
        public static void FloatTest()
        {
            Console.WriteLine("Test Case 1:" + GetString(FloatCase1));
            maxFloat.FindMaxNum(FloatCase1[0], FloatCase1[1], FloatCase1[2]);
            Console.WriteLine("Test Case 2:" + GetString(FloatCase2));
            maxFloat.FindMaxNum(FloatCase2[0], FloatCase2[1], FloatCase2[2]);
            Console.WriteLine("Test Case 3:" + GetString(FloatCase3));
            maxFloat.FindMaxNum(FloatCase3[0], FloatCase3[1], FloatCase3[2]);
            Console.ReadKey();

        }

        //Method Used To Find Max String
        public static void StringTest()
        {
            Console.WriteLine("Test Case 1:" + GetString(StringCase1));
            maxString.FindMaxNum(StringCase1[0], StringCase1[1], StringCase1[2]);
            Console.WriteLine("Test Case 2:" + GetString(StringCase2));
            maxString.FindMaxNum(StringCase2[0], StringCase2[1], StringCase2[2]);
            Console.WriteLine("Test Case 3:" + GetString(StringCase3));
            maxString.FindMaxNum(StringCase3[0], StringCase3[1], StringCase3[2]);
            Console.ReadKey();
        }

    }
}
