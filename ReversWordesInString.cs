using System;

public static class ReverseWordsInString
{
    /// <summary>
    /// Reverses the order of words in the given string and prints the result to the console.
    /// Words are assumed to be separated by spaces.
    /// </summary>
    /// <param name="inputString">The input string whose words are to be reversed.</param>
    /// <remarks>
    /// If the input string is null, empty, or consists only of whitespace, "Empty String" is printed.
    /// </remarks>
    /// <example>
    /// Input:  "Hello World from Copilot"
    /// Output: "Copilot from World Hello"
    /// </example>
    public static void Run(string inputString)
    {
        if (string.IsNullOrWhiteSpace(inputString))
            Console.WriteLine("Empty String");

        string result = "";
        int end = inputString.Length;
        for (int i = inputString.Length - 1; i >= 0; i--)
        {
            if (inputString[i] == ' ')
            {
                result += inputString.Substring(i + 1, end - i - 1) + " ";
                end = i;
            }
        }
        // Add the first word
        result += inputString.Substring(0, end);
        Console.WriteLine(result);
    }
}