using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    public class Helper
    {
        public static List<List<int>> Splitter(string[] strings, char x)
        {
            var result = new List<List<int>>();

            foreach (var str in strings)
            {
                var split = str.Split(x);

                var intList = new List<int>();

                foreach (var s in split)
                {
                    if (int.TryParse(s, out int num))
                    {
                        intList.Add(num);
                    }
                    else
                    {
                        Console.WriteLine($"Could not parse '{s}' as an integer.");
                    }
                }

                result.Add(intList);
            }

            return result;
        }
        public static int CalculateSurfaceArea(List<List<int>> surfaceArea)
        {
            int result = 0;
            foreach (var surface in surfaceArea)
            {
                List<int> area = new List<int>();
                area.Add(surface[0] * surface[1] * 2);
                area.Add(surface[1] * surface[2] * 2);
                area.Add(surface[2] * surface[0] * 2);
                result += area.Sum();
                int minimum = area.Min() / 2;
                result += minimum;
            }
            return result;
        }
        public static int CalculateRibbon(List<List<int>> ribbons)
        {
            int result = 0;
            foreach (var ribbon in ribbons)
            {
                ribbon.Sort();
                var perimeter = (ribbon[0] * 2) + (ribbon[1] * 2);
                int mult = 1;   
                foreach (var rib in ribbon)
                {
                    mult *= rib;
                }
                result += perimeter + mult;
            }
            return result;
        }
    }
}
