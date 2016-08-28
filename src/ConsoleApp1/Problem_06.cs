using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp99Problems //Check whether or not a list is a palindrome
{
    public class Problem_06
    {
        public static void Execute(string[] args)
        {
            Console.WriteLine("Problem 6: Check whether or not a list is a palindrome.");
            Console.Write("Input a list of comma separated integers to form a list: ");

            try
            {
                var input = Console.ReadLine();
                List<int> listOfNumbers = input.Split(',').Select(int.Parse).ToList();
                Console.WriteLine(IsPalindrome(listOfNumbers));
            }

            catch
            {
                Console.WriteLine("Something went wrong. Let's try that again.");
                Console.WriteLine(Environment.NewLine);
                Execute(null);
            }

        }

        private static bool IsPalindrome(List<int> listOfNumbers)
        {
            int min = 0;
            int max = listOfNumbers.Count() - 1;

            while(true)
            {
                if (min > max)
                {
                    return true;
                }

                int a = listOfNumbers.ElementAt(min);
                int b = listOfNumbers.ElementAt(max);

                if (a != b)
                {
                    return false;
                }

                min++;
                max--;
            }
        }
    }
}
