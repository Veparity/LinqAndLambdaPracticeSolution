using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAndLambdaPractice
{
    public class Lambdas
    {
        public static void LambdaTest()
        {
            var data = SampleData.GetPerson();

            //var results = data.Where(x => x.FirstName.StartsWith("J"));

            //foreach (var result in results)
            //{
            //    Console.WriteLine(result.FirstName);
            //}

            var results = data.OrderBy(x => x.LastName);

            foreach(var result in results)
            {
                Console.WriteLine(result.LastName);
            }
        }
    }
}
