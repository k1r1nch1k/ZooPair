using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Animal
{
    private string _name;
    private string _favoriteFood;
    private int _age;
    public string Name => _name;
    public int Age => _age;
    public Animal(string name, int age, string favoriteFood)
    {
        _name = name;
        _age = age;
        _favoriteFood = favoriteFood;
    }
    public virtual void MakeSound()
    {
        Console.WriteLine("Животное издает звук");
    }
}
