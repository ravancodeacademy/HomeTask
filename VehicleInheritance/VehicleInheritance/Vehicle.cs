using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleInheritance;

internal class Vehicle
{
    private readonly string _name;
    private readonly int _year;

    public Vehicle(string name, int year)
    {
        if (year < 1886)
        {
            Console.WriteLine("The first car invented at 1886");
            return;
        }

        _name = name;
        _year = year;
    }

}