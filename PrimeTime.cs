using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ReverseString
{
    class PrimeTime
    {
        function PrimeTime(num)
        {
            for (let i = 2; i < num; i++)
            {
                if (num % i === 0)
                {
                    return false
                }
            }
            return true;
        }
    }
}
