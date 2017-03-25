using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Group_Continents__Countries_and_Cities
{
    public class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var result = new SortedDictionary<string, SortedDictionary<string, SortedSet<string>>>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ').ToList();
                var continents = input[0];
                var country = input[1];
                var city = input[2];
                AddLocations(result, continents, country, city);
            }
            foreach (var continent in result.Keys)
            {
                Console.WriteLine($"{continent}: ");
                foreach (var country in result[continent].Keys)
                {
                    Console.Write($" {country} -> ");
                    Console.WriteLine($"{string.Join(", ", result[continent][country])}");
                }
            }
        }
        private static void AddLocations(SortedDictionary<string, SortedDictionary<string, SortedSet<string>>> result, string continents, string country, string city)
        {
            if (!result.ContainsKey(continents))
            {
                result[continents] = new SortedDictionary<string, SortedSet<string>>();
            }

            if (!result[continents].ContainsKey(country))
            {
                result[continents][country] = new SortedSet<string>();
            }
            result[continents][country].Add(city);
        }
    }
}
