namespace ClassObjectMethod;
internal class Animal(string Name, byte Age)
{
    public string Name = Name;
    public byte Age = Age;

    public static void Eat()
    {
        Console.WriteLine("Able to eat");
    }
}
