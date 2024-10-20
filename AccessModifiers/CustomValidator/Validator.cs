using System.Text.RegularExpressions;

namespace CustomValidator;

public class Validator
{
    private const string _passwordPattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$";
    private static readonly Regex _passwordRegex = new(_passwordPattern);
    private static readonly DateTime _thresholdDate = new(1970, 1, 1);


    public static bool Min2Characters(string input)
    {
        if (input.Length < 2) 
        {
            return false;
        }
        return true;
    }

    public static bool PasswordValidator(string input)
    {
        return _passwordRegex.IsMatch(input);
    }

    public static bool AgeValidator(byte input)
    {
        if (input < 1)
        {
            return false;
        }

        return true;
    }

    public static bool BirthdayValidator(DateTime input)
    {
        return input > _thresholdDate;
    }

}
