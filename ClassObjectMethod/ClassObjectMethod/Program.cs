using System.Net.Mail;
using System.Reflection;

namespace ClassObjectMethod;
internal class Program
{
    static void Main(string[] args)
    {

        do
        {
            Console.WriteLine("1 - Dog\n2 - Bear\n3 - Bird");
            Console.Write("Please select an animal index from 1 to 3: ");

            _ = byte.TryParse(Console.ReadLine(), out byte animalIndex);

            if (animalIndex > 3 || animalIndex < 1)
            {
                continue;
            }

            Console.Write("Name: ");
            string? name = Console.ReadLine();
            Console.Write("Age: ");
            _ = byte.TryParse(Console.ReadLine(), out byte age);

            if (name == null || age == 0)
            {
                Console.WriteLine("Invalid Parameters");
                break;
            }

            if (animalIndex == 1)
            {
                Console.Write("Has tails? (True/False): ");
                _ = bool.TryParse(Console.ReadLine(), out bool hasTail);
                Console.WriteLine();
                Dog dog = new(name, age, hasTail);
                dog.PrintInfo();
            }

            else if (animalIndex == 2)
            {
                Console.Write("Is it wild? (True/False): ");
                _ = bool.TryParse(Console.ReadLine(), out bool isWild);
                Console.WriteLine();
                Bear bear = new(name, age, isWild);
                bear.PrintInfo();
            }

            else if (animalIndex == 3)
            {
                Console.Write("Is it wild? (True/False): ");
                _ = bool.TryParse(Console.ReadLine(), out bool canSwim);
                Console.WriteLine();
                Bird bird = new(name, age, canSwim);
                bird.PrintInfo();
            }

            break;
        }
        while (true);
          
    }
}