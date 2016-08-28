using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp99Problems
{
    public class Program
    {
        public void Main(string[] args)
        {
            ConsoleColor color = ConsoleColor.DarkGreen;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Input a problem number: ", color);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.ResetColor();

            string[] y = new string[] { };

            var input = Console.ReadLine();

            try
            {
                int n = Convert.ToInt32(input);

                if(n == 1)
                {
                    Problem_01.Execute(y);
                    Restart();
                }

                if (n == 2)
                {
                    Problem_02.Execute(y);
                    Restart();
                }

                if (n == 3)
                {
                    Problem_03.Execute(y);
                    Restart();
                }

                if (n == 4)
                {
                    Problem_04.Execute(y);
                    Restart();
                }

                if (n == 5)
                {
                    Problem_05.Execute(y);
                    Restart();
                }

                if (n == 6)
                {
                    Problem_06.Execute(y);
                    Restart();
                }

                if (n == 7)
                {
                    Problem_07.Execute(y);
                    Restart();
                }

                if (n == 8)
                {
                    Problem_08.Execute(y);
                    Restart();
                }

                if (n == 9)
                {
                    Problem_09.Execute(y);
                    Restart();
                }

                if (n == 10)
                {
                    Problem_10.Execute(y);
                    Restart();
                }

                if (n == 11)
                {
                    Problem_11.Execute(y);
                    Restart();
                }

                if (n == 12)
                {
                    Problem_12.Execute(y);
                    Restart();
                }

                else
                {
                    Console.WriteLine("Problem not found. Try something else.");
                    Console.ReadLine();
                }

                Restart();
            }

            catch
            {
                Console.WriteLine("Something went wrong. Let's try that again.");
                Console.WriteLine(Environment.NewLine);
            }

        }

        public void Restart()
        {
            Main(null);
        }
    }
}
