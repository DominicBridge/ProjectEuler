using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler5
{
    class Program
    {
        static void Main(string[] args)
        {
            //I wayyyy overthought this initially, but after a quick break, it became abundantly simple, test them all at once!
            //If ANY are incorrect, go to the next number.
            int Number = 1;
          
            while(Number % 2 != 0 || Number % 3 != 0 || Number % 4 != 0 || Number % 5 != 0 || Number % 6 != 0 || Number % 7 != 0 ||
                Number % 8 != 0 || Number % 9 != 0 || Number % 10 != 0 || Number % 11 != 0 || Number % 12 != 0 || Number % 13 != 0 ||
                Number % 14 != 0 || Number % 15 != 0 || Number % 16 != 0 || Number % 17 != 0 || Number % 18 != 0 || Number % 19 != 0 ||
                Number % 20 != 0)
            {
                Number++;
            }

            Console.WriteLine(Number);
            Console.ReadLine();

        }
    }
}
