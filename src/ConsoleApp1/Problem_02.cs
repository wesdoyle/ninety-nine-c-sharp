using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp99Problems //Get the second-to-last number in a list
{
    public class Problem_02
    {
        public static void Execute(string[] args)
        {
            Console.WriteLine("Problem 2: Get the penultimate element in a list.");
            Console.WriteLine("//////////////////////////////////////////////////////// ");
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

                bool listIsLongEnough = listOfNumbers.Count() > 1; 

                if (listIsLongEnough)
                {
                    var penultimateNumber = listOfNumbers[listOfNumbers.Count-2];
                    Console.WriteLine("The penultimate number is: " + penultimateNumber.ToString());
                    Console.WriteLine(Environment.NewLine);
                }

                else
                {
                    Console.WriteLine("Input list must have more than a single element.");
                    Console.WriteLine(Environment.NewLine);
                    Execute(null);
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
