
using Skoluppgift3;
using System;


//person.FName = "Test";

//try
//{
Person pers = new Person();
PersonHandler pHandler = new();

//var fastPerson = pHandler.CreatePerson(55, "Chanty", "Image", 172, 66);

//pHandler.SetFirstName(pers: pers, "Sofie");
//pHandler.SetLastName(pers: pers, "Strandvägsson");
//pHandler.SetAge(pers: pers, 30);
//pHandler.SetWeight(pers: pers, 70);
//pHandler.SetHeight(pers: pers, 170);


//Console.WriteLine($"testar CreatPerson metoden: {fastPerson.FName}");
//Console.WriteLine($"testar CreatPerson metoden: {fastPerson.LName}");
//Console.WriteLine($"testar CreatPerson metoden: {fastPerson.Age}");
//Console.WriteLine($"testar CreatPerson metoden: {fastPerson.Height}");
//Console.WriteLine($"testar CreatPerson metoden: {fastPerson.Weight} \n");


//Console.Write($"Name: {pers.FName}\t");
//Console.Write($"Last name: {pers.LName}\t");
//Console.Write($"Age: {pers.Age} years old\n");
//Console.Write($"Height: {pers.Height} cm\t");
//Console.Write($"Weight: {pers.Weight} kg.\n");

List<UserError> userErrors = new()
    {
        new NumericInputError(),
        new TextInputError(),
        new PointsError(),
        new ThoughtsError(),
        new DoneError()
    };

foreach (UserError error in userErrors)
{
    Console.WriteLine($"{error.UEMessage()}");
}
//}
//catch (ArgumentException ex)
//{

//    throw new ArgumentException(ex.Message);
//}