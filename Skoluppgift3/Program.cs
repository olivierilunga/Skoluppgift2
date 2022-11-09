
using Skoluppgift3;
using System;


//person.FName = "Test";

try
{
    //var person = new Person("Scott", null, 25, 160, 60);
    // var person = new Person(null, null, -2, -1, -1);
    var person = new Person();
    Console.WriteLine($"Första namn: {person}");
}
catch (ArgumentException ex)
{

    throw new ArgumentException(ex.Message);
}