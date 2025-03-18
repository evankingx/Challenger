using System;

class PrimeTime
{
    public static bool IsPrime(int num)
    {
        // Step 1: Handle edge cases
        if (num <= 1)
        {
            return false; // Numbers less than or equal to 1 are not prime
        }

        // Step 2: Check divisibility up to the square root of num
        for (int i = 2; i * i <= num; i++)
        {
            if (num % i == 0)
            {
                return false; // Found a divisor, so num is not prime
            }
        }

        // Step 3: If no divisors found, num is prime
        return true;
    }

    static void Main(string[] args)
    {
        // Example usage
        Console.WriteLine(IsPrime(2));  // Output: True
        Console.WriteLine(IsPrime(4));  // Output: False
        Console.WriteLine(IsPrime(17)); // Output: True
        Console.WriteLine(IsPrime(18)); // Output: False
    }
}
