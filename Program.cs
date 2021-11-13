using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitwisePalindrome_OrNot
{
    class Program
    {
        public static long reverseBits(long n)
        {
            long rev = 0;

            while (n > 0)
            {
                
                rev <<= 1;

                
                if ((n & 1) == 1)
                    rev ^= 1;

                
                n >>= 1;
            }

            
            return rev;
        }

        
        // is palindrome or not
        public static bool isPalindrome(long n)
        {
            long rev = reverseBits(n);

            return (n == rev);
        }

        
        public static void Main()
        {
            long n = 9;
            if (isPalindrome(n))
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
    }
}