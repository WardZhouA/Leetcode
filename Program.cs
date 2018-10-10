using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchBackTrace
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the light number:");
            int x = Convert.ToInt32(Console.ReadLine());
            solution.readBinaryWatch(x);
            Console.ReadLine();
        }

    }
    class solution
    {

        public static List<String> readBinaryWatch(int num)
        {
            List<String> times = new List<String>();
            for (int h = 0; h < 12; h++)
            {
                
                for (int m = 0; m < 60; m++)
                {
                    if (count(h) + count(m) == num)
                    {
                        Console.WriteLine("{0}:{1}", h.ToString().PadLeft(2, '0'), m.ToString().PadLeft(2, '0'));
                    }
                }
            }
            return times;
        }
        private static int count(int a)
        {
            int count = 0;
            string j = Convert.ToString(a, 2);
            foreach (char i in j)
            {
                if (i == '1')
                {
                    count++;
                }
            }
            return count;
        }

    }
}
