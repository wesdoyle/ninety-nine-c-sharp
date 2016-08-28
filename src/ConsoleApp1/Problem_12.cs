using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp99Problems //Decode a run-length encoded list
{
    public class Problem_12
    {
        public static void Execute(string[] args)
        {
            var encodedList = new List<Tuple<int, int>>()
            {
                new Tuple<int, int>(1, 14),
                new Tuple<int, int>(2, 17),
                new Tuple<int, int>(8, 42),
                new Tuple<int, int>(7, 36),
                new Tuple<int, int>(1, 142),
                new Tuple<int, int>(2, 7),
            };

            var result = DecodeList(encodedList);

            Console.WriteLine("No input for this problem. Here is an encoded list:");
            Console.WriteLine("(" + string.Join(",", encodedList) + ")");
            Console.WriteLine(")");
            Console.WriteLine("Here is the decoded list:");

            var lastElementInList = result[result.Count-1];

            Console.WriteLine("(" + string.Join(",", result) + ")");
 
        }

        private static List<int> DecodeList(List<Tuple<int, int>> encodedList)
        {
            var result = new List<int>();

            foreach (var i in encodedList)
            {
                List<int> newList = (Enumerable.Range(0, i.Item1).Select(x => i.Item2)).ToList<int>();

                result.AddRange(newList);
            }

            return result;
        }
    }
}
