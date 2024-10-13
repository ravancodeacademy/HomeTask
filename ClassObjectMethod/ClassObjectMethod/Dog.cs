namespace ClassObjectMethod;
internal class Dog(string Name, byte Age, bool HasTail) : Animal(Name, Age)
{
    public bool HasTail = HasTail;

    public static void Bark()
    {
        Console.WriteLine("Dogs are barking");
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Name: {Name}\nAge {Age}\nHasTail {HasTail}");
    }
}

