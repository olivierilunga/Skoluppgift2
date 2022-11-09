
using Skoluppgift3;
using System;


//person.FName = "Test";

try
{
    //var pe = new Person("Scott", "Hanselman", 25, 160, 60);
    // var person = new Person(null, null, -2, -1, -1);
    PersonHandler p = new();
    p.CreatePerson(4, "Kif", "Did", 44, 60);
    p.SetFirstName(pe, "Idiot");
}
catch (ArgumentException ex)
{

    throw new ArgumentException(ex.Message);
}