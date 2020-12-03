using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace aoc4
{
    class Program
    {
        private static List<string> lines;

        static void Main(string[] args)
        {
            lines = new List<string>();
            FileStream fileStream = new FileStream("data.txt", FileMode.Open);
            using (StreamReader reader = new StreamReader(fileStream))
            {
                while (reader.Peek() >= 0)
                {
                    lines.Add(reader.ReadLine());
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
