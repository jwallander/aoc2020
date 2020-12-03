using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace aoc3
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
            int lineLength = lines?.First().Length ?? 1; 

            int answer = 0;
            int xpos;

            for (int ypos = 0; ypos < lines.Count; ypos++)
            {
                xpos = (ypos*3) % lineLength;
                answer += TreeCount(xpos, ypos);
            }

            return answer;
        }

        private static Int64 Part2()
        {
            var slopes = new List<Tuple<int, int>> 
            { 
                new Tuple<int, int>(1, 1), 
                new Tuple<int, int>(3, 1), 
                new Tuple<int, int>(5, 1), 
                new Tuple<int, int>(7, 1), 
                new Tuple<int, int>(1, 2), 
            };  


            int lineLength = lines?.First().Length ?? 1; 

            Int64 answer = 1;
            int slopeAnswer = 0;
            int xpos;

            foreach (var slope in slopes)
            {
                for (int ypos = 0; ypos < lines.Count; ypos += slope.Item2)
				{
					var slopeRate = ((double) slope.Item1) / ((double) slope.Item2);
					xpos = (int)((ypos * slopeRate) % lineLength);
					slopeAnswer += TreeCount(xpos, ypos);
				}

				answer = answer * slopeAnswer;
                Console.WriteLine(slopeAnswer);
                slopeAnswer = 0;
            }

            return answer;
        }

		private static int TreeCount(int xpos, int ypos)
		{
            var count = 0;
			bool isTree = lines[ypos].Substring(xpos, 1) == "#";
			if (isTree)
			{
				count = 1;
			}

			return count;
		}
	}
}
