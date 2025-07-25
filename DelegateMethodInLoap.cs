delegate void Printer();

public static class DelegateMethodInLoap
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