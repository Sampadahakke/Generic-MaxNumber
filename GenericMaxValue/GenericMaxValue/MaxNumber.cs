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
        public void FindMaxNum(params T []array) 
        {
            this.array = array;
            Array.Sort(array);
            foreach ( T i in array)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine($"Max value is: {array[array.Length-1]}");
        }
    }
        
}



