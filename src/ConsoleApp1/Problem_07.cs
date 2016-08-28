using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp99Problems //Flatten a nested list
{
    public class Problem_07 
    {
        public static void Execute(string[] args)
        {
            Console.WriteLine("Problem 7: Flatten a nested list.");
            Console.WriteLine("//////////////////////////////////////////////////////// ");
            Console.WriteLine("Input a set of lists of comma separated integers to form a flattened list: ");
            Console.Write("List 1: ");
            try
            {
                var input_1 = Console.ReadLine();
                List<int> list_1 = input_1.Split(',').Select(int.Parse).ToList();

                Console.Write("List 2: ");
                var input_2 = Console.ReadLine();
                List<int> list_2 = input_2.Split(',').Select(int.Parse).ToList();

                Console.Write("List 3: ");
                var input_3 = Console.ReadLine();
                List<int> list_3 = input_3.Split(',').Select(int.Parse).ToList();

                List<List<int>> nestedList = new List<List<int>>();
                nestedList.Add(list_1);
                nestedList.Add(list_2);
                nestedList.Add(list_3);

                List<int> flatList = nestedList.SelectMany(i => i).ToList();

                string flatListString = string.Join(",", flatList);

                Console.WriteLine("Flattened Lists: " + flatListString);
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
