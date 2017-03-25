using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Shellbound
{
    public class Program
    {
        public static void Main()
        {
            var result = new Dictionary<string, HashSet<int>>();
            var input = Console.ReadLine(); 
            while (input!= "Aggregate")
            {
                var token = input.Split(' ');
                var region = token[0];
                var shell = int.Parse(token[1]);

                if (!result.ContainsKey(region))
                {
                    result[region] = new HashSet<int>();
                }
                result[region].Add(shell);
                input = Console.ReadLine();
            }
            foreach (var region in result)
            {
                var total = region.Value.Sum() - region.Value.Average();
                Console.WriteLine($"{region.Key} -> {string.Join(", ", region.Value)} ({Math.Ceiling(total)})");   
            }
        }
    }
}
