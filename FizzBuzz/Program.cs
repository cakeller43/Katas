using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {

            var v = FizzBuzz(15);
            foreach(object o in v)
                Console.WriteLine(o);
            Console.Read();
        }

        static object[] FizzBuzz(int upperBound)
        {
            object[] returnArray = new object[upperBound];
           
            if (upperBound < 1)
                return returnArray;

            for (int i = 1; i <= upperBound; i++)
            {
                
                if (i % 3 == 0)
                {
                    returnArray[i-1] += "Fizz";
                }
                if (i % 5 == 0)
                {
                    returnArray[i-1] += "Buzz";
                }
                if (returnArray[i-1] == null)
                {
                    returnArray[i-1] = i;
                }
            }
            return returnArray;

        }
           
    }
} 
