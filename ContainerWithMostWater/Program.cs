using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContainerWithMostWater
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] container = new int[] { 2, 3, 4, 5, 18, 17, 6 };
            Console.WriteLine(MaxArea(container));
            Console.ReadKey();
        }

        private static int MaxArea(int[] container)
        {
            if (container == null)
            {
                return 0;
            }

            int l = 0, r = container.Length - 1;
            int maxArea = 0;
            while (l < r)
            {
                int area = (r - l) * Math.Min(container[l], container[r]);
                maxArea = Math.Max(area, maxArea);

                if (container[l] < container[r])
                {
                    l++;
                }
                else
                {
                    r--;
                }
            }

            return maxArea;
        }
    }
}
