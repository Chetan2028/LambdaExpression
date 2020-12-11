using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Lambda Expression");
            List<Person> listPersonsInCity = new List<Person>();
            listPersonsInCity.Add(new Person("203456876", "John", "12 Main Street, Newyork, NY", 15));
            listPersonsInCity.Add(new Person("203456877", "SAM", "13 Main Ct, Newyork, NY", 25));
            listPersonsInCity.Add(new Person("203456878", "Elan", "14 Main Street, Newyork, NY", 35));
            listPersonsInCity.Add(new Person("203456879", "Smith", "12 Main Street, Newyork, NY", 45));
            listPersonsInCity.Add(new Person("203456880", "SAM", "345 Main Ave, Dayton, OH", 55));
            listPersonsInCity.Add(new Person("203456881", "Sue", "32 Cranbrook Rd, Newyork, NY", 65));
            listPersonsInCity.Add(new Person("203456882", "Winston", "1208 Alex St, Newyork, NY", 65));
            listPersonsInCity.Add(new Person("203456883", "Mac", "126 Province Ave, Baltimore, NY", 17));
            listPersonsInCity.Add(new Person("203456884", "SAM", "126 Province Ave, Baltimore, NY", 95));

            Console.WriteLine("\n-----------------------------------------------------------------------------");
            Console.WriteLine("Retrieving Top 2 aged persons from the list who are older than 60 years\n");
            foreach (Person person in listPersonsInCity.FindAll(e => (e.Age < 60)).Take(2).ToList())
            {
                Console.WriteLine("Name : " + person.Name + " \t\tAge: " + person.Age);
            }


            Console.WriteLine("Retrieving persons from the list who are between 13 and 18 \n");
            foreach (Person person in listPersonsInCity.FindAll(e => (e.Age >= 13 && e.Age <=18)))
            {
                Console.WriteLine("Name : " + person.Name + " \t\tAge: " + person.Age);
            }
        }
    }
}
