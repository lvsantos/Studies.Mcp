using System.Collections.ObjectModel;

internal sealed class ArgumentMenu : ListMenu
{
    private readonly List<Argument> _arguments;

    internal ArgumentMenu(IEnumerable<Argument> arguments)
    {
        _arguments = [.. arguments];
    }

    internal ReadOnlyDictionary<string, object?> SelectedArguments
    {
        get
        {
            var dict = new Dictionary<string, object?>();
            for (int i = 0; i < _arguments.Count; i++)
            {
                dict[_arguments[i].Name] = SelectedList[i]!;
            }
            return new ReadOnlyDictionary<string, object?>(dict);
        }
    }

    protected override string GetLoadingMessage() => "Carregando prompt selecionado...";

    protected override List<string> GetMenuList()
    {
        List<string> argumentTexts = [];
        foreach (Argument argument in _arguments)
        {
            string argumentText = string.IsNullOrWhiteSpace(argument.Description) ?
                argument.Name :
                $"{argument.Name} - {argument.Description}";
            argumentTexts.Add($"Por favor, insira o valor para o argumento: {argumentText}");
        }
        return argumentTexts;
    }

    protected override string GetMenuTitle() => "Argumentos do prompt";

    protected override string GetNoContentMessage() => "Nenhum argumento disponível para o prompt selecionado.";

    internal bool HasArguments() => HasContent();
}