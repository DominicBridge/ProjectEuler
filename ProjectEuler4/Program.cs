using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler4
{
    class Program
    {
        public static void Main(string[] args)
        {
            string Answer = GetAnswer();
            Console.WriteLine(Answer);
            Console.ReadLine();
        }

        public static string GetAnswer()
        {
            List<int> Palindromes = new List<int>();
            for (int x = 999; x > 99; x--)            
                for (int y = 999; y > 99; y--)                
                    if (Palindrome.IsPalindrome((x * y).ToString()) == true)                    
                        Palindromes.Add(x * y);
            
            return Palindromes.Max().ToString();
        }
    }


    public class Palindrome
    {
        public static bool IsPalindrome(string word)
        {
            word = word.ToLower(); // Make all the same case, doesn't apply to numbers

            var newStr = String.Join("", word.Where(char.IsLetterOrDigit)); // Remove anything that isn't a number
            int l = newStr.Length; // Get Length of new String
            var reverse = string.Empty;


            for (int i = l - 1; i >= 0; i--) // Loop throug backwards
            {
                reverse += newStr[i]; // create the new string backwards
            }

            if (newStr == reverse) //simply check if they're equal
                return true;
            else
                return false;
        }
    }
}
