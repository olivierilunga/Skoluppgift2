
using Skoluppgift3;
using Skoluppgift3.Animals;
using System;


//person.FName = "Test";

internal class Program
{


    private static void Main(string[] args)
    {

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

        //foreach (UserError error in userErrors)
        //{
        //    Console.WriteLine($"{error.UEMessage()}");
        //}

        //}
        //catch (ArgumentException ex)
        //{

        //    throw new ArgumentException(ex.Message);
        //}
        //Wolfman wolfman = new Wolfman.Talk();

        List<Animal> animals = new()

{
    new Dog(4, "Dog",45, "Black","Bulldog"),
    new Horse(10, "Horce",100, "Black",120),
    new Worm(30, "Worm",50, "Black",true),
    new Wolfman(36, "Dill", 90, "scaarryy", false)
};

        //foreach (Animal animal in animals.Walk())
        //{

        //    if (animals.Contains(Dog))
        //    {
        //        Console.WriteLine($"Animal: {animal},\t sounds: {IPerson.Talk}");
        //    }

        //    Console.WriteLine($"Animal: {animal.Name},\t sounds: {animal.DoSound()}");
        //}


        foreach (Animal animal in animals)
        {
            //vi skriver över värdet i propertyn. Varje gång vi anropar Stats() metoden och sätter ett ny värde
            Console.WriteLine($"\n\nStas {animal.Stats(40, "BigWorm", 70, "Yellow")}");
        }

        //foreach (var dog in animals)
        //{
        //    if (dog.Equals(new Dog()))
        //    {
        //        Console.WriteLine("");
        //    }
        //    Console.WriteLine(dog);
        //}

        // för hästar ärver inte från hundar
        // List av animals för att man ska kunna lägga till olika typer av djur i listan eller objecr lista

        //List<Dog> dogs = new List<Dog>
        //{
        //    new Horse(4,"Hybrid", 150, "uknown", 200)
        //};
        //dogs.Add(new Horse(4, "Hybrid", 150, "uknown", 200));
    }
}
