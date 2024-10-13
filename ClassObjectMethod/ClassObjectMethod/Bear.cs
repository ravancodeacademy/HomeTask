namespace ClassObjectMethod;
internal class Bear(string Name, byte Age, bool IsWild) : Animal(Name, Age)
{
    public bool IsWild = IsWild;

    public void PrintInfo()
    {
        Console.WriteLine($"Name: {Name}\nAge {Age}\nIsWild {IsWild}");
    }
}