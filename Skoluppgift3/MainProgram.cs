
using Skoluppgift3;
using Skoluppgift3.Animals;
using System;


//person.FName = "Test";

internal class Program : IPerson
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
        List<Animal> animals = new()
{
    new Dog(4, "Dog",45, "Black","Bulldog"),
    new Horse(10, "Horce",100, "Black",120),
    new Worm(30, "Worm",50, "Black",true),
    new Wolfman(36, "Dill", 90, "scaarryy", false)
};

        foreach (Animal animal in animals)
        {

            //if (animals.Contains(new Wolfman((36, "Dill", 90, "scaarryy", false))))
            //{
            //  //  Console.WriteLine($"Animal: {animal},\t sounds: {(Talk("Hello world!"))}");
            //}

            Console.WriteLine($"Animal: {animal.Name},\t sounds: {animal.DoSound()}");
            Console.WriteLine($"Stas {animal.Stats(30, "Worm", 50, "Black")}");
        }
    }

    public void Talk(string talks)
    {

    }
}

// för hästar ärver inte från hundar
// List av animals för att man ska kunna lägga till olika typer av djur i listan

//List<Dog> dogs = new List<Dog>
//{
//    new Horse(4,"Hybrid", 150, "uknown", 200)
//};
//dogs.Add(new Horse(4, "Hybrid", 150, "uknown", 200));