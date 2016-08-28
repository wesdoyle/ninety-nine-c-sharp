using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp99Problems //Eliminate consecutive duplicates in a list
{
    public class Problem_08
    {
        public static void Execute(string[] args)
        {
            Console.WriteLine("Problem 8: Eliminate consecutive duplicates in a list.");
            Console.WriteLine("//////////////////////////////////////////////////////// ");
            Console.Write("Input a list of integers : ");
            try
            {
                var input = Console.ReadLine();
                List<int> list = input.Split(',').Select(int.Parse).ToList();

                List<int> compressedList = CompressList(list);

                string compressedListString = string.Join(",", compressedList);

                Console.WriteLine("Compressed list: " + compressedListString);

                //Note that using LINQ Distinct() method would not necessarily work, because the goal is to
                //remove only consecutive dups.
            }

            catch
            {
                Console.WriteLine("Something went wrong. Let's try that again.");
                Console.WriteLine(Environment.NewLine);
                Execute(null);
            }

        }

        private static List<int> CompressList(List<int> list)
        {
            List<int> compressedList = new List<int>();
            int? previousNumber = null;

            foreach (int i in list)
            {
                if (previousNumber != i)
                {
                    compressedList.Add(i);
                }

                previousNumber = i;

            }

            return compressedList;
        }

    }
}
