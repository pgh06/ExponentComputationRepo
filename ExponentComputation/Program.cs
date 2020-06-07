using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExponentComputation
{
    class Program
    {
        public static int ComputePower(int baseNumber, int exponent)
        {
            var result = 1;

            for (var i = 0; i < exponent; i++)
            {
                result *= baseNumber;
            }

            return result;
        }

        static void Main(string[] args)
        {
            var result = ComputePower(2, 8);

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
