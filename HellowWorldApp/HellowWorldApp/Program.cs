using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HellowWorldApp
{
    class Program
    {
        static void Main(string[] args)
        {

            double i = 9;
            double result = GetSquare(i);
            Console.WriteLine(result);
            Console.ReadLine();
        }
        
        private static double GetSquare(double aValue)
        {

            return aValue*aValue;
        
        }
    }
}
