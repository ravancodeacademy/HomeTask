int[] givenArray = [1, 2, 3, 4, 5];

int newSize = 6;

int[] newArray = new int[newSize];

int defaultDigit = default;

for (int i = 0; i < newSize; i++)
{
    if (i < givenArray.Length)
    {
        defaultDigit = givenArray[i];
    }
    else
    {
        defaultDigit = default;
    }
    newArray[i] = defaultDigit;
}

foreach (int element in newArray)
{
    Console.Write(element);
    Console.Write(" ");
}