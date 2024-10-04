/*#region Task 1
int[] numbers = [1, 2, 3, 4, 5];
int greatestNumber = default;
foreach (var number in numbers)
{
    if (number % 2 != 0)
    {
        continue;
    }
    //Initialize the highest
    if (greatestNumber == 0)
    {
        greatestNumber = number;
        continue;
    }

    if (number > greatestNumber)
    {
        greatestNumber = number;
    }
}

if (greatestNumber == 0)
{
    Console.WriteLine("No item found");
}
else
{
    Console.WriteLine(greatestNumber);
}

#endregion*/

/*#region Task 2
int[] numbers = [1, 2, 3, 4, 5];
int leastNumber = default;
foreach (var number in numbers)
{
    if (number % 2 == 0)
    {
        continue;
    }

    //Initialize the lowest
    if (leastNumber == 0)
    {
        leastNumber = number;
        continue;
    }

    if (number < leastNumber)
    {
        leastNumber = number;
    }
}

if (leastNumber == 0)
{
    Console.WriteLine("No item found");
}
else
{
    Console.WriteLine(leastNumber);
}
#endregion*/

/*#region Task 3
int[] numbers = [1, 2, 3, 4];
int element;
for (int i = 0; i < numbers.Length / 2; i++)
{
    element = numbers[i];
    numbers[i] = numbers[^(i + 1)];
    numbers[^(i + 1)] = element;
}

// Print the list
foreach(int i in numbers)
{
    Console.WriteLine(i);
}
#endregion*/

/*#region Task 4
int[] numbers = [1, 2, 3, 4];
int count = 0;
foreach (int number in numbers)
{
    count++;
}
Console.WriteLine(count);
#endregion*/

/*#region Task 5
int[] numbers = [1, 2, 3, 4];
int givenNumber = 3;
bool numberExists = false;
foreach (int number in numbers)
{
    if (number == givenNumber) {
        numberExists = true;
        break;
    };
}
Console.WriteLine("Number exists: " + numberExists);
#endregion*/

/*#region Task 6
int[] numbers = [1, 2, 3, 4];
int givenNumber = 2;
int occurCount = 0;
foreach (int number in numbers)
{
    if (number == givenNumber) occurCount++;
}
Console.WriteLine("How many times the element occures in the text: " + occurCount);
#endregion*/