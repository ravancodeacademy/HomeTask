namespace ClassObjectMethod;
internal class Bird(string Name, byte Age, bool CanSwim) : Animal(Name, Age)
{
    public bool CanSwim = CanSwim;

    public static void Fly()
    {
        Console.WriteLine("Fly");
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Name: {Name}\nAge {Age}\nCanSwim {CanSwim}");
    }
}
