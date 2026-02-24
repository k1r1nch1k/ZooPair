using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Bird : Animal
{
    public Bird(string name, int age, string favoriteFood) : base(name, age, favoriteFood) { }
    public override void MakeSound()
    {
        Console.WriteLine($"{Name} чирикает");
    }
}
