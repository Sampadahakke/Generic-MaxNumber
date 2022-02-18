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
            IntCase1 = new int[] { 8, 10, 2, 5, 98, 20};
            IntCase2 = new int[] { 2, 40, 50 };
            IntCase3 = new int[] { 50, 30, 20 };
            FloatCase1 = new float[] { 2.5f, 3.8f, 4.5f };
            FloatCase2 = new float[] { 9.6f, 5.5f, 2.8f };
            FloatCase3 = new float[] { 5.6f, 10.5f, 2.6f };
            StringCase1 = new string[] { "Sampada", "Shubhada", "Venkatesh" };
            StringCase2 = new string[] { "Pen", "Scale", "Eraser" };
            StringCase3 = new string[] { "Rose", "Lotus", "Jasmine" };
            maxInt = new MaxNumber<int>(IntCase1);
            maxFloat = new MaxNumber<float>(FloatCase1);
            maxString = new MaxNumber<string>(StringCase1);
        }

        
        //Mrthod Used To Find Max Integer Value
        public static void IntTest()
        {
            Console.WriteLine("Test Case 1:");
            maxInt.FindMaxNum(IntCase1);  
            Console.WriteLine("\nTest Case 2:");
            maxInt.FindMaxNum(IntCase2);
            Console.WriteLine("\nTest Case 3:");
            maxInt.FindMaxNum(IntCase3);
            Console.ReadKey();
        }

        //Method Used To Find Max Float Value
        public static void FloatTest()
        {
            Console.WriteLine("Test Case 1:");
            maxFloat.FindMaxNum(FloatCase1);
            Console.WriteLine("\nTest Case 2:");
            maxFloat.FindMaxNum(FloatCase2);
            Console.WriteLine("\nTest Case 3:");
            maxFloat.FindMaxNum(FloatCase3);
            Console.ReadKey();

        }

        //Method Used To Find Max String
        public static void StringTest()
        {
            Console.WriteLine("Test Case 1:");
            maxString.FindMaxNum(StringCase1);
            Console.WriteLine("\nTest Case 2:");
            maxString.FindMaxNum(StringCase2);
            Console.WriteLine("\nTest Case 3:");
            maxString.FindMaxNum(StringCase3);
            Console.ReadKey();
        }

    }
}
