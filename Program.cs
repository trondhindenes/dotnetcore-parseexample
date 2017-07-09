using System;
using Newtonsoft.Json;
using MyClasses;

namespace parseexample
{
    class Program
    {
        static void Main(string[] args)
        {
            //c# requires double quotes. 
            // Dont worry about it, just pretend this string comes from a rest api somewhere.
            var myString = @"
            {
                ""name"": ""trond"",
                ""lastname"": ""hindenes""
            }";

            // essentially: Take the myString variable, and convert it to the type "Person"
            // which is defined in the "Person.cs" file.
            var myPerson = Newtonsoft.Json.JsonConvert.DeserializeObject<Person>(myString);

            // since we know that "myPerson" is an object of the "Person" class, 
            // we know that it has a "name" attribute that can be accessed directly.
            Console.WriteLine(myPerson.name);
        }
    }
}
