using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp99Problems //Get the nth number in a list 
{
    public class Problem_03
    {
        public static void Execute(string[] args)
        {
            Console.WriteLine("Problem 3: Get Nth element in a list.");
            Console.Write("Input a list of comma separated integers to form a list: ");

            try
            {
                var input = Console.ReadLine();

                List<int> listOfNumbers = input.Split(',').Select(int.Parse).ToList();

                bool listIsLongEnough = listOfNumbers.Count() > 1; 

                if (listIsLongEnough)
                {
                    Console.WriteLine("Input a number to find the number in your list which is indexed at this position.");
                    var k = Convert.ToInt32(Console.ReadLine()) - 1;

                    var kth = listOfNumbers.ElementAt(k);

                    Console.WriteLine("The number in position " + (k + 1) + " is: " + kth.ToString());
                    Console.WriteLine(Environment.NewLine);                    
                }
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
