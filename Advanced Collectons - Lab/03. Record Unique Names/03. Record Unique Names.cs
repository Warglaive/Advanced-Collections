using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Record_Unique_Names
{
   public class Program
    {
       public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var result = new HashSet<string>();
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                if (!result.Contains(name))
                {
                    result.Add(name);
                }
            }
            foreach (var name in result)
            {
                Console.WriteLine(name);
            }
        }
    }
}
