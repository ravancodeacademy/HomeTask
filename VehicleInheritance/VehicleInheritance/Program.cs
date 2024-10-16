namespace VehicleInheritance;

internal class Program
{
    static void Main(string[] args)
    {
        Car car = new Car("Chevrolet", 1967, "Impala", "Impala", 40, 5, 30);
        car.Drive(8);
    }
}
