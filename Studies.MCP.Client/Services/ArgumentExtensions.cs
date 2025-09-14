using ModelContextProtocol.Protocol;

internal static class ArgumentExtensions
{
    internal static Argument ToArgument(this PromptArgument clientArgument)
    {
       return new Argument(
           clientArgument.Name,
           clientArgument.Title,
           clientArgument.Description,
           clientArgument.Required);
    }
}