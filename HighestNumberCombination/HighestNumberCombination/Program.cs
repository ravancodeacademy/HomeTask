int givenNumber = 17534059;

#region Digit Counter
int tempNumber = givenNumber;
int digitCount = 0;
while (tempNumber != 0)
{
    digitCount++;
    tempNumber /= 10;
}
#endregion

#region Create the Array of Digits
int[] digitArray = new int[digitCount];
for (int i = 0; i < digitCount; i++)
{
    digitArray[i] = givenNumber % 10;
    givenNumber /= 10;
}
#endregion

#region Sort the array using Selection Sort
int maxElementIndex;
for (int i = 0; i < digitArray.Length; i++)
{
    maxElementIndex = i;
    for (int j = i + 1;  j < digitArray.Length; j++)
    {
        if (digitArray[j] > digitArray[maxElementIndex])
        {
            maxElementIndex = j;
        }
    }

    if (maxElementIndex != i)
    {
        (digitArray[maxElementIndex],  digitArray[i]) = (digitArray[i], digitArray[maxElementIndex]);
    }
}
#endregion

#region Print the Number
foreach (int digit in digitArray)
{
    Console.Write(digit);
}
#endregion