using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace aoc3
{
    class Program
    {
        private static List<string> pwds;

        static void Main(string[] args)
        {
            pwds = new List<string>();
            FileStream fileStream = new FileStream("data.txt", FileMode.Open);
            using (StreamReader reader = new StreamReader(fileStream))
            {
                while (reader.Peek() >= 0)
                {
                    pwds.Add(reader.ReadLine());
                }
                
            }
            

            Console.WriteLine(Part1());
            Console.WriteLine(Part2());
        }

        private static int Part1()
        {
            int answer = 0;

            return answer;
        }

        private static int Part2()
        {
            int answer = 0;

            return answer;
        }
    }
}
