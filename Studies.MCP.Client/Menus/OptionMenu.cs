

internal abstract class OptionMenu : Menu
{
    public int SelectedOption => int.Parse(_input!);

    protected abstract Dictionary<int, string> GetMenuOptions();

    protected override async Task ReadMenuContentAsync()
    {
        foreach (var option in GetMenuOptions())
        {
            Console.WriteLine($"{option.Key} - {option.Value}");
        }
        Console.Write("Selecione uma opção: ");
        base.ReadInput();
        while (!IsInputValid())
        {
            WriteLine();
            WriteLine(GetInvalidInputMessage());
            await Task.Delay(1000);
            await HandleAsync();
        }
    }

    protected override bool HasContent() => HasOptions();

    protected override bool IsInputValid() => base.IsInputValid() && int.TryParse(_input, out _);

    protected override string GetNoContentMessage() => "Nenhuma opção disponível.";

    protected override string GetInvalidInputMessage() => "Opção inválida. Tente novamente.";
    
    internal bool HasOptions() => GetMenuOptions().Count > 0;
}