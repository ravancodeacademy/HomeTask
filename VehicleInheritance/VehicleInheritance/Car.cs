using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleInheritance;

internal class Car : Vehicle
{
    private string _brand;
    private string _model;
    private double _fuelCapasity;
    private double _fuelPerKM;
    private double _currentFuel;

    public Car(string name, int year, string brand, string model, double fuelCapasity, double fuelPerKM, double currentFuel) : base(name, year)
    {
        if (currentFuel > fuelCapasity)
        {
            Console.WriteLine("Current fuel can't be higher than the max capasity");
            return;
        }

        _brand = brand;
        _model = model;
        _fuelCapasity = fuelCapasity;
        _fuelPerKM = fuelPerKM;
        _currentFuel = currentFuel;

    }


    public void ShowInfo()
    {
        Console.WriteLine($"Brand: {_brand}");
        Console.WriteLine($"Model: {_model}");
        Console.WriteLine($"Fuel Capasity: {_fuelCapasity}");
        Console.WriteLine($"Fuel Per KM: {_fuelPerKM}");
        Console.WriteLine($"Current Fuel: {_currentFuel}");
    }


    public void Drive(double roadLengthKM)
    {
        double fuelToSpend = roadLengthKM * _fuelPerKM;

        if (fuelToSpend > _fuelCapasity)
        {
            Console.WriteLine("Find another car");
            return;
        }

        if ((_currentFuel - fuelToSpend) < 0)
        {
            double lackOfFuel = fuelToSpend - _currentFuel;

            Console.WriteLine($"Can't go that far. You need {lackOfFuel} litres of fuel to go.");
            return;
        }
        _currentFuel -= fuelToSpend;
    }
}
