using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp99Problems //Duplicate the elements of a list
{
    public class Problem_14
    {
        public static void Execute(string[] args)
        {
            Console.WriteLine("Problem 14: Duplicate elements of a list.");
            Console.Write("Input a list of integers : ");
            try
            {
                var input = Console.ReadLine();
                List<int> list = input.Split(',').Select(int.Parse).ToList();

                var duplicatedList = list.SelectMany(x => Enumerable.Repeat(x, 2)).ToList();

                Console.WriteLine("Duplicated list: (" + string.Join(",", duplicatedList) + ")");
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
