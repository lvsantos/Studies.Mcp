internal sealed class PromptMenu : OptionMenu
{
    private readonly List<Prompt> _prompts;

    internal PromptMenu(IEnumerable<Prompt> prompts)
    {
        _prompts = [.. prompts];
    }

    protected override string GetLoadingMessage() => "Carregando prompts...";

    protected override string GetMenuTitle() => "Prompts disponíveis";

    protected override Dictionary<int, string> GetMenuOptions()
    {
        return _prompts.Select((prompt, index) => new { prompt, index = index + 1 })
            .ToDictionary(x => x.index, x => $"{x.prompt.Name} - {x.prompt.Description}");
    }

    protected override bool IsInputValid() =>
        base.IsInputValid() && SelectedOption > 0 && SelectedOption <= _prompts.Count;

    protected override string GetNoContentMessage() => "Nenhum prompt disponível.";
}