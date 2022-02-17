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
        public static void FindMaxNum<T>( T Value1, T Value2, T Value3) where T : IComparable 
        {
            T[] array = new T[] { Value1, Value2, Value3 };
            Array.Sort(array);
            Console.WriteLine($"Max value is: {array[2]}");
        }
        
    }

}

