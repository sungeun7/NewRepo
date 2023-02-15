using System;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Retrieving Top 2 aged persons from the list who are older than 60 years\n");

            foreach (Person person in listPersonsInCity.FindAll(e => (e.Age >= 60)).Take(2).ToList())
            {
                Console.WriteLine("Name : " + person.Name + " \t\tAge: " + person.Age);
            }

        }
    }
}
