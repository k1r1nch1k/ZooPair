class Program
{
    static void Main()
    {
        Zoo zoo = new Zoo();
        zoo.AddAnimal(new Mammal("Лев", 5));
        zoo.AddAnimal(new Bird("Орел", 3));
        Console.WriteLine("Добро пожаловать в зоопарк!");
        zoo.ShowAll();

    }
}
