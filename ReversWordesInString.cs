using System;

public static class ReverseWordsInString
{
    public static void Run(string str)
    {
        if (string.IsNullOrWhiteSpace(str))
            Console.WriteLine("Empty String");

        string result = "";
        int end = str.Length;
        for (int i = str.Length - 1; i >= 0; i--)
        {
            if (str[i] == ' ')
            {
                result += str.Substring(i + 1, end - i - 1) + " ";
                end = i;
            }
        }
        // Add the first word
        result += str.Substring(0, end);
        Console.WriteLine(result);
    }
}