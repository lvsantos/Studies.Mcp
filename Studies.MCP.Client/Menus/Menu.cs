
internal abstract class Menu : ConsoleHandler
{
    protected abstract string GetLoadingMessage();
    protected abstract bool HasContent();
    protected abstract string GetNoContentMessage();
    protected abstract string GetMenuTitle();
    protected abstract Task ReadMenuContentAsync();
    protected abstract string GetInvalidInputMessage();

    protected virtual bool IsInputValid() => !string.IsNullOrWhiteSpace(_input);

    internal async Task HandleAsync()
    {
        await ShowMenuAsync();
        await ReadMenuContentAsync();
    }

    private async Task ShowMenuAsync()
    {
        await LoadingConsoleAsync(GetLoadingMessage(), 3000);

        if (!HasContent())
        {
            WriteLine(GetNoContentMessage());
            return;
        }

        WriteLine("================================================");
        WriteLine($"    {GetMenuTitle()}      ");
        WriteLine("================================================");
        WriteLine();
    }
}