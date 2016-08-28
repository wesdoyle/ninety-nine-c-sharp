using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp99Problems //Pack consecutive duplicates of list elements into sublists
{
    public class Problem_09
    {
        public static void Execute(string[] args)
        {
            Console.WriteLine("Problem 9: Pack consecutive duplicates of list elements into sublists.");
            Console.Write("Input a list of integers : ");
            try
            {
                var input = Console.ReadLine();
                List<int> list = input.Split(',').Select(int.Parse).ToList();

                List<List<int>> packedList = PackList(list);
                var lastElementInPackedList = packedList[packedList.Count - 1];

                Console.Write("Packed list: (");
                foreach(List<int> set in packedList)
                {
                    Console.Write("(");
                    Console.Write(string.Join(",", set));

                    if (set != lastElementInPackedList)
                    {
                        Console.Write("),");
                    }

                    else
                    {
                        Console.WriteLine("))");
                    }
                }
            }

            catch
            {
                Console.WriteLine("Something went wrong. Let's try that again.");
                Console.WriteLine(Environment.NewLine);
                Execute(null);
            }
        }

        //Not at all elegant, but it works
        private static List<List<int>> PackList(List<int> sourceList)
        {
            List<List<int>> packedList = new List<List<int>>();
            List<int> subList = new List<int>();

            int? previousNumber = null;

            foreach (int i in sourceList)
            {
                if (previousNumber == null)
                {
                    subList.Add(i);
                }

                if (previousNumber == i)
                {
                    subList.Add(i);
                }

                if (previousNumber != null && previousNumber != i)
                {
                    packedList.Add(subList);
                    subList = new List<int>();
                    subList.Add(i);
                }

                previousNumber = i;
            }

            packedList.Add(subList);

            return packedList;
        }
    }
}
