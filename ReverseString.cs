using System;

namespace ReverseString
{
    class ReverseString
    {
        public static string Reversal(string str)
        {
            char[] strArray = str.ToCharArray();

            string reversal = "";

            for (int i = strArray.Length - 1; i > -1; i--)
            {
                reversal += strArray[i];
            }
            return reversal;

        }

        static void Main()
        {
            Console.WriteLine(Reversal(Console.ReadLine()));
        }
    }
}
