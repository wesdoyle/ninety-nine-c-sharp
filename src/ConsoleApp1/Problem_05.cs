using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp99Problems //Reverse a list
{
    public class Problem_05
    {
        public static void Execute(string[] args)
        {
            Console.WriteLine("Problem 5: Reverse a list.");
            Console.Write("Input a list of comma separated integers to form a list: ");

            try
            {
                var input = Console.ReadLine();

                int n = Convert.ToInt32(input);

                List<int> listOfNumbers = new List<int>();

                for (int i = 1; i <= n; i++)
                {
                    listOfNumbers.Add(i);
                }

                var reverseList = string.Join(",", Enumerable.Reverse(listOfNumbers));

                Console.WriteLine("The reverse list is: " + reverseList);
                Console.WriteLine(Environment.NewLine);
            }

            catch
            {
                Console.WriteLine("Something went wrong. Let's try that again.");
                Console.WriteLine(Environment.NewLine);
                Execute(null);
            }
        }
    }
}
