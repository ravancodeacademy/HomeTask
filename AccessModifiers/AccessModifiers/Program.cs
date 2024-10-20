namespace AccessModifiers;
using AccessModifiers.Models;
using CustomValidator;

internal class Program
{
    static void Main(string[] args)
    {
        do
        {
            Console.Write("Username: ");
            string username = Console.ReadLine();
            if (!Validator.Min2Characters(username))
            {
                Console.WriteLine("Minimum 2 characters\n");
                continue;
            }

            Console.Write("Password: ");
            string password = Console.ReadLine();
            if (!Validator.PasswordValidator(password))
            {
                Console.WriteLine("Not a valid password\n");
                continue;
            }

            Console.Write("Name: ");
            string name = Console.ReadLine();
            if (!Validator.Min2Characters(name))
            {
                Console.WriteLine("Minimum 2 characters\n");
                continue;
            }

            Console.Write("Surname: ");
            string surname = Console.ReadLine();
            if (!Validator.Min2Characters(surname))
            {
                Console.WriteLine("Minimum 2 characters\n");
                continue;
            }

            Console.Write("Age: ");
            byte.TryParse(Console.ReadLine(), out byte age);
            if (!Validator.AgeValidator(age))
            {
                Console.WriteLine("Not a valid age\n");
                continue;
            }

            Console.Write("Birthday (MM.DD.YYYY): ");
            DateTime.TryParse(Console.ReadLine(), out DateTime birthday);
            if (!Validator.BirthdayValidator(birthday))
            {
                Console.WriteLine("Not a valid birthdate\n");
                continue;
            }

            Person person = new(username, password, name, surname, age, birthday);
            Console.WriteLine(person.GetInfo());
        }
        while (true);
        
    }
}