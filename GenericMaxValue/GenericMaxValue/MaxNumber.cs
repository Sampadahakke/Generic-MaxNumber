using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMaxValue
{
    internal class MaxNumber<T> where T : IComparable
    {
         private T[] array;
          
        public MaxNumber(T[] array)
        {
            this.array=array;
        }

        //Method Used To Find Integer Max Number 
        public void FindMaxNum( T Value1, T Value2, T Value3) 
        {
            
            Array.Sort(array);
            Console.WriteLine($"Max value is: {array[2]}");
            TestMax(array[0] = Value1, array[1] = Value2, array[2] = Value3);
            
        }

        
        
        public static T TestMax( T Value1, T Value2, T Value3)
        {
            if (Value1.CompareTo(Value2) >= 0 && Value1.CompareTo(Value2) >= 0)
                return Value1;
            else if (Value2.CompareTo(Value3) >= 0)
                return Value2;
            else
                return Value3;
        }
    }
        
}



