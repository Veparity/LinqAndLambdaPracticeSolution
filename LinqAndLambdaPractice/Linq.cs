using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAndLambdaPractice
{
    public class Linq
    {
        public static void LinqTest()
        {
            var data = SampleData.GetPerson();

            //var results = (from p in data where p.FirstName.StartsWith("J") select p);
            //foreach (var result in results)
            //{
            //    Console.WriteLine($"Hello {result.FirstName}");
            //}

            var results = (from p in data orderby p.FirstName select p);
            foreach (var result in results)
            {
                Console.WriteLine($"Hello {result.FirstName}");
            }
        }
    }
}
