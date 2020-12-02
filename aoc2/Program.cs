using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace aoc2
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

            foreach (var x in pwds)
            {
                var kpos = x.IndexOf(":");
                var c = x.Substring(kpos-1,1);
                var dpos = x.IndexOf("-");
                var llim = int.Parse(x.Substring(0,dpos));
                var hlim = int.Parse(x.Substring(dpos+1,(kpos-2)-(dpos+1)));
                var pw = x.Substring(kpos+2);
                var count = pw.Count(ch => ch == Convert.ToChar(c));  
                if (count >= llim && count <= hlim)
                {
                    answer++;
                }
            }

            return answer;
        }

        private static int Part2()
        {
            int answer = 0;

            foreach (var x in pwds)
            {
                var kpos = x.IndexOf(":");
                var c = x.Substring(kpos-1,1);
                var dpos = x.IndexOf("-");
                var index1 = int.Parse(x.Substring(0,dpos))-1;
                var index2 = int.Parse(x.Substring(dpos+1,(kpos-2)-(dpos+1)))-1;
                var pw = x.Substring(kpos+2);
                if (pw.Substring(index1,1) == c ^ pw.Substring(index2,1) == c)
                {
                    answer++;
                }
            }

            return answer;
        }
    }
}
