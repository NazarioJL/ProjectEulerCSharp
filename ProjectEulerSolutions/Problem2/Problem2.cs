﻿using System;

namespace Problem2
{
    class Problem2
    {
        static void Main()
        {
            // Each new term in the Fibonacci sequence is generated by adding the previous two terms. By starting with 1 and 2, the first 10 terms will be:
            //
            //                                                      1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
            //
            // By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.
            //
            // First, just as a comment, the Fib sequence grows VERY quickly. We actually only need to get to F-34 in order to exceed four million, so a brute
            // force method here will work perfectly. I'm going to though improve on that and only calculate the even numbers, as described by the problem.
            //
            // Examining a proper Fib sequence:
            //                  1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89
            //
            // You notice the pattern that every 3rd number is even starting at F-3, so if we can express F-n in terms of F-(n-3), F(n-6) then we only have to deal with even numbers.
            // 
            // To jump the derivation and just get down to the goregous equation...
            //                  F-N = F(N-1) + F(N-2) = 4 * F(N-3) + F(N-6)
            //
            // We can use this to not have to calculate the odd numbers is our solution.

            long fib3 = 2;
            long fib6 = 0;
            long fibN = 2;
            long summed = 0;

            while (fibN < 4000000)
            {
                summed += fibN;

                fibN = 4*fib3 + fib6;
                fib6 = fib3;
                fib3 = fibN;
            }

            Console.WriteLine("The result of all even numbered Fib numbers less than 4 million: "+summed);
            Console.ReadLine();
        }
    }
}
