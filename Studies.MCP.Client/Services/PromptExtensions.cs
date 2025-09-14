using ModelContextProtocol.Client;
using ModelContextProtocol.Protocol;

internal static class PromptExtensions
{
    internal static Prompt ToClientPrompt(this McpClientPrompt clientPrompt)
    {
        List<Argument> arguments = [];
       if (clientPrompt.ProtocolPrompt.Arguments is not null)
        {
            foreach (PromptArgument argument in clientPrompt.ProtocolPrompt.Arguments)
            {
                arguments.Add(argument.ToArgument());
            }
        }
       return new(clientPrompt.Name, clientPrompt.Title, clientPrompt.Description, arguments);
    }
}