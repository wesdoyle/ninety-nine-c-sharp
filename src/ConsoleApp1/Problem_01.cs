using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp99Problems //Get the last number in a list
{
    public class Problem_01
    {
        public static void Execute(string[] args)
        {
            Console.WriteLine("Problem 1: Get the last element of a list.");
            Console.WriteLine("//////////////////////////////////////////////////////// ");
            Console.Write("Input a list of comma separated integers to form a list: ");

            try
            {
                var input = Console.ReadLine();

                List<int> listOfNumbers = input.Split(',').Select(int.Parse).ToList();

                int n = Convert.ToInt32(input);

                for (int i = 1; i <= n; i++)
                {
                    listOfNumbers.Add(i);
                }

                var finalNumber = listOfNumbers.Last();

                Console.WriteLine("The final number is: " + finalNumber.ToString());
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
