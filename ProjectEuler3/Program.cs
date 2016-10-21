using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler3
{
    class Program
    {
        static void Main(string[] args)
        {
            int HighestPrimeFactor = 0;


            ulong Number = 600851475143;

            HighestPrimeFactor = Convert.ToInt32(maxfactor(Number));


            Console.WriteLine(HighestPrimeFactor);
            Console.ReadLine();
        }

        static private ulong maxfactor(ulong n)
        {
            unchecked
            {
                while (n > 3 && 0 == (n & 1)) n >>= 1;

                uint k = 3;
                ulong k2 = 9;
                ulong delta = 16;
                while (k2 <= n)
                {
                    if (n % k == 0)
                    {
                        n /= k;
                    }
                    else
                    {
                        k += 2;
                        if (k2 + delta < delta) return n;
                        k2 += delta;
                        delta += 8;
                    }
                }
            }

            return n;
        }
    }
}
