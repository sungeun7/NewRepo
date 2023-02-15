﻿using System;
using System.Collections.Generic;

namespace Example1
{
    public partial class Person
    {
                    
            public string SSN;
            public string Name;
            public string Address;
            public int Age;
            public Person(string ssn, string name, string addr, int age)
            {
                SSN = ssn;
                Name = name;
                Address = addr;
                Age = age;
            }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            List<Person> listPersonsInCity = new List<Person>();

            listPersonsInCity.Add(new Person("203456876", "John", "12 Main Street, Newyork, NY", 15));
            listPersonsInCity.Add(new Person("203456877", "SAM", "13 Main Ct, Newyork, NY", 25));
            listPersonsInCity.Add(new Person("203456878", "Elan", "14 Main Street, Newyork, NY", 35));
            listPersonsInCity.Add(new Person("203456879", "Smith", "12 Main Street, Newyork, NY", 45));
            listPersonsInCity.Add(new Person("203456880", "SAM", "345 Main Ave, Dayton, OH", 55));
            listPersonsInCity.Add(new Person("203456881", "Sue", "32 Cranbrook Rd, Newyork, NY", 65));
            listPersonsInCity.Add(new Person("203456882", "Winston", "1208 Alex St, Newyork, NY", 65));
            listPersonsInCity.Add(new Person("203456883", "Mac", "126 Province Ave, Baltimore, NY", 85));
            listPersonsInCity.Add(new Person("203456884", "SAM", "126 Province Ave, Baltimore, NY", 95));
        }
    }
}
