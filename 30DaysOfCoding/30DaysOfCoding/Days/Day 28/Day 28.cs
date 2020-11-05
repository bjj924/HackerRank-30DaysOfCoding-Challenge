using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _30DaysOfCoding.Days.Day_28
{
    public class Day_28
    {
        public static void RegexTester()
        {
            List<KeyValuePair<string, string>> list = new List<KeyValuePair<string, string>>();
            int N = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                string[] tokens_firstName = Console.ReadLine().Split(' ');
                string firstName = tokens_firstName[0];
                string emailID = tokens_firstName[1];
                var element = new KeyValuePair<string, string>(emailID, firstName);
                list.Add(element);

            }
            var res = from a in list
                      where a.Key.EndsWith("@gmail.com")
                      orderby a.Value ascending
                      select a.Value;
            foreach (var name in res)
            {
                Console.WriteLine(name);
            }
            Console.ReadKey();
        }
    }
}
