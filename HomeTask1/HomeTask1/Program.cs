#region Task 1
/*int userInputNumber;
do
{
    Console.WriteLine("Enter 3 digit number:");
    string userInput = Console.ReadLine();
    int.TryParse(userInput, out userInputNumber);

    if (userInputNumber < 100 || userInputNumber > 999)
    {
        Console.WriteLine("Must be an integer that consist of 3 digits.\n");
        continue;
    }

    int number = userInputNumber;
    int sumOfDigits = 0;
    while (number > 0)
    {
        sumOfDigits += number % 10;
        number /= 10;
    }
    bool isEven = sumOfDigits % 2 == 0;

    Console.WriteLine("Sum of the digits are even: " + isEven + "\n");

} while (true);*/
#endregion


#region Task 2
/*int givenNumber = 3241;
int sumOfDigits = 0;
int digitCount = 0;
while (givenNumber > 0)
{
    sumOfDigits += givenNumber % 10;
    givenNumber /= 10;
    digitCount++;
}


float average = (float) sumOfDigits / digitCount;
Console.WriteLine("Average: " + average);*/
#endregion




#region Task 3
/*int givenNumber = 555;
int sumOfDigits = 0;
int itteratingNumber = givenNumber;
while (itteratingNumber > 0)
{
    sumOfDigits += itteratingNumber % 10;
    itteratingNumber /= 10;
}


bool dividedBy3 = givenNumber % 3 == 0;
bool dividedBy5 = givenNumber % 5 == 0;
Console.WriteLine("Divided by 3: " + dividedBy3);
Console.WriteLine("Divided by 5: " + dividedBy5);*/
#endregion




#region Task 4
/*float GPA = 55.5f;
switch (GPA)
{
    case <= 100 and  >= 91:
        Console.WriteLine("A");
        break;
    case < 91 and >= 81:
        Console.WriteLine("B");
        break;
    case < 81 and >= 71:
        Console.WriteLine("C");
        break;
    case < 71 and >= 61:
        Console.WriteLine("D");
        break;
    case < 61 and >= 51:
        Console.WriteLine("E");
        break;
    case < 51 and >= 1:
        Console.WriteLine("F");
        break;
    default:
        Console.WriteLine("Invalid GPA");
        break;
}
*/
#endregion

#region Task 5
/*int givenNumber1 = 10;
int givenNumber2 = 20;
if (givenNumber1 % 2 == 0 &&  givenNumber2 % 2 == 0)
{
    Console.WriteLine("Sum: " + (givenNumber1 + givenNumber2));
}
else
{
    Console.WriteLine("Substraction: " + (givenNumber1 - givenNumber2));
}*/
#endregion


#region Task 6
/*int salary = 500;
int desiredCredit = 10000;

int yearlySalary = salary * 12;

if (yearlySalary * 0.6 < desiredCredit)
{
    Console.WriteLine("Couldn't proceed");
}
else
{
    Console.WriteLine("Successful");
}*/
#endregion