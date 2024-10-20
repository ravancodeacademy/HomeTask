using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers.Models;

internal class Person(string username, string password, string name, string surname, byte age, DateTime birthday)
{
    private string _username = username;
    private string _password = password;
    private string _name = name;
    private string _surname = surname;
    private byte _age = age;
    private DateTime _birthday = birthday;


    public string GetInfo()
    {
        return $"Username: {_username}\nPassword: {_password}\nName: {_name}\nSurname: {_surname}\nAge: {_age}\nBirthday: {_birthday}";
    }
}
