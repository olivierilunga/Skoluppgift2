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
    private string? _lastName;
    private int _height;
    private int _weight;

    public int Age
    {
        get => _age;
        set
        {
            if (value < 0)
            {
                throw new ArgumentException(nameof(value), "Persons age can't be lesser than 0");
            }
            _age = value;
        }
    }
    public string? FName
    {
        get => _fName;
        set
        {
            if ((value?.Length < 2 || value?.Length > 10) || value?.Length != null)
            {
                _fName = value;
            }
            throw new ArgumentNullException(nameof(value), "First name can't be null or lesser than 2 letters");
        }
    }
    public string? LastName { get => _lastName; set => _lastName = value; }
    public int Height { get => _height; set => _height = value; }
    public int Weight { get => _weight; set => _weight = value; }


    public Person()
    {
    }
    public Person(int age, string? fName, string? lastName, int height, int weight)
    {
        Age = age;
        FName = fName;
        LastName = lastName;
        Height = height;
        Weight = weight;
        Age = age;
        FName = fName;
        LastName = lastName;
        Height = height;
        Weight = weight;
    }
}
