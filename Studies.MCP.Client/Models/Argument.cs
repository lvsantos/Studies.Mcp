public sealed class Argument
{
    internal Argument(string name, string? title = null, string? description = null, bool? isRequired = null)
    {
        Name = name;
        Title = title;
        Description = description;
        IsRequired = isRequired;
        Value = null;
    }

    public string Name { get; }
    public string? Title { get; }
    public string? Description { get; }
    public bool? IsRequired { get; }
    public string? Value { get; private set; }
    public bool HasValue() => !string.IsNullOrWhiteSpace(Value);

    internal void ChangeValue(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentException("O valor do argumento não pode ser nulo ou vazio.", nameof(value));
        }

        Value = value;
    }

}