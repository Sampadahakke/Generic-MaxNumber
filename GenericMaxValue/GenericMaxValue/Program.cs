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
            
            Console.WriteLine("\nTest Case 1:" + TestCases.GetString(TestCases.FloatCase1));
            MaxNumber.FindFloatMaxNum(TestCases.FloatCase1[0], TestCases.FloatCase1[1], TestCases.FloatCase1[2]);
            Console.WriteLine("Test Case 2:" + TestCases.GetString(TestCases.FloatCase2));
            MaxNumber.FindFloatMaxNum(TestCases.FloatCase2[0], TestCases.FloatCase2[1], TestCases.IntCase2[2]);
            Console.WriteLine("Test Case 3:" + TestCases.GetString(TestCases.FloatCase3));
            MaxNumber.FindFloatMaxNum(TestCases.FloatCase3[0], TestCases.FloatCase3[1], TestCases.FloatCase3[2]);
            Console.ReadLine();

            Console.WriteLine("\nTest Case 1:" + TestCases.GetString(TestCases.StringCase1));
            MaxNumber.FindStringMaxNum(TestCases.StringCase1[0], TestCases.StringCase1[1], TestCases.StringCase1[2]);
            Console.WriteLine("Test Case 2:" + TestCases.GetString(TestCases.FloatCase2));
            MaxNumber.FindStringMaxNum(TestCases.StringCase2[0], TestCases.StringCase2[1], TestCases.StringCase2[2]);
            Console.WriteLine("Test Case 3:" + TestCases.GetString(TestCases.StringCase3));
            MaxNumber.FindStringMaxNum(TestCases.StringCase3[0], TestCases.StringCase3[1], TestCases.StringCase3[2]);
            Console.ReadLine();












        }
    }
}
