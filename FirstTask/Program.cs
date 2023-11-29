using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask
{
    internal class Program
    {
        static void FillArray(ref List<int> list)
        {
            Random rnd = new Random();
            for (int i = 0; i < 1000; i++)
            {
                list.Add(rnd.Next(1, 10000));
            }
        }

        static Task<int> FindMaxAsync(List<int> list)
        {
            return Task.Run(() =>
            {
                return list.Max();
            });
        }

        static Task<int> FindMinAsync(List<int> list)
        {
            return Task.Run(() =>
            {
                return list.Min();
            });
        }

        static Task<int> FindSumAsync(List<int> list)
        {
            return Task.Run(() =>
            {
                return list.Sum();
            });
        }

        static Task<double> FindAvgAsync(List<int> list)
        {
            return Task.Run(() =>
            {
                return list.Average();
            });
        }

        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            FillArray(ref list);


            Console.WriteLine($"Max value: {FindMaxAsync(list).Result}");
            Console.WriteLine($"Min value: {FindMinAsync(list).Result}");
            Console.WriteLine($"Sum value: {FindSumAsync(list).Result}");
            Console.WriteLine($"AVG value: {FindAvgAsync(list).Result}");
            Console.ReadLine();
        }
    }
}
