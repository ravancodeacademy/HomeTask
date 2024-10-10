class Program
{

    static void Main(string[] args)
    {
        bool containsText = ContainsSubstring("my initial string", "initial");
        if (!containsText)
        {
            Console.WriteLine("No substring");
        }
        else
        {
            Console.WriteLine("Substring exists");            
        }
    }


    public static bool ContainsSubstring(string initialString, string substring)
    {
        bool containsText = true;

        for (int i = 0; i < initialString.Length; i++)
        {
            if (initialString.Length - i < substring.Length)
            {
                break;
            }

            containsText = true;
            for (int j = 0; j < substring.Length; j++)
            {
                if (substring[j] != initialString[i + j])
                {
                    containsText = false;
                    break;
                }
            }
            if (containsText)
            {
                break;
            }
        }

        return containsText;
    }

}