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
            bool flag = true;

            while (flag)
            {
                Console.WriteLine("\nMaximum Value: \n1.Integer Values \n2.Float Values \n3.String Values \n4.Exit");
                Console.Write("Please Enter Your Choice = ");
                int Choice=Convert.ToInt32(Console.ReadLine());
                //Using Switch Case For Option Entered By User
                switch(Choice)
                {
                    case 1:
                        TestCases.IntTest();
                        break;

                    case 2:
                        TestCases.FloatTest();
                        break;

                    case 3:
                        TestCases.StringTest();
                        break;

                    case 4:
                        flag = false;
                        break;

                    default:
                        Console.WriteLine("Invlid Choice");
                        break;

                }

            }
        }
    }
}
