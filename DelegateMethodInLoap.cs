delegate void Printer();

public static class DelegateMethodInLoap
/// <summary>
/// Demonstrates the behavior of capturing loop variables in lambda expressions within a loop.
/// <para>
/// This method creates a list of delegate methods (of type <c>Printer</c>) that print the value of the loop variable <c>i</c> in two different ways:
/// <list type="bullet">
/// <item>
/// <description>By capturing the loop variable <c>i</c> directly in the lambda expression. This causes all such lambdas to print the final value of <c>i</c> after the loop completes.</description>
/// </item>
/// <item>
/// <description>By capturing a local copy of <c>i</c> (assigned to <c>local</c>) in the lambda expression. This ensures each lambda prints the value of <c>i</c> at the time the lambda was created.</description>
/// </item>
/// </list>
/// </para>
/// <para>
/// Example:
/// <code>
/// Run();
/// </code>
/// Output:
/// <code>
/// Using reference: 10
/// using value: 0
/// Using reference: 10
/// using value: 1
/// Using reference: 10
/// using value: 2
/// Using reference: 10
/// using value: 3
/// Using reference: 10
/// using value: 4
/// Using reference: 10
/// using value: 5
/// Using reference: 10
/// using value: 6
/// Using reference: 10
/// using value: 7
/// Using reference: 10
/// using value: 8
/// Using reference: 10
/// using value: 9
/// </code>
/// </para>
/// <remarks>
/// This example highlights a common pitfall when using closures in loops in C#: capturing the loop variable directly causes all lambdas to reference the same variable, which will have its final value after the loop ends.
/// </remarks>
/// </summary>
{

    public static void Run()
    {
        List<Printer> printers = [];

        for (int i = 0; i < 10; i++)
        {
            // Capturing the loop variable directly in the lambda expression
            // This will cause all lambdas to print the last value of i (10)
            printers.Add(() => Console.WriteLine("Using reference: " + i));

            // Using a local variable to capture the current value of i
            // This will ensure each lambda prints its own value of i
            int local = i;
            printers.Add(() => Console.WriteLine("using value: " + local));
        }

        foreach (var printer in printers)
        {
            printer();
        }
    }
}