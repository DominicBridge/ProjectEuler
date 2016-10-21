using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler2
{
    class Program
    {
        static void Main(string[] args)
        {
            int Calc = 0;

            int PrevNumber = 0; 
            int CurrentNumber = 1; // Starting number;
            
            while(CurrentNumber < 4000000) // Whilst CurrentNumber is under 4 million, carry on!
            {
                int current = CurrentNumber; // Just to keep a record of it before we change it.

                CurrentNumber = CurrentNumber + PrevNumber; // Add the previous numbers together & assign new number
                PrevNumber = current;   // Change the prev number, to the current
                if(current % 2 ==0) //Check if its even
                    Calc += current; //If so, Add to the calculator
            }
            
            Console.WriteLine(Calc);
            Console.ReadLine();
        }
    }
}
