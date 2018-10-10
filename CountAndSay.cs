using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountAndSay
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            string result = "11";
            int times = int.Parse(n)-1;
            if (times == 1)
            {
                result = "11";
            }
            else
            {
                for (int i = 0; i < times - 1; i++)
                {
                    result = CountAndSay.Count(result);
                }
            }

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
    class CountAndSay
    {
        public static string Count(string Rec)
        {
            int count = 1;
            int i = 0;
            string temp = "";
            int length = Rec.Length;
            for (int a = 0; a < length; a++)
            {
                if (i + 1 < length&&Rec[i] == Rec[i + 1])
                {
                    count++;
                }
                else
                {
                    if (count != 1)
                    {
                        temp += count.ToString();
                        temp += Rec[i].ToString();
                        count = 1;
                    }
                    else
                    {
                        count = 1;
                        temp += count.ToString();
                        temp += Rec[i].ToString();
                    }
                }
                i++;
            }

            string result = temp;
            return result;
        }

        private string AddUp(string list)
        {
            string result = null;
            return result;
        }
    }
}
