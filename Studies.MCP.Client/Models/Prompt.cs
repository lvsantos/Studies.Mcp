public sealed class Prompt
{
    private readonly List<Argument> _arguments;

    internal Prompt(string name, string? title, string? description, IEnumerable<Argument>? arguments = null)
    {
        Name = name;
        Title = title;
        Description = description;
        Content = string.Empty;
        _arguments = arguments?.ToList() ?? [];
    }

    internal string Name { get; }
    internal string? Title { get; }
    internal string? Description { get; }
    internal string Content { get; private set; }
    internal IReadOnlyList<Argument> Arguments => _arguments;

    internal void SetContent(string content)
    {
        Content = content;
    }
    internal void DefineArgumentValue(string argumentName, string value)
    {
        Argument? argument = _arguments.FirstOrDefault(arg => arg.Name == argumentName);
        if (argument is null)
        {
            throw new ArgumentException($"Argumento '{argumentName}' não encontrado no prompt '{Name}'.");
        }

        argument.ChangeValue(value);
    }
    internal bool HasArguments() => _arguments.Count > 0;
}