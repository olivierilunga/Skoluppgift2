using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skoluppgift3;

public class Person
{
    private int _age;
    private string? _fName;
    private string? _lName;
    private double _height;
    private double _weight;

    public int Age
    {
        get => _age;
        set
        {
            if (value < 0)
            {
                throw new ArgumentException(nameof(value), "Persons age can only be older than 0");
            }
            _age = value;
        }
    }
    public string? FName
    {
        get => _fName;
        set
        {
            if (value?.Length < 2)
            {
                throw new ArgumentException(nameof(value), "First name can't be lesser than 2 letters");
            }
            if (value?.Length > 10)
            {
                throw new ArgumentException(nameof(value), "First name can't have more than 10 letters");
            }
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value), "First name can't be null letters");
            }
            _fName = value;
        }
    }
    public string? LName
    {
        get => _lName;
        set
        {
            if (value?.Length < 3)
            {
                throw new ArgumentException(nameof(value), "Last name can't be lesser than 2 letters");
            }
            if (value?.Length > 15)
            {
                throw new ArgumentException(nameof(value), "Last name can't have more than 10 letters");
            }
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value), "Last name can't be null letters");
            }
            _lName = value;
        }
    }
    public double Height
    {
        get => _height;
        set
        {
            if (value < 30)
            {
                throw new ArgumentException(nameof(value), "Persons height can't be lesser than 30 cm");
            }
            _height = value;
        }
    }
    public double Weight
    {
        get => _weight;
        set
        {
            if (value < 40)
            {
                throw new ArgumentException(nameof(value), "Persons can't weight lesser than 20 kg");
            }
            _weight = value;
        }
    }


    public Person()
    {
    }
    public Person(string? firstName, string? lastName, int age, double height, double weight)
    {
        Age = age;
        FName = firstName;
        LName = lastName;
        Height = height;
        Weight = weight;
    }
}
