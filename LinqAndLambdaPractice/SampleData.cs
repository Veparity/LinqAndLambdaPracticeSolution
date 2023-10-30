using LinqAndLambdaPractice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace LinqAndLambdaPractice
{
    public static class SampleData
    {
       public static List<PersonModel> GetPerson()
        {
            List<PersonModel> output = new List<PersonModel> {
            new PersonModel {Id = 1, FirstName = "Kelsey", LastName = "Barq" },
            new PersonModel {Id = 2, FirstName = "Carol", LastName = "Tab" },
            new PersonModel {Id = 3, FirstName = "Jriel", LastName = "Pop" },
            new PersonModel {Id = 4, FirstName = "Jasmine", LastName = "Cola" }};
            return output;
        }

    }
}
