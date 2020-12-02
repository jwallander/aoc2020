using System;
using System.Collections.Generic;
using System.IO;

namespace aoc1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var numbers = new List<int>();
            FileStream fileStream = new FileStream("data.txt", FileMode.Open);
            using (StreamReader reader = new StreamReader(fileStream))
            {
                while (reader.Peek() >= 0)
                {
                    numbers.Add(int.Parse(reader.ReadLine()));
                }
                
            }
            
            int answer = 0;
            int ax = 0;
            int ay = 0;
            foreach (var x in numbers)
            {
                foreach (var y in numbers)
                {
                    if (x + y == 2020)
                    {
                       answer = x * y;
                       ax = x;
                       ay = y;
                       break; 
                    }
                }
                if (answer != 0)
                {
                    break;
                }
            }
   
            int answer2 = 0;
            int ax2 = 0;
            int ay2 = 0;
            int az2 = 0;
            foreach (var x in numbers)
            {
                foreach (var y in numbers)
                {
                    foreach (var z in numbers)
                    {
                        if (x + y + z == 2020)
                        {
                            answer2 = x * y * z;
                            ax2 = x;
                            ay2 = y;
                            az2 = z;
                            break;
                        }
                    }
                    if (answer2 != 0)
                    {
                        break;
                    }
                }
                if (answer2 != 0)
                {
                    break;
                }
            }

            Console.WriteLine(ax);
            Console.WriteLine(ay);
            Console.WriteLine(answer);
            Console.WriteLine(ax2);
            Console.WriteLine(ay2);
            Console.WriteLine(az2);
            Console.WriteLine(answer2);
        }
    }
}
