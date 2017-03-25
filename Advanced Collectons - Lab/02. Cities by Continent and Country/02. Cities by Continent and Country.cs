using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Cities_by_Continent_and_Country
{
    public class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var result = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < n; i++)
            {
                var token = Console.ReadLine().Split(' ').ToList();
                var continents = token[0];
                var countries = token[1];
                var cities = token[2];
                if (!result.ContainsKey(continents)) 
                {
                    result[continents] = new Dictionary<string, List<string>>();
                }
                if (!result[continents].ContainsKey(countries))
                {
                    result[continents][countries] = new List<string>();
                }
                result[continents][countries].Add(cities);
            }
            foreach (var nameContinent in result.Keys)
            {
                Console.WriteLine(nameContinent + ":");
                foreach (var KeyValurPair in result[nameContinent].Keys)
                {
                    Console.WriteLine($" {KeyValurPair} -> {string.Join(", ", result[nameContinent][KeyValurPair])}");
                }
            }
        }
    }
}
