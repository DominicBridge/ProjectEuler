using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler6
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumOfSquares = 0;
            int Sums = 0;

            for(int i = 0; i <= 100; i++) //Loop through first 100 Natural Numbers
            {
                Sums += i; //Add new number to total;
                sumOfSquares += (i * i); // Add the squared total
            }

            Console.WriteLine(((Sums * Sums) - sumOfSquares).ToString());
            Console.ReadLine();
        }
    }
}
