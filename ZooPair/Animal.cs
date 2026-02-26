using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Animal
{
    private string _name;
    private int _age;
    private int _soundCount;

    public string Name => _name;
    public int Age => _age;

    public Animal(string name, int age)
    {
        _name = name;
        _age = age;
        _soundCount = 0;
    }

    public virtual void MakeSound()
    {
        _soundCount++;
        Console.WriteLine("Животное издает звук");
    }

    public int GetSoundCount()
    {
        return _soundCount;
    }
}
