
using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode1
{
    class AdventOfCodeDay2
    {
        public static void RunDay2(string[] input)
        {
            var amountOfPaper = 0;
            foreach (var s in input)
            {
                 var dims = s.Split('x');
                amountOfPaper += CalcOnePackage(int.Parse(dims[0]), int.Parse(dims[1]), int.Parse(dims[2]));
            }

            var amountOfRibbon = input.Select(s => s.Split('x')).Select(dims => CalcOneRibbon(int.Parse(dims[0]), int.Parse(dims[1]), int.Parse(dims[2]))).Sum();

            Console.WriteLine(amountOfPaper);
            Console.WriteLine(amountOfRibbon);
            Console.Read();
        }

        public static int CalcOnePackage(int l, int w, int h)
        {
            return CalcSurfaceArea(l,w,h) + CalcBuffer(l,w,h);
        }
        public static int CalcSurfaceArea(int l, int w, int h)
        {
            return 2*((l*w)+(w*h)+(l*h));
        }

        public static int CalcBuffer(int l, int w, int h)
        {
            var lowestTwo = FindTwoLowest(l, w, h);
            return lowestTwo[0]*lowestTwo[1];
        }

        public static int CalcOneRibbon(int l, int w, int h)
        {
            return FindLowestPerimeter(l, w, h) + FindVolume(l, w, h);
        }
        public static List<int> FindTwoLowest(int l, int w, int h)
        {
            var listSort = new List<int>() {l, w, h};
            return listSort.OrderBy(x => x).ToList().GetRange(0,2);
        }

        public static int FindLowestPerimeter(int l, int w, int h)
        {
            var lowestSide = FindTwoLowest(l, w, h);
            return (2*lowestSide[0]) + (2*lowestSide[1]);
        }

        public static int FindVolume(int l, int w, int h)
        {
            return l*w*h;
        }
    }
}
