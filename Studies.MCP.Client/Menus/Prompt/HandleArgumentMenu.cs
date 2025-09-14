internal sealed class HandleArgumentMenu
{
    private readonly ArgumentMenu _argumentMenu;

    public HandleArgumentMenu(IEnumerable<Argument> arguments)
    {
        _argumentMenu = new ArgumentMenu(arguments);
    }

    public async Task<Dictionary<string, object?>> HandleAsync()
    {
        await _argumentMenu.HandleAsync();
        if (!_argumentMenu.HasArguments())
        {
            return [];
        }

        Dictionary<string, object?> arguments = _argumentMenu.SelectedArguments
            .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
        return arguments;
    }
}
