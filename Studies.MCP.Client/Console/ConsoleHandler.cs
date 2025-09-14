internal abstract class ConsoleHandler
{
    protected string? _input;

    internal static async Task LoadingConsoleAsync(string message, int delay = 500, bool clearConsole = true)
    {
        if (clearConsole)
        {
            Console.Clear();
        }
        else
        {
            Console.WriteLine();
        }
        Console.WriteLine(message);

        await Task.Delay(delay);

        Console.Clear();
    }

    internal static void Clear() => Console.Clear();
    internal static void WriteLine(string message) => Console.WriteLine(message);
    internal static void WriteLine() => Console.WriteLine();
    internal static void Write(string message) => Console.Write(message);
    internal static void WaitForKeyPress() => Console.ReadKey();

    protected void ReadInput() => _input = Console.ReadLine();
}