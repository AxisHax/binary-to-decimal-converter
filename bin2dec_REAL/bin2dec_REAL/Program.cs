using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bin2dec_REAL
{
    class Program
    {
        // Function to check if input is binary number. WORKS!!!
        static bool isBin(string s)
        {
            foreach (var c in s)
            {
                if (c != '0' && c != '1')
                {
                    return false;
                }
            }
            return true;
        }

        // Function to convert BINARY to BASE 10 DECIMAL.
        static int BinToDec (string s)
        {
            string c;
            int i;
            int j = s.Length - 1;
            int binDigit;
            double calculation;
            double decOutput = 0;

            // 1. Iterate through Binary input and convert to int.
            // 2. Apply Bin to Dec calculation.
            for (i = 0; i < s.Length; i++)
            {
                c = s.Substring(j, 1);
                j--;
                binDigit = (int)Char.GetNumericValue(c[0]);
                calculation = binDigit * Math.Pow(2, i);
                decOutput += calculation;
            }

            return Convert.ToInt32(decOutput);
        }

        static void Main(string[] args)
        {
            string binInput;
            int decOutput;

            Console.Write("Please enter a binary number:");
            binInput = Console.ReadLine();
            
            if (isBin(binInput))
            {
                Console.WriteLine("You correctly entered a binary number. The number you entered was " + binInput + ".");
                Console.WriteLine("Converting...");
                Console.WriteLine("The BASE 10 representation of the number you entered is: " + BinToDec(binInput) + ".");
            }
            else
            {
                Console.WriteLine("You didn't enter a binary number. The number you entered was " + binInput + ".");
            }

            // To prevent the app from closing immediately.
            Console.ReadKey();
        }
    }
}
