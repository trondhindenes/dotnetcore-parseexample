using System;
using Newtonsoft.Json;
using MyClasses;

namespace parseexample
{
    class Program
    {
        static void Main(string[] args)
        {
            var myString = @"
            {
                ""name"": ""trond"",
                ""lastname"": ""hindenes""
            }";
            var myPerson = Newtonsoft.Json.JsonConvert.DeserializeObject<Person>(myString);
            Console.WriteLine(myPerson.name);
        }
    }
}
