﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skoluppgift3
{
    internal class PersonHandler : IPersonHandler
    {
        public Person CreatePerson(int age, string fname, string lname, double height, double weight)
        {
            Person person = new Person();
            return person;
            
        }
        public void SetAge(Person pers, int age)
        {
            pers.Age = age;
        }
        public void SetFirstName(Person pers, string firstName)
        {
            pers.FName = firstName;
        }
        public void SetLastName(Person pers, string lastName)
        {
            pers.LName = lastName;
        }
    }
}
