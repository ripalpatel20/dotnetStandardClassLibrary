using System;
using System.Collections.Generic;
using System.Text;

namespace dotnetStandardClassLibrary
{
    public class Operator
    {
        public List<Person> CreateListOfPeople()
        {
            List<Person> output = new List<Person>();
            output.Add(new Person {FirstName ="Ripal" , LastName = "Patel" });
            output.Add(new Person {FirstName = "Tejas", LastName = "Patel" });
            return output;
        }
    }
}
