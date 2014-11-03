using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClimbingStairs
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] data = input.Split(new char[]{' '});
            long a = Convert.ToInt64(data[0]);
            long b = Convert.ToInt64(data[1]);
            long N = Convert.ToInt64(data[2]);
            Console.WriteLine(FindDays(N,a,b));
            Console.ReadKey();
        }

        static long FindDays(long N, long a, long b) {
            long days = 0; 
            long temp=N;
            if (a > b) { 
                long c = a - b;
                while (temp > 0) {
                    temp = temp - c;
                    days++;
                }
            }
            return days;
        }
    }
}
