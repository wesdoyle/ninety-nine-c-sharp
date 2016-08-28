using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp99Problems //Run-length encoding of a list
{
    public class Problem_10
    {
        public static void Execute(string[] args)
        {
            Console.WriteLine("Problem 10: Encode the length of each packed sub-list into a new list");
            Console.Write("Input a list of integers : ");
            try
            {
                var input = Console.ReadLine();
                List<int> list = input.Split(',').Select(int.Parse).ToList();

                List<List<int>> packedList = PackList(list);
                var lastElementInPackedList = packedList[packedList.Count - 1];

                Console.Write("Packed list: (");
                foreach (List<int> set in packedList)
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

                Dictionary<int, int> encodedDictionary = EncodeList(packedList);

                string output = ConvertDictionaryToString(encodedDictionary);

                Console.WriteLine("Encoded list: (" + output + ")");
            }

            catch
            {
                Console.WriteLine("Something went wrong. Let's try that again.");
                Console.WriteLine(Environment.NewLine);
                Execute(null);
            }
        }

        private static string ConvertDictionaryToString(Dictionary<int, int> dictionary)
        {
            return "{" + string.Join(",", dictionary.Select(kv => kv.Key + ":" + kv.Value).ToArray()) + "}";
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

        private static Dictionary<int, int> EncodeList(List<List<int>> packedList)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();

            foreach (List<int> set2 in packedList)
            {
                var setKey = set2.First();
                var setValue = set2.Count();
                if (!dict.ContainsKey(setValue))
                {
                    dict.Add(setKey, setValue);
                }
            }

            return dict;
        }
    }
}
