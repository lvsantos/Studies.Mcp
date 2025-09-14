using ModelContextProtocol.Client;
using ModelContextProtocol.Protocol;

internal class PromptsService(IMcpClient client) : IAsyncDisposable
{
    private readonly IMcpClient _client = client;

    internal async Task<List<Prompt>> GetAllAsync()
    {
        IList<McpClientPrompt> clientPrompts = await _client.ListPromptsAsync();
        List<Prompt> prompts = [];
        foreach (var prompt in clientPrompts)
        {
            prompts.Add(prompt.ToClientPrompt());
        }
        return prompts;
    }

    internal async Task<Prompt?> GetByNameAsync(string name)
    {
        List<Prompt> prompts = await GetAllAsync();
        return prompts.SingleOrDefault(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
    }

    internal async Task<Prompt> Generate(Prompt prompt)
    {
        GetPromptResult result = await _client.GetPromptAsync(
            prompt.Name,
            prompt.Arguments.ToDictionary(arg => arg.Name, arg => (object?)arg.Value));
        string content = result.Messages.First().Content is TextContentBlock textContent
            ? textContent.Text
            : string.Empty;
        prompt.SetContent(content);
        return prompt;
    }

    ValueTask IAsyncDisposable.DisposeAsync() => _client.DisposeAsync();
}