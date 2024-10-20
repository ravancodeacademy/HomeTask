using WeaponProject.Models;

namespace WeaponProject;
internal class Program
{
    static void Main(string[] args)
    {
        Weapon weapon = new(200, 50, WeaponFireMode.single);
        Console.WriteLine("0 - Get info");
        Console.WriteLine("1 - Shoot");
        Console.WriteLine("2 - Fire");
        Console.WriteLine("3 - Needed bullet count");
        Console.WriteLine("4 - Reload");
        Console.WriteLine("5 - Change fire mode");
        Console.WriteLine("6 - Exit");

        while (true)
        {
          
            Console.Write("Enter your selection: ");
            byte.TryParse(Console.ReadLine(), out var index);

            if (index == 6)
            {
                Console.WriteLine("Exitting...");
                break;
            }


            switch(index)
            {
                case 0:
                    Console.WriteLine(weapon.GetInfo());
                    Console.WriteLine();

                    break;
                case 1:
                    if (!weapon.Shoot())
                    {
                        Console.WriteLine($"Couldn't shoot\n");
                    }
                    else
                    {
                        Console.WriteLine("Shooted 1 bullet\n");
                    }
                    break;
                case 2:
                    float seconds = weapon.Fire();
                    if (seconds == 0)
                    {
                        Console.WriteLine("No bullet\n");
                    }
                    Console.WriteLine($"It took {seconds} seconds\n");
                    break;
                case 3:
                    Console.WriteLine(weapon.GetNeededBulletCount());
                    Console.WriteLine();
                    break;
                case 4:
                    weapon.Reload();
                    Console.WriteLine("Reloaded\n");
                    break;
                case 5:
                    WeaponFireMode fireMode =  weapon.ChangeFireMode();
                    Console.WriteLine($"Firemode changed to {fireMode}\n");
                    break;
            }
        }
    }
}
